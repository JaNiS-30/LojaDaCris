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
    public partial class TrocarSenhaLogin : Form
    {
        public TrocarSenhaLogin()
        {
            InitializeComponent();
            txUsuario.Text = Form1.nomeUsuario;
        }

        private void btTrocaSenha_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;

            string connectionString = Properties.Settings.Default.LojaDaCrisConnectionString;

            // Declara variáveis para login
            string usuario, senha;
            bool bOK = true;
            bool senhaAntigaCerta = false;
            int v = 0;

            conn = new SqlConnection(connectionString);

            // Lê os valores dos text box
            usuario = txUsuario.Text;
            senha = txSenhaAntiga.Text;

            // Cria novo comando SQL para buscar o nome na table de login, comparando com a senha fornecida pelo usuario
            comm = new SqlCommand("SELECT COUNT(ID_Vendedor) FROM Vendedor WHERE Usuario = @Usuario AND Senha = @Senha", conn);

            comm.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = usuario;

            comm.Parameters.Add("@Senha", SqlDbType.VarChar).Value = senha;


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

                // Executa o comando SQL para ler os dados na base de dados
                try
                {
                    comm.ExecuteNonQuery();

                    // Contador para comparar se o login possui a senha fornecida
                    v = (int)comm.ExecuteScalar();
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

                // Condicionais para verificar o correto funcionamento do login
                if (bOK == true)
                {
                    if (v > 0)
                    {
                        senhaAntigaCerta = true;
                    }
                    else
                    {
                        // Mensagem de erro se o login nao for concretizado
                        MessageBox.Show("Senha antiga inválida!");
                        txSenhaAntiga.Clear();
                        txSenha1.Clear();
                        txSenha2.Clear();
                    }

                }
            }



            //////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////

            if (senhaAntigaCerta && (txSenhaAntiga.Text != txSenha1.Text))
            {
                if(txSenha1.Text == txSenha2.Text)
                {
                    try
                    {
                        SqlCommand comm2;

                        // Comando SQL para substituir a senha no banco de dados 
                        comm2 = new SqlCommand("UPDATE Vendedor SET Senha = @Senha, DataTrocaSenha = @DataTrocaSenha WHERE Usuario = @Usuario", conn);

                        comm2.Parameters.Add("@Usuario", System.Data.SqlDbType.NVarChar);
                        comm2.Parameters["@Usuario"].Value = txUsuario.Text;

                        comm2.Parameters.Add("@Senha", System.Data.SqlDbType.NVarChar);
                        comm2.Parameters["@Senha"].Value = txSenha1.Text;

                        comm2.Parameters.Add("@DataTrocaSenha", System.Data.SqlDbType.Date);
                        comm2.Parameters["@DataTrocaSenha"].Value = DateTime.Now.ToString("d");

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

                            comm2.ExecuteNonQuery();

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

                        if (bOK == true)
                        {
                            MessageBox.Show("Senha alterada com sucesso!");

                        }

                    }
                }
                else
                {
                    MessageBox.Show("Erro na confirmação da senha!",
                        "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("A sua nova senha não pode ser igual a senha anterior!",
                        "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                txSenha1.Clear();
                txSenha2.Clear();
            }


        }
    }
}
