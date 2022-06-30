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
    public partial class RelatorioNota : Form
    {
        public RelatorioNota()
        {
            InitializeComponent();
        }

        private void RelatorioNota_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LojaDaCrisDataSet.Notas' table. You can move, or remove it, as needed.
            this.NotasTableAdapter.Fill(this.LojaDaCrisDataSet.Notas);
            // TODO: This line of code loads data into the 'LojaDaCrisDataSet.Produtos' table. You can move, or remove it, as needed.
            this.ProdutosTableAdapter.Fill(this.LojaDaCrisDataSet.Produtos);

            this.reportViewer1.RefreshReport();
        }
    }
}
