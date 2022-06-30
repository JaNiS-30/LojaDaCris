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
    public partial class RelatorioVendedor : Form
    {
        public RelatorioVendedor()
        {
            InitializeComponent();
        }

        private void RelatorioVendedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lojaDaCrisDataSetNovo1.Vendedor' table. You can move, or remove it, as needed.
            this.vendedorTableAdapter.Fill(this.lojaDaCrisDataSetNovo1.Vendedor);
            // TODO: This line of code loads data into the 'lojaDaCrisDataSetNovo.Vendedor' table. You can move, or remove it, as needed.
            this.vendedorTableAdapter.Fill(this.lojaDaCrisDataSetNovo.Vendedor);

            this.reportViewer1.RefreshReport();
        }

        private void cbTipoRel_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbTipoRel.Text == "Vendedor")
            {
                label2.Visible = true;
                comboBox1.Visible = true;
            }
            if (cbTipoRel.Text == "Maiores Comissões")
            {
                label2.Visible = false;
                comboBox1.Visible = false;
            }
        }

        private void btLimparComissao_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;

            string connectionString = Properties.Settings.Default.LojaDaCrisConnectionString;

            conn = new SqlConnection(connectionString);

            // Comando SQL para incluir na table Clientes

            comm = new SqlCommand(
                "UPDATE Vendedor " +
                "SET ComissaoRecebida = 0.0", conn);

            
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

                }
            }
            catch { }
            finally
            {
                // Fechar a conexão com o banco de dados
                conn.Close();

                MessageBox.Show("Comissao dos vendedores zerada!",
                        "Sucesso !",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.vendedorTableAdapter.Fill(this.lojaDaCrisDataSetNovo.Vendedor);

                this.reportViewer1.RefreshReport();
            }
        }

        private void btGerRel_Click(object sender, EventArgs e)
        {
            if (cbTipoRel.Text == "Vendedor") {
                this.vendedorTableAdapter.FillByUsuario(this.lojaDaCrisDataSetNovo.Vendedor, comboBox1.Text);

                this.reportViewer1.RefreshReport();

            }
            else if (cbTipoRel.Text == "Maiores Comissões") {
                this.vendedorTableAdapter.FillByMaiorComissao(this.lojaDaCrisDataSetNovo.Vendedor);

                this.reportViewer1.RefreshReport();

            } else
            {
                this.vendedorTableAdapter.Fill(this.lojaDaCrisDataSetNovo.Vendedor);

                this.reportViewer1.RefreshReport();
            }
        }
    }
}
