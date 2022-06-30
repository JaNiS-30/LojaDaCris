using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_da_Cris
{
    public partial class RelatorioProduto : Form
    {
        public RelatorioProduto()
        {
            InitializeComponent();
        }

        private void RelatorioProduto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lojaDaCrisDataSetNovo.DataTable3' table. You can move, or remove it, as needed.
            this.dataTable3TableAdapter.FillByProduto(this.lojaDaCrisDataSetNovo.DataTable3);
            // TODO: This line of code loads data into the 'lojaDaCrisDataSetNovo.Produto' table. You can move, or remove it, as needed.

            cbTipoRel.Text = "Código de barras";

            this.reportViewer1.RefreshReport();
        }

        private void btGerRel_Click(object sender, EventArgs e)
        {
            if (cbTipoRel.Text == "Código de barras")
            {
                this.dataTable3TableAdapter.FillByCodigo(this.lojaDaCrisDataSetNovo.DataTable3, Convert.ToInt32(txInfo.Text));
                this.reportViewer1.RefreshReport();
            }
            if (cbTipoRel.Text == "Nome do produto")
            {
                this.dataTable3TableAdapter.FillByNome(this.lojaDaCrisDataSetNovo.DataTable3, txInfo.Text + "%");
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
