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
    public partial class Categoria : Form
    {
        public Categoria()
        {
            InitializeComponent();
        }

        private void categoriaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lojaDaCrisDataSetNovo);

        }

        private void Categoria_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lojaDaCrisDataSetNovo.Categoria' table. You can move, or remove it, as needed.
            this.categoriaTableAdapter.Fill(this.lojaDaCrisDataSetNovo.Categoria);

        }
    }
}
