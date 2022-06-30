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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        // Atualiza o tempo no rodapé
        private void timer1_Tick(object sender, EventArgs e)
        {
            tsData.Text = DateTime.Now.ToString("D");
            tsHora.Text = DateTime.Now.ToString("T");
        }
        // Volta para o Menu principal
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
            mtxIdCliente.Clear();
            txNome.Clear();
            txEndereco.Clear();
            cbCidade.Text = "";
            mtxCEP.Clear();
            dtDataNasc.Value = DateTime.Now;
            mtxTelefone.Clear();
            mtxCPF.Clear();
            txEmail.Clear();

            mtxIdCliente.Focus();
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
                "INSERT INTO Clientes (Id_Cliente, Nome, Data_Nasc, Cidade, CEP, Endereco, CPF, Telefone, Email) " +
                "VALUES (@Id_Cliente, @Nome, @Data_Nasc, @Cidade, @CEP, @Endereco, @CPF, @Telefone, @Email)", conn);

            // Cria e configura os parâmetros de adição
            comm.Parameters.Add("@Id_Cliente", System.Data.SqlDbType.Int);
            comm.Parameters["@Id_Cliente"].Value = Convert.ToInt32(mtxIdCliente.Text);

            comm.Parameters.Add("@Nome", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Nome"].Value = txNome.Text;

            comm.Parameters.Add("@Data_Nasc", System.Data.SqlDbType.Date);
            comm.Parameters["@Data_Nasc"].Value = dtDataNasc.Value;

            comm.Parameters.Add("@Cidade", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Cidade"].Value = cbCidade.Text;

            comm.Parameters.Add("@CEP", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CEP"].Value = mtxCEP.Text;

            comm.Parameters.Add("@Endereco", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Endereco"].Value = txEndereco.Text;

            comm.Parameters.Add("@CPF", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CPF"].Value = mtxCPF.Text;

            comm.Parameters.Add("@Telefone", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Telefone"].Value = mtxTelefone.Text;

            comm.Parameters.Add("@Email", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Email"].Value = txEmail.Text;


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
                    MessageBox.Show("Cliente cadastrado com sucesso!",
                        "Sucesso !",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparForm();
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

            // Comando SQL para deletar uma linha na table Clientes

            comm = new SqlCommand("DELETE FROM Clientes WHERE Id_Cliente = @Id_Cliente", conn);
            
            // Cria e configura os parâmetros de exclusão
            comm.Parameters.Add("@Id_Cliente", System.Data.SqlDbType.Int);
            comm.Parameters["@Id_Cliente"].Value = Convert.ToInt32(mtxIdCliente.Text);


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
                    MessageBox.Show("Cliente deletado com sucesso!",
                        "Sucesso !",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparForm();
                }
            }
        }

        private void btEdtCliente_Click(object sender, EventArgs e)
        {
            bool bOK = true;

            SqlConnection conn;
            SqlCommand comm;

            string connectionString = Properties.Settings.Default.LojaDaCrisConnectionString;

            conn = new SqlConnection(connectionString);

            // Comando SQL para atualizar os dados na table Clientes

            comm = new SqlCommand(
                "UPDATE Clientes SET Nome=@Nome, Data_Nasc=@Data_Nasc, Cidade=@Cidade, CEP=@CEP, Endereco=@Endereco, " +
                "CPF=@CPF, Telefone=@Telefone, Email=@Email " +
                "WHERE Id_Cliente=@Id_Cliente", conn);

            // Cria e configura os parâmetros de edição
            comm.Parameters.Add("@Id_Cliente", System.Data.SqlDbType.Int);
            comm.Parameters["@Id_Cliente"].Value = Convert.ToInt32(mtxIdCliente.Text);

            comm.Parameters.Add("@Nome", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Nome"].Value = txNome.Text;

            comm.Parameters.Add("@Data_Nasc", System.Data.SqlDbType.Date);
            comm.Parameters["@Data_Nasc"].Value = dtDataNasc.Value;

            comm.Parameters.Add("@Cidade", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Cidade"].Value = cbCidade.Text;

            comm.Parameters.Add("@CEP", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CEP"].Value = mtxCEP.Text;

            comm.Parameters.Add("@Endereco", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Endereco"].Value = txEndereco.Text;

            comm.Parameters.Add("@CPF", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CPF"].Value = mtxCPF.Text;

            comm.Parameters.Add("@Telefone", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Telefone"].Value = mtxTelefone.Text;

            comm.Parameters.Add("@Email", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Email"].Value = txEmail.Text;


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
                    MessageBox.Show("Cliente alterado com sucesso!",
                        "Sucesso !",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparForm();
                }
            }
        }

        private void btConsultarCliente_Click(object sender, EventArgs e)
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
                "SELECT Id_Cliente, Nome, Data_Nasc, Cidade, CEP, Endereco, CPF, Telefone, Email FROM Clientes " +
                "WHERE Id_Cliente = @Id_Cliente", conn);

            // Cria e configura o parâmetro de pesquisa
            comm.Parameters.Add("@Id_Cliente", System.Data.SqlDbType.Int);
            comm.Parameters["@Id_Cliente"].Value = Convert.ToInt32(mtxIdCliente.Text);

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
                        txNome.Text = reader["Nome"].ToString();
                        dtDataNasc.Value = Convert.ToDateTime(reader["Data_Nasc"]);
                        cbCidade.Text = reader["Cidade"].ToString();
                        mtxCEP.Text = reader["CEP"].ToString();
                        txEndereco.Text = reader["Endereco"].ToString();
                        mtxCPF.Text = reader["CPF"].ToString();
                        mtxTelefone.Text = reader["Telefone"].ToString();
                        txEmail.Text = reader["Email"].ToString();
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

        // Abre a table no form
        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lojaDaCrisDataSet.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.lojaDaCrisDataSet.Clientes);
            // TODO: This line of code loads data into the 'lojaDaCrisDataSet.Login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.lojaDaCrisDataSet.Login);

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
                "SELECT Id_Cliente, Nome, Data_Nasc, Cidade, CEP, Endereco, CPF, Telefone, Email FROM Clientes " +
                "WHERE Id_Cliente = @Id_Cliente", conn);

            // Cria e configura o parâmetro de pesquisa
            comm.Parameters.Add("@Id_Cliente", System.Data.SqlDbType.Int);
            comm.Parameters["@Id_Cliente"].Value = iCodigo;

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
                        mtxIdCliente.Text = reader["Id_Cliente"].ToString();
                        txNome.Text = reader["Nome"].ToString();
                        dtDataNasc.Value = Convert.ToDateTime(reader["Data_Nasc"]);
                        cbCidade.Text = reader["Cidade"].ToString();
                        mtxCEP.Text = reader["CEP"].ToString();
                        txEndereco.Text = reader["Endereco"].ToString();
                        mtxCPF.Text = reader["CPF"].ToString();
                        mtxTelefone.Text = reader["Telefone"].ToString();
                        txEmail.Text = reader["Email"].ToString();
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

        // Abre o form do relatorio
        private void btRelCliente_Click(object sender, EventArgs e)
        {
            RelatorioClientes frm = new RelatorioClientes();

            frm.Show();
        }
    }
}
