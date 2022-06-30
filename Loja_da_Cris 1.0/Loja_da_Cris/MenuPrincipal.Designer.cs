
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
            this.btDeslogar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btClientes = new System.Windows.Forms.Button();
            this.btProdutos = new System.Windows.Forms.Button();
            this.btFinanceiro = new System.Windows.Forms.Button();
            this.btConfiguracoes = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
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
            this.tsHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
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
            // btDeslogar
            // 
            this.btDeslogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeslogar.Image = global::Loja_da_Cris.Properties.Resources.voltar;
            this.btDeslogar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btDeslogar.Location = new System.Drawing.Point(496, 19);
            this.btDeslogar.Name = "btDeslogar";
            this.btDeslogar.Size = new System.Drawing.Size(86, 59);
            this.btDeslogar.TabIndex = 18;
            this.btDeslogar.Text = "Deslogar";
            this.btDeslogar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btDeslogar.UseVisualStyleBackColor = true;
            this.btDeslogar.Click += new System.EventHandler(this.btDeslogar_Click);
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Image = global::Loja_da_Cris.Properties.Resources.Power;
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSair.Location = new System.Drawing.Point(610, 19);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(86, 59);
            this.btSair.TabIndex = 17;
            this.btSair.Text = "Sair";
            this.btSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btClientes
            // 
            this.btClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClientes.Image = global::Loja_da_Cris.Properties.Resources.adicionar_cliente;
            this.btClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btClientes.Location = new System.Drawing.Point(40, 19);
            this.btClientes.Name = "btClientes";
            this.btClientes.Size = new System.Drawing.Size(86, 59);
            this.btClientes.TabIndex = 16;
            this.btClientes.Text = "Clientes";
            this.btClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btClientes.UseMnemonic = false;
            this.btClientes.UseVisualStyleBackColor = true;
            this.btClientes.Click += new System.EventHandler(this.btClientes_Click);
            // 
            // btProdutos
            // 
            this.btProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProdutos.Image = global::Loja_da_Cris.Properties.Resources.adicionar_produto;
            this.btProdutos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btProdutos.Location = new System.Drawing.Point(154, 19);
            this.btProdutos.Name = "btProdutos";
            this.btProdutos.Size = new System.Drawing.Size(86, 59);
            this.btProdutos.TabIndex = 15;
            this.btProdutos.Text = "Produtos";
            this.btProdutos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btProdutos.UseVisualStyleBackColor = true;
            this.btProdutos.Click += new System.EventHandler(this.btProdutos_Click);
            // 
            // btFinanceiro
            // 
            this.btFinanceiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFinanceiro.Image = global::Loja_da_Cris.Properties.Resources.criar_relatorio;
            this.btFinanceiro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btFinanceiro.Location = new System.Drawing.Point(268, 19);
            this.btFinanceiro.Name = "btFinanceiro";
            this.btFinanceiro.Size = new System.Drawing.Size(86, 59);
            this.btFinanceiro.TabIndex = 14;
            this.btFinanceiro.Text = "Financeiro";
            this.btFinanceiro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btFinanceiro.UseVisualStyleBackColor = true;
            this.btFinanceiro.Click += new System.EventHandler(this.btFinanceiro_Click);
            // 
            // btConfiguracoes
            // 
            this.btConfiguracoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfiguracoes.Image = global::Loja_da_Cris.Properties.Resources.configurações;
            this.btConfiguracoes.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btConfiguracoes.Location = new System.Drawing.Point(382, 19);
            this.btConfiguracoes.Name = "btConfiguracoes";
            this.btConfiguracoes.Size = new System.Drawing.Size(86, 59);
            this.btConfiguracoes.TabIndex = 13;
            this.btConfiguracoes.Text = "Config";
            this.btConfiguracoes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btConfiguracoes.UseVisualStyleBackColor = true;
            this.btConfiguracoes.Click += new System.EventHandler(this.btConfiguracoes_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Loja_da_Cris.Properties.Resources.Loja_da_Cris__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btDeslogar);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btClientes);
            this.Controls.Add(this.btProdutos);
            this.Controls.Add(this.btFinanceiro);
            this.Controls.Add(this.btConfiguracoes);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel Data;
        private System.Windows.Forms.ToolStripStatusLabel Hora;
        private System.Windows.Forms.Button btDeslogar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btClientes;
        private System.Windows.Forms.Button btProdutos;
        private System.Windows.Forms.Button btFinanceiro;
        private System.Windows.Forms.Button btConfiguracoes;
        private System.Windows.Forms.ToolStripStatusLabel tsData;
        private System.Windows.Forms.ToolStripStatusLabel tsHora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    }
}