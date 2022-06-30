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
using System.Globalization;
using System.Configuration;
using System.Net.Mail;

namespace Loja_da_Cris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }

        public static bool isAdm = false;

        public static string nomeUsuario;

        public static string nomePessoa;

        public static int idVendedor;

        public static float comissaoVendedor;

        public static bool esqSenha = false;


        private void btEntrar_Click(object sender, EventArgs e)
        {

            SqlConnection conn;
            SqlCommand comm2;
            SqlDataReader reader;
           

            string connectionString = Properties.Settings.Default.LojaDaCrisConnectionString;

            bool tempoTrocaSenha = false;

            conn = new SqlConnection(connectionString);

            // Cria novo comando SQL para buscar o nome na table de login, comparando com a senha fornecida pelo usuario
            comm2 = new SqlCommand("SELECT C.Nome, V.Comissao, V.ID_Vendedor, V.IS_ADM, V.DataTrocaSenha " +
                "FROM Vendedor AS V " +
                "INNER JOIN Cliente AS C " +
                "ON C.ID_Cliente = V.ID_Cliente " +
                "WHERE Usuario = @Usuario", conn);

            comm2.Parameters.Add("@Usuario", System.Data.SqlDbType.NVarChar);
            comm2.Parameters["@Usuario"].Value = txUsuario.Text;

            nomeUsuario = txUsuario.Text;

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

                // Executa o comando SQL para ler os dados na base de dados
                try
                {
                    // Executa o comando SQL
                    reader = comm2.ExecuteReader();

                    // Se encontrou um registro, repassa os dados para o form
                    if (reader.Read())
                    {
                        isAdm = Convert.ToBoolean(reader["IS_ADM"]);

                        nomePessoa = reader["Nome"].ToString();

                        idVendedor = Convert.ToInt32(reader["ID_Vendedor"]);

                        comissaoVendedor = Convert.ToSingle(reader["Comissao"]);

                        CultureInfo provider = CultureInfo.InvariantCulture;
                        provider = new CultureInfo("pt-BR");

                        DateTime DataTrocaSenha = DateTime.ParseExact(reader["DataTrocaSenha"].ToString().Substring(0,10), "d", provider);

                        TimeSpan span = DateTime.Now.Subtract(DataTrocaSenha);



                        if(span.Days >= 7)
                        {
                            tempoTrocaSenha = true;

                            MessageBox.Show("Por motivos de segurança, pedimos para você atualizar a sua senha!",
                                "Trocar Senha",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    reader.Close(); // Encerra o leitor de dados 

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



            ///////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////




            if (!tempoTrocaSenha)
            {
                // Declara variáveis para login
                string usuario, senha;
                bool bOK = true;
                int v = 0;

                SqlCommand comm;

                conn = new SqlConnection(connectionString);

                // Lê os valores dos text box
                usuario = txUsuario.Text;
                senha = txSenha.Text;

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
                            // Abre o form do menu principal
                            this.Hide();

                            MenuPrincipal frm = new MenuPrincipal();

                            frm.FormClosed += (s, args) => this.Close();

                            frm.Show();
                        }
                        else
                        {
                            // Mensagem de erro se o login nao for concretizado
                            MessageBox.Show("Usuário ou senha incorreto!");
                            txUsuario.Text = "";
                            txSenha.Text = "";
                            txUsuario.Focus();
                        }

                    }
                }
            }
            else
            {
                TrocarSenhaLogin frm = new TrocarSenhaLogin();

                frm.Show();
            }

        }

        private void groupBox2_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void btEntrar_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void btSair_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        // Sai da aplicação
        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EnviarEmail(string _emailDestinatario, string _assunto, string _mensagem)
        {
            
            SmtpClient client = new System.Net.Mail.SmtpClient();
            client.UseDefaultCredentials = false;

            client.Host = "smtp.office365.com";
            client.Port = 587;

            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential("lojada_cris_ta@hotmail.com", "123456789toalha");


            MailAddress de = new MailAddress("lojada_cris_ta@hotmail.com");
            MailAddress para = new MailAddress(_emailDestinatario);
            MailMessage mensagem = new MailMessage(de, para);

            mensagem.IsBodyHtml = true;

            mensagem.Subject = _assunto;

            mensagem.Body = _mensagem;

            try
            {
                client.Send(mensagem);

                MessageBox.Show("Seu código de acesso foi enviado para seu email: " + _emailDestinatario,
                    "Código enviado com sucesso!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);         
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Erro ao enviar Email",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                isErr = true;
            }
        }

        public static Random randNum = new Random();

        public static int numAcesso = randNum.Next(10000, 99999);

        public static String sUserName = "";

        bool isErr = false;

        private void llEsqSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {           
            esqSenha = true;

            if (txUsuario.Text.Equals(""))
            {
                MessageBox.Show("Digite o nome do usuário para recuperar a senha",
                    "Nome do Usuário Requerido!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                txUsuario.Text = "";
                txSenha.Text = "";
                txUsuario.Focus();
            }
            else
            {
                SqlConnection conn;
                SqlCommand comm;
                SqlDataReader reader;


                
                String sEmail = "";
                String sNome = "";

                string connectionString = Properties.Settings.Default.LojaDaCrisConnectionString;

                conn = new SqlConnection(connectionString);

                comm = new SqlCommand(
                    "SELECT V.Usuario, C.Email, C.Nome " +
                    "FROM Vendedor AS V " +
                    "INNER JOIN Cliente AS C " +
                    "ON C.ID_Cliente=V.ID_Cliente " +
                    "WHERE V.Usuario=@Usuario", conn);

                comm.Parameters.Add("@Usuario", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@Usuario"].Value = txUsuario.Text;

                try
                {
                    try
                    {
                        conn.Open();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message,
                            "Erro ao abrir conexão com o Banco de Dados",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            isErr = true;
                    }

                    try
                    {
                        reader = comm.ExecuteReader();

                        if (reader.Read())
                        {
                            sUserName = reader["Usuario"].ToString();
                            sNome = reader["Nome"].ToString();
                            sEmail = reader["Email"].ToString();
                        }
                        reader.Close();

                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message,
                            "Erro ao executar o comando SQL",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            isErr = true;
                    }
                }
                catch { }
                finally
                {
                    conn.Close();
                }

                
                String sMensagem = "Olá " + sNome + "! <BR>" +
                    "Seu código de acesso no sistema é: " + "<B>" + numAcesso + "</B>";

                try
                {
                    EnviarEmail(sEmail, "Código de acesso", sMensagem);
                }
                catch {
                    isErr = true;
                }

                if (!isErr)
                {
                  ValidarEmail frm = new ValidarEmail();

                  frm.Show();
                }
            }
        }
    }
}
