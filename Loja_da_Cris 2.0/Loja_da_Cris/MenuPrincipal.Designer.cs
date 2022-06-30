
namespace Loja_da_Cris
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Data = new System.Windows.Forms.ToolStripStatusLabel();
            this.Hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsData = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emitirRelatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emitirRelatórioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioDeVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioDeVendaPorProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioVendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trocarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deslogarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.Data,
            this.Hora,
            this.toolStripStatusLabel2,
            this.tsData,
            this.toolStripStatusLabel3,
            this.tsHora,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 451);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1056, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(137, 17);
            this.toolStripStatusLabel1.Text = "Bem Vindo - Loja da Cris";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Data
            // 
            this.Data.Name = "Data";
            this.Data.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Data.Size = new System.Drawing.Size(0, 17);
            this.Data.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Hora
            // 
            this.Hora.Name = "Hora";
            this.Hora.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Hora.Size = new System.Drawing.Size(0, 17);
            this.Hora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(34, 17);
            this.toolStripStatusLabel2.Text = "Data:";
            // 
            // tsData
            // 
            this.tsData.Name = "tsData";
            this.tsData.Size = new System.Drawing.Size(118, 17);
            this.tsData.Text = "toolStripStatusLabel3";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(36, 17);
            this.toolStripStatusLabel3.Text = "Hora:";
            // 
            // tsHora
            // 
            this.tsHora.Name = "tsHora";
            this.tsHora.Size = new System.Drawing.Size(118, 17);
            this.tsHora.Text = "toolStripStatusLabel4";
            this.tsHora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(60, 17);
            this.toolStripStatusLabel5.Text = "Vendedor:";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel4.Text = "toolStripStatusLabel4";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.financeiroToolStripMenuItem,
            this.configuraçõesToolStripMenuItem,
            this.deslogarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1056, 27);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarClienteToolStripMenuItem,
            this.emitirRelatórioToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(69, 23);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // editarClienteToolStripMenuItem
            // 
            this.editarClienteToolStripMenuItem.Name = "editarClienteToolStripMenuItem";
            this.editarClienteToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.editarClienteToolStripMenuItem.Text = "Editar cliente";
            this.editarClienteToolStripMenuItem.Click += new System.EventHandler(this.editarClienteToolStripMenuItem_Click);
            // 
            // emitirRelatórioToolStripMenuItem
            // 
            this.emitirRelatórioToolStripMenuItem.Name = "emitirRelatórioToolStripMenuItem";
            this.emitirRelatórioToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.emitirRelatórioToolStripMenuItem.Text = "Emitir relatório";
            this.emitirRelatórioToolStripMenuItem.Click += new System.EventHandler(this.emitirRelatórioToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarProdutosToolStripMenuItem,
            this.emitirRelatórioToolStripMenuItem1});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(77, 23);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // editarProdutosToolStripMenuItem
            // 
            this.editarProdutosToolStripMenuItem.Name = "editarProdutosToolStripMenuItem";
            this.editarProdutosToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.editarProdutosToolStripMenuItem.Text = "Editar produtos";
            this.editarProdutosToolStripMenuItem.Click += new System.EventHandler(this.editarProdutosToolStripMenuItem_Click);
            // 
            // emitirRelatórioToolStripMenuItem1
            // 
            this.emitirRelatórioToolStripMenuItem1.Name = "emitirRelatórioToolStripMenuItem1";
            this.emitirRelatórioToolStripMenuItem1.Size = new System.Drawing.Size(173, 24);
            this.emitirRelatórioToolStripMenuItem1.Text = "Emitir relatório";
            this.emitirRelatórioToolStripMenuItem1.Click += new System.EventHandler(this.emitirRelatórioToolStripMenuItem1_Click);
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarVendaToolStripMenuItem,
            this.relatorioDeVendaToolStripMenuItem,
            this.relatorioDeVendaPorProdutoToolStripMenuItem,
            this.relatorioVendedorToolStripMenuItem});
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(83, 23);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // realizarVendaToolStripMenuItem
            // 
            this.realizarVendaToolStripMenuItem.Name = "realizarVendaToolStripMenuItem";
            this.realizarVendaToolStripMenuItem.Size = new System.Drawing.Size(271, 24);
            this.realizarVendaToolStripMenuItem.Text = "Realizar venda";
            this.realizarVendaToolStripMenuItem.Click += new System.EventHandler(this.realizarVendaToolStripMenuItem_Click);
            // 
            // relatorioDeVendaToolStripMenuItem
            // 
            this.relatorioDeVendaToolStripMenuItem.Name = "relatorioDeVendaToolStripMenuItem";
            this.relatorioDeVendaToolStripMenuItem.Size = new System.Drawing.Size(271, 24);
            this.relatorioDeVendaToolStripMenuItem.Text = "Relatorio de venda";
            this.relatorioDeVendaToolStripMenuItem.Click += new System.EventHandler(this.relatorioDeVendaToolStripMenuItem_Click);
            // 
            // relatorioDeVendaPorProdutoToolStripMenuItem
            // 
            this.relatorioDeVendaPorProdutoToolStripMenuItem.Name = "relatorioDeVendaPorProdutoToolStripMenuItem";
            this.relatorioDeVendaPorProdutoToolStripMenuItem.Size = new System.Drawing.Size(271, 24);
            this.relatorioDeVendaPorProdutoToolStripMenuItem.Text = "Relatorio de venda por produto";
            this.relatorioDeVendaPorProdutoToolStripMenuItem.Click += new System.EventHandler(this.relatorioDeVendaPorProdutoToolStripMenuItem_Click);
            // 
            // relatorioVendedorToolStripMenuItem
            // 
            this.relatorioVendedorToolStripMenuItem.Name = "relatorioVendedorToolStripMenuItem";
            this.relatorioVendedorToolStripMenuItem.Size = new System.Drawing.Size(271, 24);
            this.relatorioVendedorToolStripMenuItem.Text = "Relatorio Vendedor";
            this.relatorioVendedorToolStripMenuItem.Click += new System.EventHandler(this.relatorioVendedorToolStripMenuItem_Click);
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarCategoriaToolStripMenuItem,
            this.trocarSenhaToolStripMenuItem,
            this.editarUsuárioToolStripMenuItem});
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(108, 23);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // adicionarCategoriaToolStripMenuItem
            // 
            this.adicionarCategoriaToolStripMenuItem.Name = "adicionarCategoriaToolStripMenuItem";
            this.adicionarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.adicionarCategoriaToolStripMenuItem.Text = "Adicionar categoria";
            this.adicionarCategoriaToolStripMenuItem.Click += new System.EventHandler(this.adicionarCategoriaToolStripMenuItem_Click);
            // 
            // trocarSenhaToolStripMenuItem
            // 
            this.trocarSenhaToolStripMenuItem.Name = "trocarSenhaToolStripMenuItem";
            this.trocarSenhaToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.trocarSenhaToolStripMenuItem.Text = "Trocar senha";
            this.trocarSenhaToolStripMenuItem.Click += new System.EventHandler(this.trocarSenhaToolStripMenuItem_Click);
            // 
            // editarUsuárioToolStripMenuItem
            // 
            this.editarUsuárioToolStripMenuItem.Name = "editarUsuárioToolStripMenuItem";
            this.editarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.editarUsuárioToolStripMenuItem.Text = "Editar usuário";
            this.editarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.editarUsuárioToolStripMenuItem_Click);
            // 
            // deslogarToolStripMenuItem
            // 
            this.deslogarToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.deslogarToolStripMenuItem.Name = "deslogarToolStripMenuItem";
            this.deslogarToolStripMenuItem.Size = new System.Drawing.Size(75, 23);
            this.deslogarToolStripMenuItem.Text = "Deslogar";
            this.deslogarToolStripMenuItem.Click += new System.EventHandler(this.deslogarToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Loja_da_Cris.Properties.Resources.Loja_da_Cris__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1056, 473);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.TransparencyKey = System.Drawing.Color.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel Data;
        private System.Windows.Forms.ToolStripStatusLabel Hora;
        private System.Windows.Forms.ToolStripStatusLabel tsData;
        private System.Windows.Forms.ToolStripStatusLabel tsHora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emitirRelatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emitirRelatórioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioDeVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trocarSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deslogarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioDeVendaPorProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioVendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
    }
}