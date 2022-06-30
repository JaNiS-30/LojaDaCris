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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }
        
        private void btEntrar_Click(object sender, EventArgs e)
        {   
            // Declara variáveis para login
            string usuario, senha;
            bool bOK = true;
            int v = 0;

            SqlConnection conn;
            SqlCommand comm;
          
            string connectionString = Properties.Settings.Default.LojaDaCrisConnectionString;

            conn = new SqlConnection(connectionString);

            // Lê os valores dos text box
            usuario = txUsuario.Text;
            senha = txSenha.Text;

            // Cria novo comando SQL para buscar o nome na table de login, comparando com a senha fornecida pelo usuario
            comm = new SqlCommand("SELECT COUNT(Id_Usuario) FROM Login WHERE usuario = @Usuario AND senha = @Senha", conn);

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

        // Frescuras
        private void lbEsqueci_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            
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
        // Abre o form para trocar senha
        private void lbEsqueci_Click(object sender, EventArgs e)
        {

            TrocarSenha frm = new TrocarSenha();

            frm.Show();

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
    }
}
