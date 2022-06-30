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
    public partial class Configuracao : Form
    {
        public Configuracao()
        {
            InitializeComponent();
        }

        // Volta para o menu principal
        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();

            MenuPrincipal frm = new MenuPrincipal();

            frm.FormClosed += (s, args) => this.Close();

            frm.Show();
        }

        // Atualiza o tempo no rodapé
        private void timer1_Tick(object sender, EventArgs e)
        {
            tsData.Text = DateTime.Now.ToString("D");
            tsHora.Text = DateTime.Now.ToString("T");
        }

        // Função para limpar os campos
        private void LimparForm()
        {
            txNomeLogin.Clear();
            txSenha.Clear();
            txSenhaConfirmar.Clear();

            txNomeLogin.Focus();
        }

        private void btAdicionarLogin_Click(object sender, EventArgs e)
        {
            bool bOK = true;
            string usuario, senha1, senha2;

            SqlConnection conn;
            SqlCommand comm;

            string connectionString = Properties.Settings.Default.LojaDaCrisConnectionString;

            // Cria variáveis de login
            usuario = txNomeLogin.Text;
            senha1 = txSenha.Text;
            senha2 = txSenhaConfirmar.Text;

            conn = new SqlConnection(connectionString);

            // Comando SQL para inserir o novo usuario e senha
            comm = new SqlCommand(
                "INSERT INTO Login (Usuario, Senha) VALUES (@Usuario, @Senha)", conn);

            // Adiciona os parametros para inclusão
            comm.Parameters.Add("@Usuario", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Usuario"].Value = txNomeLogin.Text; 

            comm.Parameters.Add("@Senha", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Senha"].Value = txSenha.Text;


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

                // Condicional se a senha for diferente, mostra o erro
                if (senha1 != senha2)
                {
                    MessageBox.Show("Erro na confirmação da senha!");
                    LimparForm();

                    bOK = false;
                }

                else
                {

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
            }
            catch { }
            finally
            {
                // Fechar a conexão com o banco de dados
                conn.Close();

                // Mensagem de conclusão
                if (bOK == true)
                {
                    MessageBox.Show("Administrador cadastrado com sucesso!",
                        "Sucesso !",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparForm();
                }
            }
        }

        private void btAdicionarCategoria_Click(object sender, EventArgs e)
        {
            bool bOK = true;

            SqlConnection conn;
            SqlCommand comm;

            string connectionString = Properties.Settings.Default.LojaDaCrisConnectionString;

            conn = new SqlConnection(connectionString);

            // Comando SQL para adicionar uma categoria de produto
            comm = new SqlCommand(
                "INSERT INTO Categoria (Categoria) VALUES (@Categoria)", conn);

            // Pega o valor da text box para inclusão no banco de dados
            comm.Parameters.Add("@Categoria", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Categoria"].Value = txNomeCategoria.Text;

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
              
                {

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
            }
            catch { }
            finally
            {
                // Fechar a conexão com o banco de dados
                conn.Close();

                if (bOK == true)
                {
                    MessageBox.Show("Categoria adicionada com sucesso!",
                        "Sucesso !",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txNomeCategoria.Clear();
                }
            }
        }
    }
}
