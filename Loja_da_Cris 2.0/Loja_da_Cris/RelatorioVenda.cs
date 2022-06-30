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
    public partial class RelatorioVenda : Form
    {
        public RelatorioVenda()
        {
            InitializeComponent();
        }

        private void RelatorioVenda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lojaDaCrisDataSetNovo.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.lojaDaCrisDataSetNovo.Cliente);
            // TODO: This line of code loads data into the 'lojaDaCrisDataSetNovo.Vendedor' table. You can move, or remove it, as needed.
            this.vendedorTableAdapter.Fill(this.lojaDaCrisDataSetNovo.Vendedor);
            // TODO: This line of code loads data into the 'lojaDaCrisDataSetNovo.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.FillByVenda(this.lojaDaCrisDataSetNovo.DataTable1);

            this.reportViewer1.RefreshReport();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbFiltro.Text == "Vendedor") {
                cbCliente.Visible = false;
                label2.Visible = true;
                cbVendedor.Visible = true;
                // TODO: This line of code loads data into the 'lojaDaCrisDataSetNovo.Vendedor' table. You can move, or remove it, as needed.
                this.vendedorTableAdapter.Fill(this.lojaDaCrisDataSetNovo.Vendedor);
            }
            if(cbFiltro.Text == "Maiores vendas")
            {
                label2.Visible = false;
                cbVendedor.Visible = false;
                cbCliente.Visible = false;
            }
            if (cbFiltro.Text == "Cliente")
            {
                cbVendedor.Visible = false;
                label2.Visible = true;
                cbCliente.Visible = true;
                // TODO: This line of code loads data into the 'lojaDaCrisDataSetNovo.Cliente' table. You can move, or remove it, as needed.
                this.clienteTableAdapter.Fill(this.lojaDaCrisDataSetNovo.Cliente);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                dateTimePicker1.Visible = true;
                dateTimePicker2.Visible = true;
                label3.Visible = true;
            }
            if (!checkBox1.Checked)
            {
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
                label3.Visible = false;
            }
        }

        private void btRelCliente_Click(object sender, EventArgs e)
        {
            if (cbFiltro.Text == "" && checkBox1.Checked)
            {
                this.dataTable1TableAdapter.FillByData(this.lojaDaCrisDataSetNovo.DataTable1, dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString());

                this.reportViewer1.RefreshReport();
            }

            if (cbFiltro.Text == "Vendedor" && !checkBox1.Checked)
            {
                this.dataTable1TableAdapter.FillByVendedor(this.lojaDaCrisDataSetNovo.DataTable1, cbVendedor.Text);

                this.reportViewer1.RefreshReport();
            }

            if (cbFiltro.Text == "Maiores vendas" && !checkBox1.Checked)
            {
                this.dataTable1TableAdapter.FillByMaioresVendas(this.lojaDaCrisDataSetNovo.DataTable1);

                this.reportViewer1.RefreshReport();
            }

            if (cbFiltro.Text == "Maiores vendas" && checkBox1.Checked)
            {
                this.dataTable1TableAdapter.FillByMaioresVendasData(this.lojaDaCrisDataSetNovo.DataTable1, dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString());

                this.reportViewer1.RefreshReport();
            }

            if (cbFiltro.Text == "Vendedor" && checkBox1.Checked)
            {
                this.dataTable1TableAdapter.FillByVendedorData(this.lojaDaCrisDataSetNovo.DataTable1, cbVendedor.Text, dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString());

                this.reportViewer1.RefreshReport();
            }
            if (cbFiltro.Text == "Cliente" && !checkBox1.Checked)
            {
                this.dataTable1TableAdapter.FillByCliente(this.lojaDaCrisDataSetNovo.DataTable1, cbCliente.Text);

                this.reportViewer1.RefreshReport();
            }
            if (cbFiltro.Text == "Cliente" && checkBox1.Checked)
            {
                this.dataTable1TableAdapter.FillByClienteData(this.lojaDaCrisDataSetNovo.DataTable1, cbCliente.Text, dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString());

                this.reportViewer1.RefreshReport();
            }
        }
    }
}
