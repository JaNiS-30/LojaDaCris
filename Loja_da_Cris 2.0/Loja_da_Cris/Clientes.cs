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

        private void AtualizaListaCliente()
        {
            this.clienteTableAdapter.Fill(this.lojaDaCrisDataSetNovo.Cliente);
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
            mtxNumero.Clear();
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
                "INSERT INTO Cliente (Nome, CPF, Telefone, Email, DataNasc, Cidade, Endereco, Numero, CEP) " +
                "VALUES (@Nome, @CPF, @Telefone, @Email, @DataNasc, @Cidade, @Endereco, @Numero, @CEP)", conn);

            // Cria e configura os parâmetros de adição

            comm.Parameters.Add("@Nome", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Nome"].Value = txNome.Text;

            comm.Parameters.Add("@CPF", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CPF"].Value = mtxCPF.Text;

            comm.Parameters.Add("@Telefone", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Telefone"].Value = mtxTelefone.Text;

            comm.Parameters.Add("@Email", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Email"].Value = txEmail.Text;

            comm.Parameters.Add("@DataNasc", System.Data.SqlDbType.Date);
            comm.Parameters["@DataNasc"].Value = dtDataNasc.Value;

            comm.Parameters.Add("@Cidade", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Cidade"].Value = cbCidade.Text;

            comm.Parameters.Add("@Endereco", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Endereco"].Value = txEndereco.Text;

            comm.Parameters.Add("@Numero", System.Data.SqlDbType.Int);
            comm.Parameters["@Numero"].Value = Convert.ToInt32(mtxNumero.Text);

            comm.Parameters.Add("@CEP", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CEP"].Value = mtxCEP.Text;

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
                    AtualizaListaCliente();
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

            comm = new SqlCommand("DELETE FROM Cliente WHERE ID_Cliente = @ID_Cliente", conn);

            // Cria e configura os parâmetros de exclusão
            comm.Parameters.Add("@ID_Cliente", System.Data.SqlDbType.Int);
            comm.Parameters["@ID_Cliente"].Value = Convert.ToInt32(mtxIdCliente.Text);


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
                    AtualizaListaCliente();
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
                "UPDATE Cliente SET Nome = @Nome, CPF = @CPF, Telefone = @Telefone, Email = @Email, " +
                "DataNasc = @DataNasc, Cidade = @Cidade, Endereco = @Endereco, Numero = @Numero, CEP = @CEP " +
                "WHERE ID_Cliente=@ID_Cliente", conn);

            // Cria e configura os parâmetros de edição
            comm.Parameters.Add("@ID_Cliente", System.Data.SqlDbType.Int);
            comm.Parameters["@ID_Cliente"].Value = Convert.ToInt32(mtxIdCliente.Text);

            comm.Parameters.Add("@Nome", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Nome"].Value = txNome.Text;

            comm.Parameters.Add("@CPF", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CPF"].Value = mtxCPF.Text;

            comm.Parameters.Add("@Telefone", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Telefone"].Value = mtxTelefone.Text;

            comm.Parameters.Add("@Email", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Email"].Value = txEmail.Text;

            comm.Parameters.Add("@DataNasc", System.Data.SqlDbType.Date);
            comm.Parameters["@DataNasc"].Value = dtDataNasc.Value;

            comm.Parameters.Add("@Cidade", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Cidade"].Value = cbCidade.Text;

            comm.Parameters.Add("@Endereco", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Endereco"].Value = txEndereco.Text;

            comm.Parameters.Add("@Numero", System.Data.SqlDbType.Int);
            comm.Parameters["@Numero"].Value = Convert.ToInt32(mtxNumero.Text);

            comm.Parameters.Add("@CEP", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CEP"].Value = mtxCEP.Text;


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
                    AtualizaListaCliente();
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
                "SELECT ID_Cliente, Nome, CPF, Telefone, Email, DataNasc, Cidade, Endereco, Numero, CEP FROM Cliente " +
                "WHERE ID_Cliente = @ID_Cliente", conn);

            // Cria e configura o parâmetro de pesquisa
            comm.Parameters.Add("@ID_Cliente", System.Data.SqlDbType.Int);
            comm.Parameters["@ID_Cliente"].Value = Convert.ToInt32(mtxIdCliente.Text);

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
                        mtxCPF.Text = reader["CPF"].ToString();
                        mtxTelefone.Text = reader["Telefone"].ToString();
                        txEmail.Text = reader["Email"].ToString();
                        dtDataNasc.Value = Convert.ToDateTime(reader["DataNasc"]);
                        cbCidade.Text = reader["Cidade"].ToString();
                        txEndereco.Text = reader["Endereco"].ToString();
                        mtxNumero.Text = reader["Numero"].ToString();
                        mtxCEP.Text = reader["CEP"].ToString();
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
                "SELECT ID_Cliente, Nome, CPF, Telefone, Email, DataNasc, Cidade, Endereco, Numero, CEP FROM Cliente " +
                "WHERE ID_Cliente = @ID_Cliente", conn);

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
                        mtxCPF.Text = reader["CPF"].ToString();
                        mtxTelefone.Text = reader["Telefone"].ToString();
                        txEmail.Text = reader["Email"].ToString();
                        dtDataNasc.Value = Convert.ToDateTime(reader["DataNasc"]);
                        cbCidade.Text = reader["Cidade"].ToString();
                        txEndereco.Text = reader["Endereco"].ToString();
                        mtxNumero.Text = reader["Numero"].ToString();
                        mtxCEP.Text = reader["CEP"].ToString();
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

        public bool validaCPF(string cpf)
        {

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11 || (cpf == 00000000000.ToString()) || (cpf == 11111111111.ToString()) || (cpf == 22222222222.ToString()) || (cpf == 33333333333.ToString()) || (cpf == 44444444444.ToString()) || (cpf == 55555555555.ToString()) || (cpf == 66666666666.ToString()) || (cpf == 77777777777.ToString()) || (cpf == 88888888888.ToString()) || (cpf == 99999999999.ToString()))
                return false;

            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();

            tempCpf = tempCpf + digito;

            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }


        private void mtxCPF_Validating(object sender, CancelEventArgs e)
        {
            if (!validaCPF(mtxCPF.Text))
            {
                MessageBox.Show("CPF inválido, por favor insira um CPF correto",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                mtxCPF.Clear();
            }

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lojaDaCrisDataSetNovo.Vendedor' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.lojaDaCrisDataSetNovo.Cliente);
        }

        private void mtxCEP_MouseUp(object sender, MouseEventArgs e)
        {
            SendKeys.Send("{HOME}");
        }

        private void mtxTelefone_MouseUp(object sender, MouseEventArgs e)
        {
            SendKeys.Send("{HOME}");
        }

        private void mtxCPF_MouseUp(object sender, MouseEventArgs e)
        {
            SendKeys.Send("{HOME}");
        }
    }
}
