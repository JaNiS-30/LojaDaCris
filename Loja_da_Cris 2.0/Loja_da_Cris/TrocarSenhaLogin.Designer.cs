namespace Loja_da_Cris
{
    partial class TrocarSenhaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrocarSenhaLogin));
            this.btTrocaSenha = new System.Windows.Forms.Button();
            this.txSenha2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txSenha1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txSenhaAntiga = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btTrocaSenha
            // 
            this.btTrocaSenha.BackColor = System.Drawing.Color.White;
            this.btTrocaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTrocaSenha.Location = new System.Drawing.Point(121, 222);
            this.btTrocaSenha.Name = "btTrocaSenha";
            this.btTrocaSenha.Size = new System.Drawing.Size(122, 36);
            this.btTrocaSenha.TabIndex = 14;
            this.btTrocaSenha.Text = "Trocar Senha";
            this.btTrocaSenha.UseVisualStyleBackColor = false;
            this.btTrocaSenha.Click += new System.EventHandler(this.btTrocaSenha_Click);
            // 
            // txSenha2
            // 
            this.txSenha2.Location = new System.Drawing.Point(103, 188);
            this.txSenha2.Name = "txSenha2";
            this.txSenha2.PasswordChar = '*';
            this.txSenha2.Size = new System.Drawing.Size(163, 20);
            this.txSenha2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Confirmar senha:";
            // 
            // txSenha1
            // 
            this.txSenha1.Location = new System.Drawing.Point(103, 136);
            this.txSenha1.Name = "txSenha1";
            this.txSenha1.PasswordChar = '*';
            this.txSenha1.Size = new System.Drawing.Size(163, 20);
            this.txSenha1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nova senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Usuário:";
            // 
            // txSenhaAntiga
            // 
            this.txSenhaAntiga.Location = new System.Drawing.Point(103, 82);
            this.txSenhaAntiga.Name = "txSenhaAntiga";
            this.txSenhaAntiga.PasswordChar = '*';
            this.txSenhaAntiga.Size = new System.Drawing.Size(163, 20);
            this.txSenhaAntiga.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Senha antiga:";
            // 
            // txUsuario
            // 
            this.txUsuario.Location = new System.Drawing.Point(103, 30);
            this.txUsuario.Name = "txUsuario";
            this.txUsuario.ReadOnly = true;
            this.txUsuario.Size = new System.Drawing.Size(163, 20);
            this.txUsuario.TabIndex = 18;
            // 
            // TrocarSenhaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Loja_da_Cris.Properties.Resources.Loja_da_Cris__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(359, 450);
            this.Controls.Add(this.txUsuario);
            this.Controls.Add(this.txSenhaAntiga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btTrocaSenha);
            this.Controls.Add(this.txSenha2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txSenha1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrocarSenhaLogin";
            this.Text = "TrocarSenhaLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btTrocaSenha;
        private System.Windows.Forms.TextBox txSenha2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txSenha1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txSenhaAntiga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txUsuario;
    }
}