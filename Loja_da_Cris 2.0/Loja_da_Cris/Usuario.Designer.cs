namespace Loja_da_Cris
{
    partial class Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chbIsAdm = new System.Windows.Forms.CheckBox();
            this.txUsuario = new System.Windows.Forms.TextBox();
            this.txSenha1 = new System.Windows.Forms.TextBox();
            this.txSenha2 = new System.Windows.Forms.TextBox();
            this.btAdcCliente = new System.Windows.Forms.Button();
            this.btEdtCliente = new System.Windows.Forms.Button();
            this.btExcCliente = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vendedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lojaDaCrisDataSetNovo = new Loja_da_Cris.LojaDaCrisDataSetNovo();
            this.label5 = new System.Windows.Forms.Label();
            this.btConsultar = new System.Windows.Forms.Button();
            this.mtxIDVendedor = new System.Windows.Forms.MaskedTextBox();
            this.clienteTableAdapter = new Loja_da_Cris.LojaDaCrisDataSetNovoTableAdapters.ClienteTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.mtxSalario = new System.Windows.Forms.MaskedTextBox();
            this.mtxComissao = new System.Windows.Forms.MaskedTextBox();
            this.vendedorTableAdapter = new Loja_da_Cris.LojaDaCrisDataSetNovoTableAdapters.VendedorTableAdapter();
            this.cbNome = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDVendedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSADMDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDaCrisDataSetNovo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Vendedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(216, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Confirmar senha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(216, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Senha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Salário:";
            // 
            // chbIsAdm
            // 
            this.chbIsAdm.AutoSize = true;
            this.chbIsAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbIsAdm.Location = new System.Drawing.Point(218, 153);
            this.chbIsAdm.Name = "chbIsAdm";
            this.chbIsAdm.Size = new System.Drawing.Size(114, 21);
            this.chbIsAdm.TabIndex = 7;
            this.chbIsAdm.Text = "Administrador";
            this.chbIsAdm.UseVisualStyleBackColor = true;
            // 
            // txUsuario
            // 
            this.txUsuario.Location = new System.Drawing.Point(16, 113);
            this.txUsuario.Name = "txUsuario";
            this.txUsuario.Size = new System.Drawing.Size(172, 20);
            this.txUsuario.TabIndex = 9;
            // 
            // txSenha1
            // 
            this.txSenha1.Location = new System.Drawing.Point(218, 73);
            this.txSenha1.Name = "txSenha1";
            this.txSenha1.PasswordChar = '*';
            this.txSenha1.Size = new System.Drawing.Size(169, 20);
            this.txSenha1.TabIndex = 10;
            // 
            // txSenha2
            // 
            this.txSenha2.Location = new System.Drawing.Point(219, 114);
            this.txSenha2.Name = "txSenha2";
            this.txSenha2.PasswordChar = '*';
            this.txSenha2.Size = new System.Drawing.Size(169, 20);
            this.txSenha2.TabIndex = 11;
            // 
            // btAdcCliente
            // 
            this.btAdcCliente.BackColor = System.Drawing.Color.LightGreen;
            this.btAdcCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdcCliente.Image = global::Loja_da_Cris.Properties.Resources.adicionar_cliente;
            this.btAdcCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAdcCliente.Location = new System.Drawing.Point(489, 26);
            this.btAdcCliente.Name = "btAdcCliente";
            this.btAdcCliente.Size = new System.Drawing.Size(129, 59);
            this.btAdcCliente.TabIndex = 24;
            this.btAdcCliente.Text = "Adicionar Usuario";
            this.btAdcCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAdcCliente.UseVisualStyleBackColor = false;
            this.btAdcCliente.Click += new System.EventHandler(this.btAdcCliente_Click);
            // 
            // btEdtCliente
            // 
            this.btEdtCliente.BackColor = System.Drawing.Color.LemonChiffon;
            this.btEdtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdtCliente.Image = global::Loja_da_Cris.Properties.Resources.alterar_cliente;
            this.btEdtCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btEdtCliente.Location = new System.Drawing.Point(489, 91);
            this.btEdtCliente.Name = "btEdtCliente";
            this.btEdtCliente.Size = new System.Drawing.Size(129, 59);
            this.btEdtCliente.TabIndex = 25;
            this.btEdtCliente.Text = "Alterar Usuario";
            this.btEdtCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btEdtCliente.UseVisualStyleBackColor = false;
            this.btEdtCliente.Click += new System.EventHandler(this.btEdtCliente_Click);
            // 
            // btExcCliente
            // 
            this.btExcCliente.BackColor = System.Drawing.Color.Salmon;
            this.btExcCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcCliente.Image = global::Loja_da_Cris.Properties.Resources.excluir_cliente;
            this.btExcCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btExcCliente.Location = new System.Drawing.Point(489, 156);
            this.btExcCliente.Name = "btExcCliente";
            this.btExcCliente.Size = new System.Drawing.Size(129, 59);
            this.btExcCliente.TabIndex = 26;
            this.btExcCliente.Text = "Excluir Usuario";
            this.btExcCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btExcCliente.UseVisualStyleBackColor = false;
            this.btExcCliente.Click += new System.EventHandler(this.btExcCliente_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDVendedorDataGridViewTextBoxColumn,
            this.iDClienteDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.comissaoDataGridViewTextBoxColumn,
            this.salarioDataGridViewTextBoxColumn,
            this.iSADMDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.vendedorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(625, 150);
            this.dataGridView1.TabIndex = 27;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Comissão:";
            // 
            // btConsultar
            // 
            this.btConsultar.Location = new System.Drawing.Point(89, 26);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(75, 23);
            this.btConsultar.TabIndex = 30;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // mtxIDVendedor
            // 
            this.mtxIDVendedor.Location = new System.Drawing.Point(16, 29);
            this.mtxIDVendedor.Mask = "00000";
            this.mtxIDVendedor.Name = "mtxIDVendedor";
            this.mtxIDVendedor.Size = new System.Drawing.Size(56, 20);
            this.mtxIDVendedor.TabIndex = 31;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Nome:";
            // 
            // mtxSalario
            // 
            this.mtxSalario.Location = new System.Drawing.Point(16, 153);
            this.mtxSalario.Mask = "000000.00";
            this.mtxSalario.Name = "mtxSalario";
            this.mtxSalario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtxSalario.Size = new System.Drawing.Size(79, 20);
            this.mtxSalario.TabIndex = 34;
            this.mtxSalario.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mtxSalario_MouseUp);
            // 
            // mtxComissao
            // 
            this.mtxComissao.Location = new System.Drawing.Point(16, 192);
            this.mtxComissao.Mask = "00.00";
            this.mtxComissao.Name = "mtxComissao";
            this.mtxComissao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtxComissao.Size = new System.Drawing.Size(43, 20);
            this.mtxComissao.TabIndex = 35;
            this.mtxComissao.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mtxComissao_MouseUp);
            // 
            // vendedorTableAdapter
            // 
            this.vendedorTableAdapter.ClearBeforeFill = true;
            // 
            // cbNome
            // 
            this.cbNome.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clienteBindingSource, "ID_Cliente", true));
            this.cbNome.DataSource = this.clienteBindingSource;
            this.cbNome.DisplayMember = "Nome";
            this.cbNome.FormattingEnabled = true;
            this.cbNome.Location = new System.Drawing.Point(16, 73);
            this.cbNome.Name = "cbNome";
            this.cbNome.Size = new System.Drawing.Size(172, 21);
            this.cbNome.TabIndex = 37;
            this.cbNome.ValueMember = "ID_Cliente";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.lojaDaCrisDataSetNovo;
            // 
            // iDVendedorDataGridViewTextBoxColumn
            // 
            this.iDVendedorDataGridViewTextBoxColumn.DataPropertyName = "ID_Vendedor";
            this.iDVendedorDataGridViewTextBoxColumn.HeaderText = "ID_Vendedor";
            this.iDVendedorDataGridViewTextBoxColumn.Name = "iDVendedorDataGridViewTextBoxColumn";
            this.iDVendedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDVendedorDataGridViewTextBoxColumn.Width = 50;
            // 
            // iDClienteDataGridViewTextBoxColumn
            // 
            this.iDClienteDataGridViewTextBoxColumn.DataPropertyName = "ID_Cliente";
            this.iDClienteDataGridViewTextBoxColumn.HeaderText = "ID_Cliente";
            this.iDClienteDataGridViewTextBoxColumn.Name = "iDClienteDataGridViewTextBoxColumn";
            this.iDClienteDataGridViewTextBoxColumn.Width = 50;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            // 
            // comissaoDataGridViewTextBoxColumn
            // 
            this.comissaoDataGridViewTextBoxColumn.DataPropertyName = "Comissao";
            this.comissaoDataGridViewTextBoxColumn.HeaderText = "Comissao";
            this.comissaoDataGridViewTextBoxColumn.Name = "comissaoDataGridViewTextBoxColumn";
            this.comissaoDataGridViewTextBoxColumn.Width = 50;
            // 
            // salarioDataGridViewTextBoxColumn
            // 
            this.salarioDataGridViewTextBoxColumn.DataPropertyName = "Salario";
            this.salarioDataGridViewTextBoxColumn.HeaderText = "Salario";
            this.salarioDataGridViewTextBoxColumn.Name = "salarioDataGridViewTextBoxColumn";
            this.salarioDataGridViewTextBoxColumn.Width = 80;
            // 
            // iSADMDataGridViewCheckBoxColumn
            // 
            this.iSADMDataGridViewCheckBoxColumn.DataPropertyName = "IS_ADM";
            this.iSADMDataGridViewCheckBoxColumn.HeaderText = "IS_ADM";
            this.iSADMDataGridViewCheckBoxColumn.Name = "iSADMDataGridViewCheckBoxColumn";
            this.iSADMDataGridViewCheckBoxColumn.Width = 50;
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Loja_da_Cris.Properties.Resources.Loja_da_Cris__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(642, 385);
            this.Controls.Add(this.cbNome);
            this.Controls.Add(this.mtxComissao);
            this.Controls.Add(this.mtxSalario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mtxIDVendedor);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btExcCliente);
            this.Controls.Add(this.btEdtCliente);
            this.Controls.Add(this.btAdcCliente);
            this.Controls.Add(this.txSenha2);
            this.Controls.Add(this.txSenha1);
            this.Controls.Add(this.txUsuario);
            this.Controls.Add(this.chbIsAdm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Usuario";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDaCrisDataSetNovo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chbIsAdm;
        private System.Windows.Forms.TextBox txUsuario;
        private System.Windows.Forms.TextBox txSenha1;
        private System.Windows.Forms.TextBox txSenha2;
        private System.Windows.Forms.Button btAdcCliente;
        private System.Windows.Forms.Button btEdtCliente;
        private System.Windows.Forms.Button btExcCliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.MaskedTextBox mtxIDVendedor;
        private LojaDaCrisDataSetNovo lojaDaCrisDataSetNovo;
        private LojaDaCrisDataSetNovoTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtxSalario;
        private System.Windows.Forms.MaskedTextBox mtxComissao;
        private System.Windows.Forms.BindingSource vendedorBindingSource;
        private LojaDaCrisDataSetNovoTableAdapters.VendedorTableAdapter vendedorTableAdapter;
        private System.Windows.Forms.ComboBox cbNome;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDVendedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comissaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn iSADMDataGridViewCheckBoxColumn;
    }
}