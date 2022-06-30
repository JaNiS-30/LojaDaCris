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


        // Funcao para limpar os campos
        private void LimparForm()
        {
            txCodigoBarras.Clear();
            txNome.Clear();
            mtxQuantidade.Clear();
            mtxPreco.Clear();
            pbImagemProdutos.Image = null;

            txCodigoBarras.Focus();
        }

        private void AtualizaProdutos()
        {
            this.produtoTableAdapter.Fill(this.lojaDaCrisDataSetNovo.Produto);
        }

        // Abre a table no form
        private void Produtos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lojaDaCrisDataSetNovo.Categoria' table. You can move, or remove it, as needed.
            this.categoriaTableAdapter1.Fill(this.lojaDaCrisDataSetNovo.Categoria);

            this.produtoTableAdapter.Fill(this.lojaDaCrisDataSetNovo.Produto);
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
                "INSERT INTO Produto (CodigoDeBarras, NomeProduto, Imagem, Quantidade, PrecoUnit, ID_Categoria) " +
                "VALUES (@CodigoDeBarras, @NomeProduto, @Imagem, @Quantidade, @PrecoUnit, @ID_Categoria)", conn);

            // Cria e configura os parâmetros de adição
            comm.Parameters.Add("@CodigoDeBarras", System.Data.SqlDbType.Int);
            comm.Parameters["@CodigoDeBarras"].Value = Convert.ToInt32(txCodigoBarras.Text);

            comm.Parameters.Add("@NomeProduto", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@NomeProduto"].Value = txNome.Text;

            comm.Parameters.Add("@Imagem", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Imagem"].Value = Convert.ToString(pbImagemProdutos.ImageLocation);

            comm.Parameters.Add("@Quantidade", System.Data.SqlDbType.Int);
            comm.Parameters["@Quantidade"].Value = Convert.ToInt32(mtxQuantidade.Text);           

            comm.Parameters.Add("@PrecoUnit", System.Data.SqlDbType.Money);
            comm.Parameters["@PrecoUnit"].Value = Convert.ToSingle(mtxPreco.Text);

            comm.Parameters.Add("@ID_Categoria", System.Data.SqlDbType.Int);
            comm.Parameters["@ID_Categoria"].Value = Convert.ToInt32(cbCategoria.SelectedValue);

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
                    AtualizaProdutos();
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
                "UPDATE Produto SET CodigoDeBarras = @CodigoDeBarras, NomeProduto = @NomeProduto, Imagem = @Imagem, " +
                "Quantidade = @Quantidade, PrecoUnit = @PrecoUnit, ID_Categoria = @ID_Categoria " +
                "WHERE CodigoDeBarras=@CodigoDeBarras", conn);

            // Cria e configura os parâmetros de edição
            comm.Parameters.Add("@CodigoDeBarras", System.Data.SqlDbType.Int);
            comm.Parameters["@CodigoDeBarras"].Value = txCodigoBarras.Text;

            comm.Parameters.Add("@NomeProduto", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@NomeProduto"].Value = txNome.Text;

            comm.Parameters.Add("@Imagem", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Imagem"].Value = Convert.ToString(pbImagemProdutos.ImageLocation);

            comm.Parameters.Add("@Quantidade", System.Data.SqlDbType.Int);
            comm.Parameters["@Quantidade"].Value = Convert.ToInt32(mtxQuantidade.Text);
          
            comm.Parameters.Add("@PrecoUnit", System.Data.SqlDbType.Money);
            comm.Parameters["@PrecoUnit"].Value = Convert.ToSingle(mtxPreco.Text);

            comm.Parameters.Add("@ID_Categoria", System.Data.SqlDbType.Int);
            comm.Parameters["@ID_Categoria"].Value = Convert.ToInt32(cbCategoria.SelectedValue);


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
                    AtualizaProdutos();
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
            comm = new SqlCommand("DELETE FROM Produto WHERE CodigoDeBarras = @CodigoDeBarras", conn);

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
                    AtualizaProdutos();
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
                "SELECT P.CodigoDeBarras, P.NomeProduto, P.Imagem, P.Quantidade, P.PrecoUnit, C.Categoria " +
                "FROM Produto AS P " +
                "INNER JOIN Categoria AS C " +
                "ON C.ID_Categoria = P.ID_Categoria " +
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
                        if (Convert.ToSingle(reader["PrecoUnit"]).ToString("N2").Length == 6)
                        {
                            mtxPreco.Text = " " + Convert.ToSingle(reader["PrecoUnit"]).ToString("N2");
                        }
                        else if (Convert.ToSingle(reader["PrecoUnit"]).ToString("N2").Length == 5)
                        {
                            mtxPreco.Text = "  " + Convert.ToSingle(reader["PrecoUnit"]).ToString("N2");
                        }
                        else if (Convert.ToSingle(reader["PrecoUnit"]).ToString("N2").Length == 4)
                        {
                            mtxPreco.Text = "   " + Convert.ToSingle(reader["PrecoUnit"]).ToString("N2");
                        }
                        else
                        {
                            mtxPreco.Text = Convert.ToSingle(reader["PrecoUnit"]).ToString("N2");
                        }

                        pbImagemProdutos.ImageLocation = reader["Imagem"].ToString();

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
               "SELECT P.CodigoDeBarras, P.NomeProduto, P.Imagem, P.Quantidade, P.PrecoUnit, C.Categoria " +
               "FROM Produto AS P " +
               "INNER JOIN Categoria AS C " +
               "ON C.ID_Categoria = P.ID_Categoria " +
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
                        txCodigoBarras.Text = iCodigo.ToString();
                        txNome.Text = reader["NomeProduto"].ToString();
                        mtxQuantidade.Text = reader["Quantidade"].ToString();
                        cbCategoria.Text = reader["Categoria"].ToString();
                        if (Convert.ToSingle(reader["PrecoUnit"]).ToString("N2").Length == 6)
                        {
                            mtxPreco.Text = " " + Convert.ToSingle(reader["PrecoUnit"]).ToString("N2");
                        }
                        else if (Convert.ToSingle(reader["PrecoUnit"]).ToString("N2").Length == 5)
                        {
                            mtxPreco.Text = "  " + Convert.ToSingle(reader["PrecoUnit"]).ToString("N2");
                        }
                        else if (Convert.ToSingle(reader["PrecoUnit"]).ToString("N2").Length == 4)
                        {
                            mtxPreco.Text = "   " + Convert.ToSingle(reader["PrecoUnit"]).ToString("N2");
                        }
                        else
                        {
                            mtxPreco.Text = Convert.ToSingle(reader["PrecoUnit"]).ToString("N2");
                        }

                        pbImagemProdutos.ImageLocation = reader["Imagem"].ToString();
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


        private void pbImagemProdutos_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image Files(*.jpeg; *.jpg; *.gif; *.bmp; *.png)|*.jpeg; *.jpg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pbImagemProdutos.Image = new Bitmap(open.FileName);
                pbImagemProdutos.ImageLocation = open.FileName;
            }
        }

        private void mtxPreco_MouseUp(object sender, MouseEventArgs e)
        {
            SendKeys.Send("{HOME}");
        }
    }
}
