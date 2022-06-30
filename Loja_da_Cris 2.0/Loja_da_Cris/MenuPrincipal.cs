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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();

            Form1.esqSenha = false;
            toolStripStatusLabel4.Text = Form1.nomeUsuario;

            if (!Form1.isAdm)
            {
                relatorioDeVendaToolStripMenuItem.Visible = false;
                trocarSenhaToolStripMenuItem.Visible = false;
                editarUsuárioToolStripMenuItem.Visible = false;
                relatorioDeVendaPorProdutoToolStripMenuItem.Visible = false;
                relatorioVendedorToolStripMenuItem.Visible = false;
            }
        }

        //Atualiza o tempo no rodapé
        private void timer1_Tick(object sender, EventArgs e)
        {
            tsData.Text = DateTime.Now.ToString("D");
            tsHora.Text = DateTime.Now.ToString("T");
        }      

        private void editarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes frm = new Clientes();

            frm.MdiParent = this;

            frm.Show();
        }

        private void editarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produtos frm = new Produtos();

            frm.MdiParent = this;

            frm.Show();
        }

        private void emitirRelatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioClientes frm = new RelatorioClientes();

            frm.MdiParent = this;

            frm.Show();
        }

        private void emitirRelatórioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RelatorioProduto frm = new RelatorioProduto();

            frm.MdiParent = this;

            frm.Show();
        }

        private void realizarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vendas frm = new Vendas();

            frm.MdiParent = this;

            frm.Show();
        }

        private void relatorioDeVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioVenda frm = new RelatorioVenda();

            frm.MdiParent = this;

            frm.Show();
        }

        private void adicionarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categoria frm = new Categoria();

            frm.MdiParent = this;

            frm.Show();
        }

        private void trocarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrocarSenha frm = new TrocarSenha();

            frm.MdiParent = this;

            frm.Show();
        }

        private void editarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario frm = new Usuario();

            frm.MdiParent = this;

            frm.Show();
        }

        private void deslogarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.FormClosed += (s, args) => this.Close();

            frm.Show();
        }

        private void relatorioDeVendaPorProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioVendaProduto frm = new RelatorioVendaProduto();

            frm.MdiParent = this;

            frm.Show();
        }

        private void relatorioVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioVendedor frm = new RelatorioVendedor();

            frm.MdiParent = this;

            frm.Show();
        }

    }
}
