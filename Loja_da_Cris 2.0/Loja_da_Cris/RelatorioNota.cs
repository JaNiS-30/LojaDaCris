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
            // TODO: This line of code loads data into the 'lojaDaCrisDataSetNovo.DataTable4' table. You can move, or remove it, as needed.
            this.dataTable4TableAdapter.FillByNotaVenda(this.lojaDaCrisDataSetNovo.DataTable4);

            this.reportViewer1.RefreshReport();
        }
    }
}
