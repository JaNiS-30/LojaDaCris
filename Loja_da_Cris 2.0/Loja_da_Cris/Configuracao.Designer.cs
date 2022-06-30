
namespace Loja_da_Cris
{
    partial class Configuracao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuracao));
            this.btVoltar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Data = new System.Windows.Forms.ToolStripStatusLabel();
            this.Hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsData = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btAdicionarCategoria = new System.Windows.Forms.Button();
            this.btAdicionarLogin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txNomeCategoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txNomeSenha = new System.Windows.Forms.GroupBox();
            this.txSenhaConfirmar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txNomeLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.txNomeSenha.SuspendLayout();
            this.SuspendLayout();
            // 
            // btVoltar
            // 
            this.btVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.Image = global::Loja_da_Cris.Properties.Resources.voltar;
            this.btVoltar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btVoltar.Location = new System.Drawing.Point(12, 12);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(86, 59);
            this.btVoltar.TabIndex = 31;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
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
            this.statusStrip1.TabIndex = 34;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(156, 17);
            this.toolStripStatusLabel1.Text = "Configurações - Loja da Cris";
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btAdicionarCategoria
            // 
            this.btAdicionarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdicionarCategoria.Image = global::Loja_da_Cris.Properties.Resources.adicionar_produto;
            this.btAdicionarCategoria.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAdicionarCategoria.Location = new System.Drawing.Point(32, 58);
            this.btAdicionarCategoria.Name = "btAdicionarCategoria";
            this.btAdicionarCategoria.Size = new System.Drawing.Size(146, 63);
            this.btAdicionarCategoria.TabIndex = 35;
            this.btAdicionarCategoria.Text = "Adicionar categoria";
            this.btAdicionarCategoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAdicionarCategoria.UseVisualStyleBackColor = true;
            this.btAdicionarCategoria.Click += new System.EventHandler(this.btAdicionarCategoria_Click);
            // 
            // btAdicionarLogin
            // 
            this.btAdicionarLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdicionarLogin.Image = global::Loja_da_Cris.Properties.Resources.adicionar_cliente;
            this.btAdicionarLogin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAdicionarLogin.Location = new System.Drawing.Point(93, 133);
            this.btAdicionarLogin.Name = "btAdicionarLogin";
            this.btAdicionarLogin.Size = new System.Drawing.Size(113, 63);
            this.btAdicionarLogin.TabIndex = 36;
            this.btAdicionarLogin.Text = "Adicionar login";
            this.btAdicionarLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAdicionarLogin.UseVisualStyleBackColor = true;
            this.btAdicionarLogin.Click += new System.EventHandler(this.btAdicionarLogin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txNomeCategoria);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btAdicionarCategoria);
            this.groupBox1.Location = new System.Drawing.Point(123, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 137);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar categoria";
            // 
            // txNomeCategoria
            // 
            this.txNomeCategoria.Location = new System.Drawing.Point(51, 32);
            this.txNomeCategoria.Name = "txNomeCategoria";
            this.txNomeCategoria.Size = new System.Drawing.Size(113, 20);
            this.txNomeCategoria.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Nome:";
            // 
            // txNomeSenha
            // 
            this.txNomeSenha.BackColor = System.Drawing.Color.Transparent;
            this.txNomeSenha.Controls.Add(this.txSenhaConfirmar);
            this.txNomeSenha.Controls.Add(this.label4);
            this.txNomeSenha.Controls.Add(this.btAdicionarLogin);
            this.txNomeSenha.Controls.Add(this.txSenha);
            this.txNomeSenha.Controls.Add(this.label3);
            this.txNomeSenha.Controls.Add(this.txNomeLogin);
            this.txNomeSenha.Controls.Add(this.label2);
            this.txNomeSenha.Location = new System.Drawing.Point(381, 12);
            this.txNomeSenha.Name = "txNomeSenha";
            this.txNomeSenha.Size = new System.Drawing.Size(293, 207);
            this.txNomeSenha.TabIndex = 38;
            this.txNomeSenha.TabStop = false;
            this.txNomeSenha.Text = "Adicionar login";
            // 
            // txSenhaConfirmar
            // 
            this.txSenhaConfirmar.Location = new System.Drawing.Point(93, 101);
            this.txSenhaConfirmar.Name = "txSenhaConfirmar";
            this.txSenhaConfirmar.Size = new System.Drawing.Size(113, 20);
            this.txSenhaConfirmar.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Confirmar senha:";
            // 
            // txSenha
            // 
            this.txSenha.Location = new System.Drawing.Point(50, 65);
            this.txSenha.Name = "txSenha";
            this.txSenha.Size = new System.Drawing.Size(113, 20);
            this.txSenha.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Senha:";
            // 
            // txNomeLogin
            // 
            this.txNomeLogin.Location = new System.Drawing.Point(50, 28);
            this.txNomeLogin.Name = "txNomeLogin";
            this.txNomeLogin.Size = new System.Drawing.Size(113, 20);
            this.txNomeLogin.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Nome:";
            // 
            // Configuracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Loja_da_Cris.Properties.Resources.Loja_da_Cris__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txNomeSenha);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btVoltar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Configuracao";
            this.Text = "Configuracao";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.txNomeSenha.ResumeLayout(false);
            this.txNomeSenha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel Data;
        private System.Windows.Forms.ToolStripStatusLabel Hora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tsData;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tsHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btAdicionarCategoria;
        private System.Windows.Forms.Button btAdicionarLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txNomeCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox txNomeSenha;
        private System.Windows.Forms.TextBox txSenhaConfirmar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txNomeLogin;
        private System.Windows.Forms.Label label2;
    }
}