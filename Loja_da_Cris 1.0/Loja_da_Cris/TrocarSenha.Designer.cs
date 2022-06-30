
namespace Loja_da_Cris
{
    partial class TrocarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrocarSenha));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txUsuario = new System.Windows.Forms.TextBox();
            this.txSenha1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txSenha2 = new System.Windows.Forms.TextBox();
            this.btTrocaSenha = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha:";
            // 
            // txUsuario
            // 
            this.txUsuario.Location = new System.Drawing.Point(169, 39);
            this.txUsuario.Name = "txUsuario";
            this.txUsuario.Size = new System.Drawing.Size(163, 20);
            this.txUsuario.TabIndex = 3;
            // 
            // txSenha1
            // 
            this.txSenha1.Location = new System.Drawing.Point(169, 76);
            this.txSenha1.Name = "txSenha1";
            this.txSenha1.Size = new System.Drawing.Size(163, 20);
            this.txSenha1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirmar senha:";
            // 
            // txSenha2
            // 
            this.txSenha2.Location = new System.Drawing.Point(169, 113);
            this.txSenha2.Name = "txSenha2";
            this.txSenha2.Size = new System.Drawing.Size(163, 20);
            this.txSenha2.TabIndex = 6;
            // 
            // btTrocaSenha
            // 
            this.btTrocaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTrocaSenha.Location = new System.Drawing.Point(150, 176);
            this.btTrocaSenha.Name = "btTrocaSenha";
            this.btTrocaSenha.Size = new System.Drawing.Size(122, 36);
            this.btTrocaSenha.TabIndex = 7;
            this.btTrocaSenha.Text = "Trocar Senha";
            this.btTrocaSenha.UseVisualStyleBackColor = true;
            this.btTrocaSenha.Click += new System.EventHandler(this.btTrocaSenha_Click);
            this.btTrocaSenha.MouseHover += new System.EventHandler(this.btTrocaSenha_MouseHover);
            // 
            // btVoltar
            // 
            this.btVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.Image = global::Loja_da_Cris.Properties.Resources.voltar;
            this.btVoltar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btVoltar.Location = new System.Drawing.Point(359, 37);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(75, 59);
            this.btVoltar.TabIndex = 8;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            this.btVoltar.MouseHover += new System.EventHandler(this.btVoltar_MouseHover);
            // 
            // TrocarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Loja_da_Cris.Properties.Resources.Loja_da_Cris__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(446, 450);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btTrocaSenha);
            this.Controls.Add(this.txSenha2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txSenha1);
            this.Controls.Add(this.txUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrocarSenha";
            this.Text = "Trocar Senha";
            this.MouseHover += new System.EventHandler(this.TrocarSenha_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txUsuario;
        private System.Windows.Forms.TextBox txSenha1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txSenha2;
        private System.Windows.Forms.Button btTrocaSenha;
        private System.Windows.Forms.Button btVoltar;
    }
}