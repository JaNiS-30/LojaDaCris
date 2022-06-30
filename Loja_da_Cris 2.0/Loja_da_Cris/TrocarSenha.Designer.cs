
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrocarSenha));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txSenha1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txSenha2 = new System.Windows.Forms.TextBox();
            this.btTrocaSenha = new System.Windows.Forms.Button();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.vendedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lojaDaCrisDataSetNovo = new Loja_da_Cris.LojaDaCrisDataSetNovo();
            this.clienteTableAdapter = new Loja_da_Cris.LojaDaCrisDataSetNovoTableAdapters.ClienteTableAdapter();
            this.vendedorTableAdapter = new Loja_da_Cris.LojaDaCrisDataSetNovoTableAdapters.VendedorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vendedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDaCrisDataSetNovo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha:";
            // 
            // txSenha1
            // 
            this.txSenha1.Location = new System.Drawing.Point(96, 102);
            this.txSenha1.Name = "txSenha1";
            this.txSenha1.PasswordChar = '*';
            this.txSenha1.Size = new System.Drawing.Size(163, 20);
            this.txSenha1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirmar senha:";
            // 
            // txSenha2
            // 
            this.txSenha2.Location = new System.Drawing.Point(96, 154);
            this.txSenha2.Name = "txSenha2";
            this.txSenha2.PasswordChar = '*';
            this.txSenha2.Size = new System.Drawing.Size(163, 20);
            this.txSenha2.TabIndex = 6;
            // 
            // btTrocaSenha
            // 
            this.btTrocaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTrocaSenha.Location = new System.Drawing.Point(111, 191);
            this.btTrocaSenha.Name = "btTrocaSenha";
            this.btTrocaSenha.Size = new System.Drawing.Size(122, 36);
            this.btTrocaSenha.TabIndex = 7;
            this.btTrocaSenha.Text = "Trocar Senha";
            this.btTrocaSenha.UseVisualStyleBackColor = true;
            this.btTrocaSenha.Click += new System.EventHandler(this.btTrocaSenha_Click);
            this.btTrocaSenha.MouseHover += new System.EventHandler(this.btTrocaSenha_MouseHover);
            // 
            // cbUsuario
            // 
            this.cbUsuario.DataSource = this.vendedorBindingSource;
            this.cbUsuario.DisplayMember = "Usuario";
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(96, 49);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(163, 21);
            this.cbUsuario.TabIndex = 8;
            this.cbUsuario.ValueMember = "Usuario";
            // 
            // vendedorBindingSource
            // 
            this.vendedorBindingSource.DataMember = "Vendedor";
            this.vendedorBindingSource.DataSource = this.lojaDaCrisDataSetNovo;
            // 
            // lojaDaCrisDataSetNovo
            // 
            this.lojaDaCrisDataSetNovo.DataSetName = "LojaDaCrisDataSetNovo";
            this.lojaDaCrisDataSetNovo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // vendedorTableAdapter
            // 
            this.vendedorTableAdapter.ClearBeforeFill = true;
            // 
            // TrocarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Loja_da_Cris.Properties.Resources.Loja_da_Cris__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(360, 450);
            this.Controls.Add(this.cbUsuario);
            this.Controls.Add(this.btTrocaSenha);
            this.Controls.Add(this.txSenha2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txSenha1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrocarSenha";
            this.Text = "Trocar Senha";
            this.Load += new System.EventHandler(this.TrocarSenha_Load);
            this.MouseHover += new System.EventHandler(this.TrocarSenha_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.vendedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDaCrisDataSetNovo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txSenha1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txSenha2;
        private System.Windows.Forms.Button btTrocaSenha;
        private System.Windows.Forms.ComboBox cbUsuario;
        private LojaDaCrisDataSetNovo lojaDaCrisDataSetNovo;
        private LojaDaCrisDataSetNovoTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource vendedorBindingSource;
        private LojaDaCrisDataSetNovoTableAdapters.VendedorTableAdapter vendedorTableAdapter;
    }
}