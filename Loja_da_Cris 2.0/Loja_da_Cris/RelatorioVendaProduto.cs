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
    public partial class RelatorioVendaProduto : Form
    {
        public RelatorioVendaProduto()
        {
            InitializeComponent();
        }

        private void RelatorioVendaProduto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lojaDaCrisDataSetNovo.Produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.lojaDaCrisDataSetNovo.Produto);
            // TODO: This line of code loads data into the 'lojaDaCrisDataSetNovo.DataTable2' table. You can move, or remove it, as needed.
            this.dataTable2TableAdapter.FillByVendaProduto(this.lojaDaCrisDataSetNovo.DataTable2);

            this.reportViewer1.RefreshReport();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dateTimePicker1.Visible = true;
                label3.Visible = true;
                dateTimePicker2.Visible = true;
            }
            if (!checkBox1.Checked)
            {
                dateTimePicker1.Visible = false;
                label3.Visible = false;
                dateTimePicker2.Visible = false;
            }
            if (cbFiltro.Text == "ID Venda")
            {
                checkBox1.Checked = false;
            }

        }

        private void cbFiltro_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbFiltro.Text == "ID Venda")
            {
                label4.Visible = false;
                cbProduto.Visible = false;
                label2.Visible = true;
                mtxIDVenda.Visible = true;
                checkBox1.Checked = false;
            }
            if (cbFiltro.Text == "Produto")
            {
                label2.Visible = false;
                mtxIDVenda.Visible = false;
                label4.Visible = true;
                cbProduto.Visible = true;
                // TODO: This line of code loads data into the 'lojaDaCrisDataSetNovo.Produto' table. You can move, or remove it, as needed.
                this.produtoTableAdapter.Fill(this.lojaDaCrisDataSetNovo.Produto);
            }
        }

        private void btRelCliente_Click(object sender, EventArgs e)
        {   
            if (cbFiltro.Text == "" && checkBox1.Checked)
            {
                this.dataTable2TableAdapter.FillByData(this.lojaDaCrisDataSetNovo.DataTable2, dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString());

                this.reportViewer1.RefreshReport();
            }
            if (cbFiltro.Text == "ID Venda" && !checkBox1.Checked)
            {
                this.dataTable2TableAdapter.FillByIDVenda(this.lojaDaCrisDataSetNovo.DataTable2, Convert.ToInt32(mtxIDVenda.Text));

                this.reportViewer1.RefreshReport();
            }
            if (cbFiltro.Text == "Produto" && !checkBox1.Checked)
            {
                this.dataTable2TableAdapter.FillByProduto(this.lojaDaCrisDataSetNovo.DataTable2, cbProduto.Text);

                this.reportViewer1.RefreshReport();
            }
            if (cbFiltro.Text == "Produto" && checkBox1.Checked)
            {
                this.dataTable2TableAdapter.FillByProdutoData(this.lojaDaCrisDataSetNovo.DataTable2, cbProduto.Text, dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString());

                this.reportViewer1.RefreshReport();
            }

        }
    }
}
