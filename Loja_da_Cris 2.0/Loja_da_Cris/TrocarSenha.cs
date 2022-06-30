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
    public partial class TrocarSenha : Form
    {
        public TrocarSenha()
        {
            InitializeComponent();
          
        }

        // Funcao para limpar os campos
        private void LimparForm()
        {
            txSenha1.Clear();
            txSenha2.Clear();
        }

        private void btTrocaSenha_Click(object sender, EventArgs e)
        {
            // Cria variáveis para comparação de dados
            bool bOK = true;
            int v = 0;

            SqlConnection conn;
            SqlCommand comm;

            string connectionString = Properties.Settings.Default.LojaDaCrisConnectionString;

            conn = new SqlConnection(connectionString);

            // Cria e declara strings com o nome de usuario e senhas fornecidos
            string senha1, senha2;

            senha1 = txSenha1.Text;
            senha2 = txSenha2.Text;

            // Comando SQL para localizar o nome de usuario na table Login
            comm = new SqlCommand("SELECT COUNT(ID_Vendedor) FROM Vendedor WHERE Usuario = @Usuario", conn);

            comm.Parameters.Add("@Usuario", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Usuario"].Value = cbUsuario.SelectedValue.ToString();

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

                try
                {
                    // Faz a pesquisa de usuario no banco de dados
                    comm.ExecuteNonQuery();
                    v = (int)comm.ExecuteScalar();
                
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao tentar executar o comando SQL.",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    bOK = false;
                }

                // Condicional se as senhas forem divergentes
                if (senha1 != senha2)
                {
                    MessageBox.Show("Erro na confirmação da senha!");
                    LimparForm();

                    bOK = false;
                }

                // Se nao encontrar o nome de usuario fornecido, mostra uma mensagem de erro
                else if (v == 0)
                {
                    MessageBox.Show("Erro, usuário inválido!");
                    LimparForm();

                    bOK = false;
                }

                else {

                    // Comando SQL para substituir a senha no banco de dados 
                    comm = new SqlCommand("UPDATE Vendedor SET Senha = @Senha, DataTrocaSenha = @DataTrocaSenha WHERE Usuario = @Usuario", conn);

                    comm.Parameters.Add("@Usuario", System.Data.SqlDbType.NVarChar);
                    comm.Parameters["@Usuario"].Value = cbUsuario.SelectedValue.ToString();

                    comm.Parameters.Add("@Senha", System.Data.SqlDbType.NVarChar);
                    comm.Parameters["@Senha"].Value = txSenha1.Text;

                    comm.Parameters.Add("@DataTrocaSenha", System.Data.SqlDbType.Date);
                    comm.Parameters["@DataTrocaSenha"].Value = DateTime.Now.ToString("d");

                    // Executa o comando SQL para inserir dados na base de dados
                    try
                    {

                        comm.ExecuteNonQuery();
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
                
            }
            catch { }
            finally
            {
                // Fechar a conexão com o banco de dados
                conn.Close();

                if (bOK == true)
                {
                    MessageBox.Show("Senha alterada com sucesso!");

                }
                
            }
        }

        // Frescura
        private void btTrocaSenha_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void TrocarSenha_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void btVoltar_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        // Fecha o form
        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void TrocarSenha_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lojaDaCrisDataSetNovo.Vendedor' table. You can move, or remove it, as needed.
            this.vendedorTableAdapter.Fill(this.lojaDaCrisDataSetNovo.Vendedor);
            // TODO: This line of code loads data into the 'lojaDaCrisDataSetNovo.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.lojaDaCrisDataSetNovo.Cliente);

            if (Form1.esqSenha)
            {
                cbUsuario.Text = Form1.sUserName;
                cbUsuario.Enabled = false;
            }
        }
    }
}
