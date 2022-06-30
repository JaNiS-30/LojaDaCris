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
    public partial class RelatorioProdutos : Form
    {
        public RelatorioProdutos()
        {
            InitializeComponent();
        }

        private void RelatorioProdutos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LojaDaCrisDataSet.Produtos' table. You can move, or remove it, as needed.
            this.ProdutosTableAdapter.Fill(this.LojaDaCrisDataSet.Produtos);

            this.reportViewer1.RefreshReport();
        }
    }
}
