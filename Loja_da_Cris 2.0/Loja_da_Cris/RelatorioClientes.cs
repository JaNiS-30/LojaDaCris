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
    public partial class RelatorioClientes : Form
    {
        public RelatorioClientes()
        {
            InitializeComponent();
        }

        private void RelatorioClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lojaDaCrisDataSetNovo.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.lojaDaCrisDataSetNovo.Cliente);
            // TODO: This line of code loads data into the 'lojaDaCrisDataSetNovo.Produto' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.lojaDaCrisDataSetNovo.Cliente);

            cbTipoRel.Text = "Nome";

            this.reportViewer1.RefreshReport();
        }

        private void btGerRel_Click(object sender, EventArgs e)
        {
            if (cbTipoRel.Text == "Nome")
            {
                this.clienteTableAdapter.FillByNome(this.lojaDaCrisDataSetNovo.Cliente, txInfo.Text + "%");
                this.reportViewer1.RefreshReport();
            }
            if (cbTipoRel.Text == "CPF")
            {
                this.clienteTableAdapter.FillByCPF(this.lojaDaCrisDataSetNovo.Cliente, mtxCPF.Text + "%");
                this.reportViewer1.RefreshReport();
            }

        }

        private void cbTipoRel_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbTipoRel.Text == "Nome")
            {
                txInfo.Visible = true;
                mtxCPF.Visible = false;
            }
            if(cbTipoRel.Text == "CPF")
            {
                txInfo.Visible = false;
                mtxCPF.Visible = true;
            }
        }
    }
}
