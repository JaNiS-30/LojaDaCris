using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Loja_da_Cris
{
    public partial class Vendas : Form
    {
        int iQtdProdutosLista;
        float fPrecoTotal;
        int iItemSelecionado;
        bool primeiro = true;

        public Vendas()
        {
            InitializeComponent();
            txVendedor.Text = Form1.nomePessoa;

            if (!Form1.isAdm) btConsulta.Visible = false;

            iQtdProdutosLista = 0;
            fPrecoTotal = 0.0f;
            iItemSelecionado = 0;
        }

        

        private void Vendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lojaDaCrisDataSetNovo.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.lojaDaCrisDataSetNovo.Cliente);
            // TODO: This line of code loads data into the 'lojaDaCrisDataSetNovo.Produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.lojaDaCrisDataSetNovo.Produto);

        }

        private void btAdicionarVendas_Click(object sender, EventArgs e)
        {
            bool repetido = false;
            int quantEstoque = 0;

            if (mtxQuantidade.Text != "")
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
                    "SELECT Quantidade " +
                    "FROM Produto " +
                    "WHERE CodigoDeBarras = @CodigoDeBarras", conn);

                // Cria e configura o parâmetro de pesquisa
                comm.Parameters.Add("@CodigoDeBarras", System.Data.SqlDbType.Int);
                comm.Parameters["@CodigoDeBarras"].Value = cbProduto.SelectedValue;


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
                            quantEstoque = Convert.ToInt32(reader["Quantidade"]);

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


                for (int i = 0; i < iQtdProdutosLista; i++)
                {
                    if (!primeiro && dgvCarrinho.Rows[i].Cells[0].Value.ToString() == cbProduto.SelectedValue.ToString() )
                    {
                        if (Convert.ToInt32(dgvCarrinho.Rows[i].Cells[3].Value) + Convert.ToInt32(mtxQuantidade.Text) <= quantEstoque)
                        {
                            dgvCarrinho.Rows[i].Cells[3].Value = Convert.ToInt32(dgvCarrinho.Rows[i].Cells[3].Value) + Convert.ToInt32(mtxQuantidade.Text);

                            fPrecoTotal -= Convert.ToSingle(dgvCarrinho.Rows[i].Cells[4].Value);

                            float fPrecoParcial = +Convert.ToSingle(txPrecoUnit.Text) * Convert.ToSingle(dgvCarrinho.Rows[i].Cells[3].Value);
                            dgvCarrinho.Rows[i].Cells[4].Value = Convert.ToString(fPrecoParcial);


                            fPrecoTotal += fPrecoParcial;
                            lbPrecoTotal.Text = Convert.ToString(fPrecoTotal);

                            mtxQuantidade.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Você não possui essa quantidade em estoque, esse produto tem " + quantEstoque + " unidades.");
                        }
                            repetido = true;
                    }
                }

                if (!repetido)
                {
                    if (Convert.ToInt32(mtxQuantidade.Text) <= quantEstoque)
                    {
                        // Adcionar uma nova linha ao carrinho
                        dgvCarrinho.Rows.Add();

                        // Adiciona um produto no carrinho
                        dgvCarrinho.Rows[iQtdProdutosLista].Cells[0].Value = cbProduto.SelectedValue.ToString();
                        dgvCarrinho.Rows[iQtdProdutosLista].Cells[1].Value = cbProduto.Text;
                        dgvCarrinho.Rows[iQtdProdutosLista].Cells[2].Value = txPrecoUnit.Text;
                        dgvCarrinho.Rows[iQtdProdutosLista].Cells[3].Value = mtxQuantidade.Text;

                        float fPrecoParcial = Convert.ToSingle(txPrecoUnit.Text) * Convert.ToSingle(mtxQuantidade.Text);
                        dgvCarrinho.Rows[iQtdProdutosLista].Cells[4].Value = Convert.ToString(fPrecoParcial);

                        // Recalcula o Preço Total
                        fPrecoTotal += fPrecoParcial;
                        lbPrecoTotal.Text = Convert.ToString(fPrecoTotal);

                        // Incrementa quantidade de itens no carrinho
                        iQtdProdutosLista++;
                        lbQtdProdutosLista.Text = iQtdProdutosLista.ToString();

                        mtxQuantidade.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Você não possui essa quantidade em estoque, esse produto tem " + quantEstoque + " unidades.");
                    }
                    primeiro = false;
                
                }
                
            }
            else
            {
                MessageBox.Show("Informe a quantidade desse produto!");
            }
        }

        private void btRemoverVendas_Click(object sender, EventArgs e)
        {
            String sID_Produto = dgvCarrinho.Rows[iItemSelecionado].Cells[0].Value.ToString();
            String sDescricao = dgvCarrinho.Rows[iItemSelecionado].Cells[1].Value.ToString();
            String sPrecoUnit = dgvCarrinho.Rows[iItemSelecionado].Cells[2].Value.ToString();
            String sQtd = dgvCarrinho.Rows[iItemSelecionado].Cells[3].Value.ToString();
            String sPrecoParcial = dgvCarrinho.Rows[iItemSelecionado].Cells[4].Value.ToString();

            // Subtrai o valor do item do carrinho com o Preço Total da venda
            float fPrecoParcial = Convert.ToSingle(sPrecoUnit) * Convert.ToSingle(sQtd);
            fPrecoTotal -= fPrecoParcial;
            lbPrecoTotal.Text = fPrecoTotal.ToString();

            // Remove o item do carrinho
            dgvCarrinho.Rows.RemoveAt(iItemSelecionado);

            // Subtrai o valor dos itens do carrinho
            iQtdProdutosLista--;
            lbQtdProdutosLista.Text = iQtdProdutosLista.ToString();

            if(iQtdProdutosLista == 0)
            {
                lbPrecoTotal.Text = "0";
            }
        }

        private void limparForm()
        {
            dgvCarrinho.Rows.Clear();
            iQtdProdutosLista = 0;
            lbQtdProdutosLista.Text = "0";
            fPrecoTotal = 0;
            lbPrecoTotal.Text = "0";
        }

        private void dgvCarrinho_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            iItemSelecionado = e.RowIndex;
        }

        private void btIncluirVendas_Click(object sender, EventArgs e)
        {
            bool carrinhoVazio = false;
            try
            {
                String.IsNullOrEmpty((string)dgvCarrinho.Rows[0].Cells[0].Value);
            }
            catch
            {
                carrinhoVazio = true;
                MessageBox.Show("O carrinho está vazio!");
            }
            if (!carrinhoVazio)
            {
                SqlConnection conn;
                SqlCommand comm;
                bool bIsOperationOK = true;

                string connectionString = Properties.Settings.Default.LojaDaCrisConnectionString;

                conn = new SqlConnection(connectionString);

                comm = new SqlCommand(
                    "INSERT INTO Venda (ID_Cliente, ID_Vendedor, ComissaoVenda, DataVenda, PrecoTotal) " +
                    "VALUES (@ID_Cliente, @ID_Vendedor, @ComissaoVenda, @DataVenda, @PrecoTotal)", conn);

                comm.Parameters.Add("@ID_Cliente", System.Data.SqlDbType.Int);
                comm.Parameters["@ID_Cliente"].Value = Convert.ToInt32(cbClienteVenda.SelectedValue);

                comm.Parameters.Add("@ID_Vendedor", System.Data.SqlDbType.Int);
                comm.Parameters["@ID_Vendedor"].Value = Form1.idVendedor;

                comm.Parameters.Add("@ComissaoVenda", System.Data.SqlDbType.Money);
                comm.Parameters["@ComissaoVenda"].Value = (Convert.ToSingle(lbPrecoTotal.Text) / 100) * Form1.comissaoVendedor;

                comm.Parameters.Add("@DataVenda", System.Data.SqlDbType.Date);
                comm.Parameters["@DataVenda"].Value = dtpDataVenda.Value;

                comm.Parameters.Add("@PrecoTotal", System.Data.SqlDbType.Money);
                comm.Parameters["@PrecoTotal"].Value = Convert.ToSingle(lbPrecoTotal.Text);

                try
                {
                    try
                    {
                        conn.Open();
                    }
                    catch (Exception error)
                    {
                        bIsOperationOK = false;

                        MessageBox.Show(error.Message,
                            "Erro ao tentar conexão com a base de dados",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                    try
                    {
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception error)
                    {
                        bIsOperationOK = false;

                        MessageBox.Show(error.Message,
                            "Erro ao tentar execurar o comando SQL.",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                catch { }
                finally
                {
                    conn.Close();
                }
                ///////////////////////////////////////////////////////////////////////////////////////////////////////
                ///////////////////////////////////////////////////////////////////////////////////////////////////////

                SqlCommand comm2;

                comm2 = new SqlCommand(
                    "INSERT INTO ItemVenda (ID_Venda, CodigoDeBarras, Quantidade, Valor) " +
                    "VALUES (@ID_Venda, @CodigoDeBarras, @Quantidade, @Valor)", conn);

                comm2.Parameters.Add("@ID_Venda", System.Data.SqlDbType.Int);
                comm2.Parameters.Add("@CodigoDeBarras", System.Data.SqlDbType.Int);
                comm2.Parameters.Add("@Quantidade", System.Data.SqlDbType.Int);
                comm2.Parameters.Add("@Valor", System.Data.SqlDbType.Money);

                // Percorre todo o carrinho, adicionando item a item na tabela ItemVenda
                for (int i = 0; i < dgvCarrinho.Rows.Count; i++)
                {
                    comm2.Parameters["@ID_Venda"].Value = ObterCodigoVenda(false);
                    comm2.Parameters["@CodigoDeBarras"].Value = Convert.ToInt32(dgvCarrinho.Rows[i].Cells[0].Value);
                    comm2.Parameters["@Quantidade"].Value = Convert.ToInt32(dgvCarrinho.Rows[i].Cells[3].Value);
                    comm2.Parameters["@Valor"].Value = Convert.ToSingle(dgvCarrinho.Rows[i].Cells[4].Value);

                    try
                    {
                        try
                        {
                            conn.Open();
                        }
                        catch (Exception error)
                        {
                            bIsOperationOK = false;

                            MessageBox.Show(error.Message,
                                "Erro ao tentar conexão com a base de dados",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }

                        try
                        {
                            comm2.ExecuteNonQuery();
                        }
                        catch (Exception error)
                        {
                            bIsOperationOK = false;

                            MessageBox.Show(error.Message,
                                "Erro ao tentar execurar o comando SQL.",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                    catch { }
                    finally
                    {
                        conn.Close();
                    }
                } // fim FOR

                SqlCommand comm3;

                comm3 = new SqlCommand(
                    "UPDATE Vendedor " +
                    "SET ComissaoRecebida += @ComissaoRecebida " +
                    "WHERE ID_Vendedor = @ID_Vendedor", conn);

                comm3.Parameters.Add("@ID_Vendedor", System.Data.SqlDbType.Int);
                comm3.Parameters["@ID_Vendedor"].Value = Form1.idVendedor;

                comm3.Parameters.Add("@ComissaoRecebida", System.Data.SqlDbType.Money);
                comm3.Parameters["@ComissaoRecebida"].Value = (Convert.ToSingle(lbPrecoTotal.Text) / 100) * Form1.comissaoVendedor;


                try
                {
                    try
                    {
                        conn.Open();
                    }
                    catch (Exception error)
                    {
                        bIsOperationOK = false;

                        MessageBox.Show(error.Message,
                            "Erro ao tentar conexão com a base de dados",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                    try
                    {
                        comm3.ExecuteNonQuery();
                    }
                    catch (Exception error)
                    {
                        bIsOperationOK = false;

                        MessageBox.Show(error.Message,
                            "Erro ao tentar execurar o comando SQL.",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                catch { }
                finally
                {
                    conn.Close();
                }

                SqlCommand comm4;

                comm4 = new SqlCommand(
                    "UPDATE Produto " +
                    "SET Quantidade -= @Quantidade " +
                    "WHERE CodigoDeBarras = @CodigoDeBarras", conn);

                comm4.Parameters.Add("@CodigoDeBarras", System.Data.SqlDbType.Int);
                comm4.Parameters.Add("@Quantidade", System.Data.SqlDbType.Int);

                for (int i = 0; i < dgvCarrinho.Rows.Count; i++)
                {
                    comm4.Parameters["@CodigoDeBarras"].Value = Convert.ToInt32(dgvCarrinho.Rows[i].Cells[0].Value);
                    comm4.Parameters["@Quantidade"].Value = Convert.ToInt32(dgvCarrinho.Rows[i].Cells[3].Value);
                    try
                    {
                        try
                        {
                            conn.Open();
                        }
                        catch (Exception error)
                        {
                            bIsOperationOK = false;

                            MessageBox.Show(error.Message,
                                "Erro ao tentar conexão com a base de dados",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }

                        try
                        {
                            comm4.ExecuteNonQuery();
                        }
                        catch (Exception error)
                        {
                            bIsOperationOK = false;

                            MessageBox.Show(error.Message,
                                "Erro ao tentar execurar o comando SQL.",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                    catch { }
                    finally
                    {
                        conn.Close();
                    }
                }


                limparForm();

                if (bIsOperationOK)
                {
                    RelatorioNota frm = new RelatorioNota();

                    frm.Show();
                }
            }
        }

        public int ObterCodigoVenda(bool bBuscarProximo)
        {
            string codigo = "";
            string sql = "";
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.LojaDaCrisConnectionString);

            if (bBuscarProximo == true)
                sql = "SELECT MAX(ID_Venda)+1 AS 'ID_Venda' FROM Venda";
            else
                sql = "SELECT MAX(ID_Venda) AS 'ID_Venda' FROM Venda";

            SqlCommand comm = new SqlCommand(sql.ToString(), conn);
            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                codigo = reader["ID_Venda"].ToString();
            }
            conn.Close();
            return Convert.ToInt32(codigo);
        }

        private void btExcluirVendas_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            bool bIsOperationOK = true;

            string connectionString = Properties.Settings.Default.LojaDaCrisConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand(
                "DELETE FROM Venda WHERE ID_Venda = @ID_Venda", conn);

            comm.Parameters.Add("@ID_Venda", System.Data.SqlDbType.Int);
            comm.Parameters["@ID_Venda"].Value = Convert.ToInt32(mtxIDVenda.Text);

            try
            {
                try
                {
                    conn.Open();
                }
                catch (Exception error)
                {
                    bIsOperationOK = false;

                    MessageBox.Show(error.Message,
                        "Erro ao tentar conexão com a base de dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                try
                {
                    comm.ExecuteNonQuery();
                }
                catch (Exception error)
                {
                    bIsOperationOK = false;

                    MessageBox.Show(error.Message,
                        "Erro ao tentar execurar o comando SQL.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch { }
            finally
            {
                conn.Close();

                if (bIsOperationOK)
                {
                    MessageBox.Show("Venda Excluída!",
                        "DELETE",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void btConsulta_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;

            string connectionString = Properties.Settings.Default.LojaDaCrisConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand(
                "SELECT V.ID_Venda, V.ID_Cliente, V.DataVenda, V.PrecoTotal, C.ID_Cliente, C.Nome " +
                "FROM Venda AS V " +
                "INNER JOIN Cliente AS C " +
                "ON C.ID_Cliente=V.ID_Cliente " +
                "WHERE V.ID_Venda=@ID_Venda", conn);

            comm.Parameters.Add("@ID_Venda", System.Data.SqlDbType.Int);
            comm.Parameters["@ID_Venda"].Value = Convert.ToInt32(mtxIDVenda.Text);

            try
            {
                try
                {
                    conn.Open();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao tentar abrir o Banco de Dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                try
                {
                    reader = comm.ExecuteReader();

                    if (reader.Read())
                    {
                        cbClienteVenda.Text = reader["Nome"].ToString();
                        dtpDataVenda.Text = reader["DataVenda"].ToString();
                        lbPrecoTotal.Text = reader["PrecoTotal"].ToString();
                    }

                    reader.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao tentar executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch { }
            finally
            {
                conn.Close();
            }

            ///////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////
            iQtdProdutosLista = 0;
            fPrecoTotal = 0.0f;
            iItemSelecionado = 0;
            dgvCarrinho.Rows.Clear();

            SqlCommand comm2;
            SqlDataReader reader2;

            comm2 = new SqlCommand(
                "SELECT IV.ID_ItemVenda, IV.ID_Venda, IV.CodigoDeBarras, IV.Quantidade, IV.Valor, " +
                "P.NomeProduto, P.PrecoUnit " +
                "FROM ItemVenda AS IV " +
                "INNER JOIN Produto AS P " +
                "ON P.CodigoDeBarras = IV.CodigoDeBarras " +
                "WHERE IV.ID_Venda = @ID_Venda", conn);

            comm2.Parameters.Add("@ID_Venda", System.Data.SqlDbType.Int);
            comm2.Parameters["@ID_Venda"].Value = Convert.ToInt32(mtxIDVenda.Text);

            try
            {
                try
                {
                    conn.Open();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao tentar abrir o Banco de Dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                try
                {
                    reader2 = comm2.ExecuteReader();

                    while (reader2.Read())
                    {
                        // Adicina uma nova linha no carrinho
                        dgvCarrinho.Rows.Add();

                        // Adiciona dados do produto no carrinho
                        dgvCarrinho.Rows[iQtdProdutosLista].Cells[0].Value = reader2["CodigoDeBarras"].ToString();
                        dgvCarrinho.Rows[iQtdProdutosLista].Cells[1].Value = reader2["NomeProduto"].ToString();
                        dgvCarrinho.Rows[iQtdProdutosLista].Cells[2].Value = String.Format("{0:F2}", reader2["PrecoUnit"]);
                        dgvCarrinho.Rows[iQtdProdutosLista].Cells[3].Value = reader2["Quantidade"].ToString();
                        dgvCarrinho.Rows[iQtdProdutosLista].Cells[4].Value = String.Format("{0:F2}", reader2["Valor"]);

                        // Faz update do Preço Total
                        fPrecoTotal += (Convert.ToSingle(reader2["Valor"].ToString()));
                        lbPrecoTotal.Text = String.Format("{0:F2}", fPrecoTotal);

                        iQtdProdutosLista++; // Incrementa quantidade de itens no carrinho
                        lbQtdProdutosLista.Text = iQtdProdutosLista.ToString();
                    }

                    reader2.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao tentar executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch { }
            finally
            {
                conn.Close();
            }

        } // Fim Consultar


        private void txPrecoUnit_TextChanged(object sender, EventArgs e)
        {
            txPrecoUnit.Text = Convert.ToSingle(txPrecoUnit.Text).ToString("N2");
        }

    }
    
}

