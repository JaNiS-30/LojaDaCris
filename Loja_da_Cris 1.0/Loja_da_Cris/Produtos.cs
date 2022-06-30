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
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }

        // Atualiza o tempo no rodape
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

        // Funcao para limpar os campos
        private void LimparForm()
        {
            txCodigoBarras.Clear();
            txNome.Clear();
            mtxQuantidade.Clear();
            mtxCusto.Clear();
            mtxMargem.Clear();
            mtxVenda.Clear();

            txCodigoBarras.Focus();
        }

        // Abre a table no form
        private void Produtos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lojaDaCrisDataSet.Produtos' table. You can move, or remove it, as needed.
            this.produtosTableAdapter.Fill(this.lojaDaCrisDataSet.Produtos);
            // TODO: This line of code loads data into the 'lojaDaCrisDataSet.Categoria' table. You can move, or remove it, as needed.
            this.categoriaTableAdapter.Fill(this.lojaDaCrisDataSet.Categoria);

        }

        private void btAdcProduto_Click(object sender, EventArgs e)
        {
            bool bOK = true;

            SqlConnection conn;
            SqlCommand comm;

            string connectionString = Properties.Settings.Default.LojaDaCrisConnectionString;

            conn = new SqlConnection(connectionString);

            // Comando SQL para incluir na table Produtos
            comm = new SqlCommand(
                "INSERT INTO Produtos (CodigoDeBarras, NomeProduto, Quantidade, Categoria, Custo, Margem, Venda) " +
                "VALUES (@CodigoDeBarras, @NomeProduto, @Quantidade, @Categoria, @Custo, @Margem, @Venda)", conn);

            // Cria e configura os parâmetros de adição
            comm.Parameters.Add("@CodigoDeBarras", System.Data.SqlDbType.Int);
            comm.Parameters["@CodigoDeBarras"].Value = txCodigoBarras.Text;

            comm.Parameters.Add("@NomeProduto", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@NomeProduto"].Value = txNome.Text;

            comm.Parameters.Add("@Quantidade", System.Data.SqlDbType.Int);
            comm.Parameters["@Quantidade"].Value = mtxQuantidade.Text;

            comm.Parameters.Add("@Categoria", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Categoria"].Value = cbCategoria.Text;

            comm.Parameters.Add("@Custo", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Custo"].Value = mtxCusto.Text;

            comm.Parameters.Add("@Margem", System.Data.SqlDbType.Int);
            comm.Parameters["@Margem"].Value = mtxMargem.Text;

            comm.Parameters.Add("@Venda", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Venda"].Value = mtxVenda.Text;

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

                    bOK = false;
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

                    bOK = false;
                }
            }
            catch { }
            finally
            {
                // Fechar a conexão com o banco de dados
                conn.Close();

                if (bOK == true)
                {
                    MessageBox.Show("Produto cadastrado com sucesso!",
                        "Sucesso !",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparForm();
                }
            }
        }

        private void btEdtProduto_Click(object sender, EventArgs e)
        {
            bool bOK = true;

            SqlConnection conn;
            SqlCommand comm;

            string connectionString = Properties.Settings.Default.LojaDaCrisConnectionString;

            conn = new SqlConnection(connectionString);

            // Comando SQL para atualizar os dados na table Produtos
            comm = new SqlCommand(
                "UPDATE Produtos SET NomeProduto=@NomeProduto, Quantidade=@Quantidade, Categoria=@Categoria, Custo=@Custo," +
                "Margem=@Margem, Venda=@Venda " +
                "WHERE CodigoDeBarras=@CodigoDeBarras", conn);

            // Cria e configura os parâmetros de edição
            comm.Parameters.Add("@CodigoDeBarras", System.Data.SqlDbType.Int);
            comm.Parameters["@CodigoDeBarras"].Value = txCodigoBarras.Text;

            comm.Parameters.Add("@NomeProduto", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@NomeProduto"].Value = txNome.Text;

            comm.Parameters.Add("@Quantidade", System.Data.SqlDbType.Int);
            comm.Parameters["@Quantidade"].Value = mtxQuantidade.Text;

            comm.Parameters.Add("@Categoria", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Categoria"].Value = cbCategoria.Text;

            comm.Parameters.Add("@Custo", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Custo"].Value = mtxCusto.Text;

            comm.Parameters.Add("@Margem", System.Data.SqlDbType.Int);
            comm.Parameters["@Margem"].Value = mtxMargem.Text;

            comm.Parameters.Add("@Venda", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Venda"].Value = mtxVenda.Text;


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

                    bOK = false;
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

                    bOK = false;
                }
            }
            catch { }
            finally
            {
                // Fechar a conexão com o banco de dados
                conn.Close();

                if (bOK == true)
                {
                    MessageBox.Show("Produto alterado com sucesso!",
                        "Sucesso !",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparForm();
                }
            }
        }

        private void btExcProduto_Click(object sender, EventArgs e)
        {
            bool bOK = true;

            SqlConnection conn;
            SqlCommand comm;

            string connectionString = Properties.Settings.Default.LojaDaCrisConnectionString;

            conn = new SqlConnection(connectionString);

            // Comando SQL para deletar uma linha na table Produtos
            comm = new SqlCommand("DELETE FROM Produtos WHERE CodigoDeBarras = @CodigoDeBarras", conn);

            // Cria e configura os parâmetros de exclusão
            comm.Parameters.Add("@CodigoDeBarras", System.Data.SqlDbType.Int);
            comm.Parameters["@CodigoDeBarras"].Value = txCodigoBarras.Text;


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

                    bOK = false;
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

                    bOK = false;
                }
            }
            catch { }
            finally
            {
                // Fechar a conexão com o banco de dados
                conn.Close();

                if (bOK == true)
                {
                    MessageBox.Show("Produto deletado com sucesso!",
                        "Sucesso !",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparForm();
                }
            }
        }

        private void btConsultarProduto_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;

            // Cria a string de conexão
            string connectionString = Properties.Settings.Default.LojaDaCrisConnectionString;

            // Iniciar a conexão com o banco de dados
            conn = new SqlConnection(connectionString);

            // Cria o comando SQL de consulta
            comm = new SqlCommand(
                "SELECT CodigoDeBarras, NomeProduto, Quantidade, Categoria, Custo, Margem, Venda FROM Produtos " +
                "WHERE CodigoDeBarras = @CodigoDeBarras", conn);

            // Cria e configura o parâmetro de pesquisa
            comm.Parameters.Add("@CodigoDeBarras", System.Data.SqlDbType.Int);
            comm.Parameters["@CodigoDeBarras"].Value = txCodigoBarras.Text;


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

                    // Se encontrou um registro, repassa os dados para o form
                    if (reader.Read())
                    {
                        txNome.Text = reader["NomeProduto"].ToString();
                        mtxQuantidade.Text = reader["Quantidade"].ToString();
                        cbCategoria.Text = reader["Categoria"].ToString();
                        mtxCusto.Text = reader["Custo"].ToString();
                        mtxMargem.Text = reader["Margem"].ToString();
                        mtxVenda.Text = reader["Venda"].ToString();

                    }

                    reader.Close(); // Encerra o leitor de dados 
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao executar o comando SQL",
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

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int iCodigo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;

            // Cria a string de conexão
            string connectionString = Properties.Settings.Default.LojaDaCrisConnectionString;

            // Iniciar a conexão com o banco de dados
            conn = new SqlConnection(connectionString);

            // Cria o comando SQL de consulta
            comm = new SqlCommand(
                "SELECT CodigoDeBarras, NomeProduto, Quantidade, Categoria, Custo, Margem, Venda FROM Produtos " +
                "WHERE CodigoDeBarras = @CodigoDeBarras", conn);

            // Cria e configura o parâmetro de pesquisa
            comm.Parameters.Add("@CodigoDeBarras", System.Data.SqlDbType.Int);
            comm.Parameters["@CodigoDeBarras"].Value = iCodigo;

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

                    // Se encontrou um registro, repassa os dados para o form
                    if (reader.Read())
                    {
                        txCodigoBarras.Text = reader["CodigoDeBarras"].ToString();
                        txNome.Text = reader["NomeProduto"].ToString();
                        mtxQuantidade.Text = reader["Quantidade"].ToString();
                        cbCategoria.Text = reader["Categoria"].ToString();
                        mtxCusto.Text = reader["Custo"].ToString();
                        mtxMargem.Text = reader["Margem"].ToString();
                        mtxVenda.Text = reader["Venda"].ToString();
                    }

                    reader.Close(); // Encerra o leitor de dados 
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao executar o comando SQL",
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

        // Abre o form de relatorio de produtos
        private void btRelCliente_Click(object sender, EventArgs e)
        {
            RelatorioProdutos frm = new RelatorioProdutos();

            frm.Show();
        }

        
    }
}
