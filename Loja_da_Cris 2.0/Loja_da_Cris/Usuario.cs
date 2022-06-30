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
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lojaDaCrisDataSetNovo.Vendedor' table. You can move, or remove it, as needed.
            this.vendedorTableAdapter.Fill(this.lojaDaCrisDataSetNovo.Vendedor);

            this.clienteTableAdapter.Fill(this.lojaDaCrisDataSetNovo.Cliente);

        }

        private void AtualizaListaUsuario()
        {
            this.vendedorTableAdapter.Fill(this.lojaDaCrisDataSetNovo.Vendedor);
        }

        private void LimparForm()
        {
            mtxIDVendedor.Clear();
            cbNome.Text = "";
            txUsuario.Clear();
            txSenha1.Clear();
            txSenha2.Clear();
            mtxSalario.Clear();
            mtxComissao.Clear();
            chbIsAdm.Checked = false;

            mtxIDVendedor.Focus();
        }

        private void btAdcCliente_Click(object sender, EventArgs e)
        {
            bool bOK = true;

            SqlConnection conn;
            SqlCommand comm;

            string connectionString = Properties.Settings.Default.LojaDaCrisConnectionString;

            conn = new SqlConnection(connectionString);

            // Comando SQL para incluir na table Clientes

            comm = new SqlCommand(
                "INSERT INTO Vendedor (ID_Cliente, Usuario, Senha, DataTrocaSenha, Comissao, ComissaoRecebida, Salario, IS_ADM) " +
                "VALUES (@ID_Cliente, @Usuario, @Senha, @DataTrocaSenha, @Comissao, @ComissaoRecebida, @Salario, @IS_ADM)", conn);

            // Cria e configura os parâmetros de adição
            comm.Parameters.Add("@ID_Cliente", System.Data.SqlDbType.Int);
            comm.Parameters["@ID_Cliente"].Value = Convert.ToInt32(cbNome.SelectedValue);

            comm.Parameters.Add("@Usuario", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Usuario"].Value = txUsuario.Text;

            comm.Parameters.Add("@Senha", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Senha"].Value = txSenha1.Text;

            comm.Parameters.Add("@DataTrocaSenha", System.Data.SqlDbType.Date);
            comm.Parameters["@DataTrocaSenha"].Value = DateTime.Now.ToString("d");

            comm.Parameters.Add("@Comissao", System.Data.SqlDbType.Float);
            comm.Parameters["@Comissao"].Value = Convert.ToSingle(mtxComissao.Text).ToString("N2");

            comm.Parameters.Add("@ComissaoRecebida", System.Data.SqlDbType.Money);
            comm.Parameters["@ComissaoRecebida"].Value = 0.00;

            comm.Parameters.Add("@Salario", System.Data.SqlDbType.Money);
            comm.Parameters["@Salario"].Value = Convert.ToSingle(mtxSalario.Text).ToString("N2");

            comm.Parameters.Add("@IS_ADM", System.Data.SqlDbType.Bit);
            comm.Parameters["@IS_ADM"].Value = chbIsAdm.Checked;


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

                if (txSenha1.Text == txSenha2.Text)
                {
                    // Executa o comando SQL para inserir dados na base de dados
                    try
                    {
                        comm.ExecuteNonQuery();
                        AtualizaListaUsuario();
                        LimparForm();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message,
                            "Erro ao tentar executar o comando SQL.",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                        bOK = false;
                    }
                }
                else
                {
                    MessageBox.Show("Erro na confirmação da senha!",
                        "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    bOK = false;
                    txSenha1.Clear();
                    txSenha2.Clear();
                }
            }
            catch { }
            finally
            {
                // Fechar a conexão com o banco de dados
                conn.Close();

                if (bOK == true)
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!",
                        "Sucesso !",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btExcCliente_Click(object sender, EventArgs e)
        {
            bool bOK = true;

            SqlConnection conn;
            SqlCommand comm;

            string connectionString = Properties.Settings.Default.LojaDaCrisConnectionString;

            conn = new SqlConnection(connectionString);

            // Comando SQL para deletar uma linha na table Produtos
            comm = new SqlCommand("DELETE FROM Vendedor WHERE ID_Vendedor = @ID_Vendedor", conn);

            // Cria e configura os parâmetros de exclusão
            comm.Parameters.Add("@ID_Vendedor", System.Data.SqlDbType.Int);
            comm.Parameters["@ID_Vendedor"].Value = mtxIDVendedor.Text;


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
                    AtualizaListaUsuario();
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
                    MessageBox.Show("Usuário deletado com sucesso!",
                        "Sucesso !",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void btConsultar_Click(object sender, EventArgs e)
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
                "SELECT V.ID_Vendedor, C.Nome, V.Usuario, V.Senha, V.Comissao, V.Salario, V.IS_ADM " +
                "FROM Vendedor AS V " +
                "INNER JOIN Cliente AS C " +
                "ON V.ID_Cliente = C.ID_Cliente " +
                "WHERE ID_Vendedor = @ID_Vendedor", conn);

            // Cria e configura o parâmetro de pesquisa
            comm.Parameters.Add("@ID_Vendedor", System.Data.SqlDbType.Int);
            comm.Parameters["@ID_Vendedor"].Value = mtxIDVendedor.Text;


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
                    LimparForm();

                    // Se encontrou um registro, repassa os dados para o form
                    if (reader.Read())
                    {
                        mtxIDVendedor.Text = reader["ID_Vendedor"].ToString();
                        cbNome.Text = reader["Nome"].ToString();
                        txUsuario.Text = reader["Usuario"].ToString();
                        txSenha1.Text = reader["Senha"].ToString();
                        txSenha2.Text = reader["Senha"].ToString();
                        if(Convert.ToSingle(reader["Comissao"]).ToString("N2").Length == 4)
                        {
                            mtxComissao.Text = " " + Convert.ToSingle(reader["Comissao"]).ToString("N2");
                        }
                        else
                        {
                            mtxComissao.Text = Convert.ToSingle(reader["Comissao"]).ToString("N2");
                        }

                        if(Convert.ToSingle(reader["Salario"]).ToString("N2").Length == 8)
                        {
                            mtxSalario.Text = "  " + Convert.ToSingle(reader["Salario"]).ToString("N2");
                        }else if (Convert.ToSingle(reader["Salario"]).ToString("N2").Length == 9)
                        {
                            mtxSalario.Text = " " + Convert.ToSingle(reader["Salario"]).ToString("N2");
                        }
                        else
                        {
                            mtxSalario.Text = Convert.ToSingle(reader["Salario"]).ToString("N2");
                        }
                        chbIsAdm.Checked = Convert.ToBoolean(reader["IS_ADM"]);
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

        private void btEdtCliente_Click(object sender, EventArgs e)
        {
            bool bOK = true;

            SqlConnection conn;
            SqlCommand comm;

            string connectionString = Properties.Settings.Default.LojaDaCrisConnectionString;

            conn = new SqlConnection(connectionString);

            // Comando SQL para atualizar os dados na table Produtos
            comm = new SqlCommand(
                "UPDATE Vendedor SET ID_Cliente = @ID_Cliente, Usuario = @Usuario, Senha = @Senha, " +
                "DataTrocaSenha = @DataTrocaSenha, Comissao = @Comissao, Salario = @Salario, IS_ADM = @IS_ADM " +
                "WHERE ID_Vendedor=@ID_Vendedor", conn);

            // Cria e configura os parâmetros de edição
            comm.Parameters.Add("@ID_Vendedor", System.Data.SqlDbType.Int);
            comm.Parameters["@ID_Vendedor"].Value = mtxIDVendedor.Text;

            comm.Parameters.Add("@ID_Cliente", System.Data.SqlDbType.Int);
            comm.Parameters["@ID_Cliente"].Value = Convert.ToInt32(cbNome.SelectedValue);

            comm.Parameters.Add("@Usuario", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Usuario"].Value = txUsuario.Text;

            comm.Parameters.Add("@Senha", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Senha"].Value = txSenha1.Text;

            comm.Parameters.Add("@DataTrocaSenha", System.Data.SqlDbType.Date);
            comm.Parameters["@DataTrocaSenha"].Value = DateTime.Now.ToString("d");

            comm.Parameters.Add("@Comissao", System.Data.SqlDbType.Float);
            comm.Parameters["@Comissao"].Value = String.Format("{0:F2}", mtxComissao.Text);

            comm.Parameters.Add("@Salario", System.Data.SqlDbType.Money);
            comm.Parameters["@Salario"].Value = String.Format("{0:F2}", mtxSalario.Text);

            comm.Parameters.Add("@IS_ADM", System.Data.SqlDbType.Bit);
            comm.Parameters["@IS_ADM"].Value = chbIsAdm.Checked;


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

                if (txSenha1.Text == txSenha2.Text)
                {
                    try
                    {
                        comm.ExecuteNonQuery();
                        AtualizaListaUsuario();
                        LimparForm();
                    }

                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message,
                            "Erro ao tentar executar o comando SQL.",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                        bOK = false;
                    }
                }
                else
                {
                    MessageBox.Show("Erro na confirmação da senha!",
                        "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    bOK = false;
                    txSenha1.Clear();
                    txSenha2.Clear();
                }
            }
            catch { }
            finally
            {
                // Fechar a conexão com o banco de dados
                conn.Close();

                if (bOK == true)
                {
                    MessageBox.Show("Usuário alterado com sucesso!",
                        "Sucesso !",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void mtxSalario_MouseUp(object sender, MouseEventArgs e)
        {
           SendKeys.Send("{HOME}");
        }

        private void mtxComissao_MouseUp(object sender, MouseEventArgs e)
        {
            SendKeys.Send("{HOME}");
        }

        
    }
}
