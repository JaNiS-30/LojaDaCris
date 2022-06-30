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
        }

        //Atualiza o tempo no rodapé
        private void timer1_Tick(object sender, EventArgs e)
        {
            tsData.Text = DateTime.Now.ToString("D");
            tsHora.Text = DateTime.Now.ToString("T");
        }

        // Botao para voltar a tela de login
        private void btDeslogar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.FormClosed += (s, args) => this.Close();

            frm.Show();
        }

        // Botao para sair da aplicacao
        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Botao para abrir o form de clientes
        private void btClientes_Click(object sender, EventArgs e)
        {
            this.Hide();

            Clientes frm = new Clientes();

            frm.FormClosed += (s, args) => this.Close();

            frm.Show();
        }

        // Botao para abrir o form de produtos
        private void btProdutos_Click(object sender, EventArgs e)
        {
            this.Hide();

            Produtos frm = new Produtos();

            frm.FormClosed += (s, args) => this.Close();

            frm.Show();
        }

        // Botao para abrir o form do financeiro
        private void btFinanceiro_Click(object sender, EventArgs e)
        {
            this.Hide();

            Financeiro frm = new Financeiro();

            frm.FormClosed += (s, args) => this.Close();

            frm.Show();
        }
        // Botao para abrir o form de configuração
        private void btConfiguracoes_Click(object sender, EventArgs e)
        {
            this.Hide();

            Configuracao frm = new Configuracao();

            frm.FormClosed += (s, args) => this.Close();

            frm.Show();
        }
    }
}
