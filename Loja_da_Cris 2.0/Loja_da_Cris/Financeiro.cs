using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;

namespace Loja_da_Cris
{
    public partial class Financeiro : Form
    {
        public Financeiro()
        {
            InitializeComponent();
        }

        //Atualiza o tempo no rodapé
        private void timer1_Tick(object sender, EventArgs e)
        {
            tsData.Text = DateTime.Now.ToString("D");
            tsHora.Text = DateTime.Now.ToString("T");
        }

        // Volta para o menu principal
        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();

            MenuPrincipal frm = new MenuPrincipal();

            frm.FormClosed += (s, args) => this.Close();

            frm.Show();
        }

        private void btEmitirNota_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;

            // Declara variaveis de comparação de quantidade
            int iQuantidadeSQL = 0, iQuantidadeVenda;

            bool ProdutoSuficiente = true;
            bool CampoVazio = false;

            // Define a variável com a quantidade de produtos desejada para venda
            iQuantidadeVenda = Convert.ToInt32(mtxQuantidade.Text);
     
            // Cria a string de conexão
            string connectionString = Properties.Settings.Default.LojaDaCrisConnectionString;

            // Iniciar a conexão com o banco de dados
            conn = new SqlConnection(connectionString);

            // Cria o comando SQL de consulta
            comm = new SqlCommand(
                "SELECT Quantidade FROM Produtos " +
                "WHERE CodigoDeBarras = @CodigoDeBarras", conn);

            // Cria e configura o parâmetro de pesquisa
            comm.Parameters.Add("@CodigoDeBarras", System.Data.SqlDbType.Int);
            comm.Parameters["@CodigoDeBarras"].Value = txCodigoBarras.Text;

            // Condicional para evitar uma mensagem de erro inesperada
            if (txCodigoBarras.Text != "" || txCodigoBarras.Text != "")
            {
                try
                {
                    try
                    {
                        // Tentar abrir a conexão com a base de dados
                        conn.Open();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message,
                            "Erro ao abrir a conexão com a base de dados!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    try
                    {
                        // Executa o comando SQL
                        reader = comm.ExecuteReader();

                        // Se encontrou um registro, repassa os dados para a variável
                        if (reader.Read())
                        {
                            // Define a variável com o valor do banco de dados
                            iQuantidadeSQL = Convert.ToInt32(reader["Quantidade"]);

                            // Condicional se nao possui a quantidade no SQL
                            if (iQuantidadeSQL < iQuantidadeVenda)
                            {
                                MessageBox.Show("Erro, você não possui essa quantidade de produtos em estoque.",
                                "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                                ProdutoSuficiente = false;
                            }
                        }
                        reader.Close(); // Encerra o leitor de dados 
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message,
                            "Erro ao executar o comando SQL!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                catch { }
                finally
                {
                    conn.Close(); // Fecha a conexão com a base de dados
                }
            }
            
            // Mensagem de erro caso algum campo esteja vazio
            if (txNomeCliente.Text == "" || txProduto.Text == "" || txCodigoBarras.Text == "")
            {
                MessageBox.Show("Erro, preencha todos os campos para gerar a nota fiscal.",
                            "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            CampoVazio = true;
            }

            // Declara os parametros para construção do form nota fiscal, com os valores dos textbox
            if (ProdutoSuficiente == true && CampoVazio == false)
            {
                this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Nome", "Nome: " + txNomeCliente.Text));
                this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("CPF", "CPF: " + mtxCPF.Text));
                this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Telefone", "Telefone: " + mtxTelefone.Text));
                this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Produto", mtxQuantidade.Text + " " + txProduto.Text));
                this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Valor", "Valor: " + Convert.ToDouble(mtxPreco.Text) * Convert.ToDouble(mtxQuantidade.Text)));
                this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Pagamento", "Forma de pagamento: " + cbCategoria.Text));
                this.reportViewer1.RefreshReport();

                conn = new SqlConnection(connectionString);

                // Cria um novo comando SQL para subtrair os produtos vendidos da quantidade total, no banco de dados
                comm = new SqlCommand(
                    "UPDATE Produtos SET Quantidade=@Quantidade " +
                    "WHERE CodigoDeBarras=@CodigoDeBarras", conn);

                comm.Parameters.Add("@CodigoDeBarras", System.Data.SqlDbType.Int);
                comm.Parameters["@CodigoDeBarras"].Value = txCodigoBarras.Text;

                // Valor para update
                comm.Parameters.Add("@Quantidade", System.Data.SqlDbType.Int);
                comm.Parameters["@Quantidade"].Value = iQuantidadeSQL - Convert.ToInt32(mtxQuantidade.Text);

                try
                {
                    // Abrir a conexão com o banco de dados
                    try
                    {
                        conn.Open();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message,
                            "Erro ao tentar abrir uma conexão com o banco de dados.",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Executa o comando SQL para editar os dados na base de dados
                    try
                    {
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message,
                            "Erro ao tentar executar o comando SQL.",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch { }
                finally
                {
                    // Fechar a conexão com o banco de dados
                    conn.Close();

                }

                conn = new SqlConnection(connectionString);

                // Cria um novo comando SQL para adicionar os dados da venda a table de notas
                comm = new SqlCommand(
                    "INSERT INTO Notas (NomeCliente, CPF, Telefone, NomeProduto, Quantidade, Valor, Pagamento, Data) " +
                    "VALUES (@NomeCliente, @CPF, @Telefone, @NomeProduto, @Quantidade, @Valor, @Pagamento, @Data)", conn);

                // Insere os valores para inclusão no banco de dados
                comm.Parameters.Add("@NomeCliente", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@NomeCliente"].Value = txNomeCliente.Text;

                comm.Parameters.Add("@CPF", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@CPF"].Value = mtxCPF.Text;

                comm.Parameters.Add("@Telefone", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@Telefone"].Value = mtxTelefone.Text;

                comm.Parameters.Add("@NomeProduto", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@NomeProduto"].Value = txProduto.Text;

                comm.Parameters.Add("@Quantidade", System.Data.SqlDbType.Int);
                comm.Parameters["@Quantidade"].Value = mtxQuantidade.Text;

                comm.Parameters.Add("@Valor", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@Valor"].Value = Convert.ToDouble(mtxPreco.Text) * Convert.ToDouble(mtxQuantidade.Text);

                comm.Parameters.Add("@Pagamento", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@Pagamento"].Value = cbCategoria.Text;

                comm.Parameters.Add("@Data", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@Data"].Value = DateTime.Now.ToString("d");

                try
                {
                    // Abrir a conexão com o banco de dados
                    try
                    {
                        conn.Open();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message,
                            "Erro ao tentar abrir uma conexão com o banco de dados.",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    // Executa o comando SQL para inserir dados na base de dados
                    try
                    {
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message,
                            "Erro ao tentar executar o comando SQL.",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch { }
                finally
                {
                    // Fechar a conexão com o banco de dados
                    conn.Close();
                }
            }
        }

 
    }
}
