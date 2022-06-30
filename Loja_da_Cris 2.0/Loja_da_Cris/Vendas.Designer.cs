namespace Loja_da_Cris
{
    partial class Vendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vendas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbClienteVenda = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lojaDaCrisDataSetNovo = new Loja_da_Cris.LojaDaCrisDataSetNovo();
            this.dtpDataVenda = new System.Windows.Forms.DateTimePicker();
            this.btConsulta = new System.Windows.Forms.Button();
            this.btIncluirVendas = new System.Windows.Forms.Button();
            this.btExcluirVendas = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbPrecoTotal = new System.Windows.Forms.Label();
            this.txQtdVendas = new System.Windows.Forms.GroupBox();
            this.mtxQuantidade = new System.Windows.Forms.MaskedTextBox();
            this.dgvCarrinho = new System.Windows.Forms.DataGridView();
            this.CodigoDeBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoParcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btRemoverVendas = new System.Windows.Forms.Button();
            this.btAdicionarVendas = new System.Windows.Forms.Button();
            this.txPrecoUnit = new System.Windows.Forms.TextBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbQtdProdutosLista = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.produtoTableAdapter = new Loja_da_Cris.LojaDaCrisDataSetNovoTableAdapters.ProdutoTableAdapter();
            this.label11 = new System.Windows.Forms.Label();
            this.txVendedor = new System.Windows.Forms.TextBox();
            this.clienteTableAdapter = new Loja_da_Cris.LojaDaCrisDataSetNovoTableAdapters.ClienteTableAdapter();
            this.mtxIDVenda = new System.Windows.Forms.MaskedTextBox();
            this.pbProduto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDaCrisDataSetNovo)).BeginInit();
            this.txQtdVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Venda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data da venda:";
            // 
            // cbClienteVenda
            // 
            this.cbClienteVenda.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clienteBindingSource, "ID_Cliente", true));
            this.cbClienteVenda.DataSource = this.clienteBindingSource;
            this.cbClienteVenda.DisplayMember = "Nome";
            this.cbClienteVenda.FormattingEnabled = true;
            this.cbClienteVenda.Location = new System.Drawing.Point(15, 71);
            this.cbClienteVenda.Name = "cbClienteVenda";
            this.cbClienteVenda.Size = new System.Drawing.Size(284, 21);
            this.cbClienteVenda.TabIndex = 4;
            this.cbClienteVenda.ValueMember = "ID_Cliente";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.lojaDaCrisDataSetNovo;
            // 
            // lojaDaCrisDataSetNovo
            // 
            this.lojaDaCrisDataSetNovo.DataSetName = "LojaDaCrisDataSetNovo";
            this.lojaDaCrisDataSetNovo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpDataVenda
            // 
            this.dtpDataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVenda.Location = new System.Drawing.Point(15, 122);
            this.dtpDataVenda.Name = "dtpDataVenda";
            this.dtpDataVenda.Size = new System.Drawing.Size(85, 20);
            this.dtpDataVenda.TabIndex = 5;
            // 
            // btConsulta
            // 
            this.btConsulta.Location = new System.Drawing.Point(136, 27);
            this.btConsulta.Name = "btConsulta";
            this.btConsulta.Size = new System.Drawing.Size(75, 23);
            this.btConsulta.TabIndex = 6;
            this.btConsulta.Text = "Consultar";
            this.btConsulta.UseVisualStyleBackColor = true;
            this.btConsulta.Click += new System.EventHandler(this.btConsulta_Click);
            // 
            // btIncluirVendas
            // 
            this.btIncluirVendas.BackColor = System.Drawing.Color.LightGreen;
            this.btIncluirVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIncluirVendas.Image = global::Loja_da_Cris.Properties.Resources.adicionar_produto;
            this.btIncluirVendas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btIncluirVendas.Location = new System.Drawing.Point(334, 35);
            this.btIncluirVendas.Name = "btIncluirVendas";
            this.btIncluirVendas.Size = new System.Drawing.Size(87, 57);
            this.btIncluirVendas.TabIndex = 7;
            this.btIncluirVendas.Text = "Incluir";
            this.btIncluirVendas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btIncluirVendas.UseVisualStyleBackColor = false;
            this.btIncluirVendas.Click += new System.EventHandler(this.btIncluirVendas_Click);
            // 
            // btExcluirVendas
            // 
            this.btExcluirVendas.BackColor = System.Drawing.Color.Salmon;
            this.btExcluirVendas.Location = new System.Drawing.Point(334, 118);
            this.btExcluirVendas.Name = "btExcluirVendas";
            this.btExcluirVendas.Size = new System.Drawing.Size(87, 27);
            this.btExcluirVendas.TabIndex = 9;
            this.btExcluirVendas.Text = "Excluir";
            this.btExcluirVendas.UseVisualStyleBackColor = false;
            this.btExcluirVendas.Click += new System.EventHandler(this.btExcluirVendas_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Preço total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(94, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "R$";
            // 
            // lbPrecoTotal
            // 
            this.lbPrecoTotal.AutoSize = true;
            this.lbPrecoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecoTotal.Location = new System.Drawing.Point(139, 165);
            this.lbPrecoTotal.Name = "lbPrecoTotal";
            this.lbPrecoTotal.Size = new System.Drawing.Size(29, 31);
            this.lbPrecoTotal.TabIndex = 12;
            this.lbPrecoTotal.Text = "0";
            // 
            // txQtdVendas
            // 
            this.txQtdVendas.Controls.Add(this.mtxQuantidade);
            this.txQtdVendas.Controls.Add(this.dgvCarrinho);
            this.txQtdVendas.Controls.Add(this.btRemoverVendas);
            this.txQtdVendas.Controls.Add(this.btAdicionarVendas);
            this.txQtdVendas.Controls.Add(this.txPrecoUnit);
            this.txQtdVendas.Controls.Add(this.lbQtdProdutosLista);
            this.txQtdVendas.Controls.Add(this.label10);
            this.txQtdVendas.Controls.Add(this.label9);
            this.txQtdVendas.Controls.Add(this.label8);
            this.txQtdVendas.Controls.Add(this.cbProduto);
            this.txQtdVendas.Controls.Add(this.label7);
            this.txQtdVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txQtdVendas.Location = new System.Drawing.Point(12, 211);
            this.txQtdVendas.Name = "txQtdVendas";
            this.txQtdVendas.Size = new System.Drawing.Size(776, 309);
            this.txQtdVendas.TabIndex = 13;
            this.txQtdVendas.TabStop = false;
            this.txQtdVendas.Text = "Carrinho";
            // 
            // mtxQuantidade
            // 
            this.mtxQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxQuantidade.Location = new System.Drawing.Point(489, 49);
            this.mtxQuantidade.Mask = "000";
            this.mtxQuantidade.Name = "mtxQuantidade";
            this.mtxQuantidade.Size = new System.Drawing.Size(37, 26);
            this.mtxQuantidade.TabIndex = 12;
            // 
            // dgvCarrinho
            // 
            this.dgvCarrinho.AllowUserToAddRows = false;
            this.dgvCarrinho.AllowUserToDeleteRows = false;
            this.dgvCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrinho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoDeBarras,
            this.Descricao,
            this.PrecoUnit,
            this.Qtd,
            this.PrecoParcial});
            this.dgvCarrinho.Location = new System.Drawing.Point(1, 136);
            this.dgvCarrinho.Name = "dgvCarrinho";
            this.dgvCarrinho.ReadOnly = true;
            this.dgvCarrinho.Size = new System.Drawing.Size(760, 208);
            this.dgvCarrinho.TabIndex = 11;
            this.dgvCarrinho.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCarrinho_CellMouseClick);
            // 
            // CodigoDeBarras
            // 
            this.CodigoDeBarras.HeaderText = "Código ";
            this.CodigoDeBarras.Name = "CodigoDeBarras";
            this.CodigoDeBarras.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 300;
            // 
            // PrecoUnit
            // 
            this.PrecoUnit.HeaderText = "PrecoUnit";
            this.PrecoUnit.Name = "PrecoUnit";
            this.PrecoUnit.ReadOnly = true;
            // 
            // Qtd
            // 
            this.Qtd.HeaderText = "Qtd";
            this.Qtd.Name = "Qtd";
            this.Qtd.ReadOnly = true;
            this.Qtd.Width = 30;
            // 
            // PrecoParcial
            // 
            this.PrecoParcial.HeaderText = "PrecoParcial";
            this.PrecoParcial.Name = "PrecoParcial";
            this.PrecoParcial.ReadOnly = true;
            // 
            // btRemoverVendas
            // 
            this.btRemoverVendas.Location = new System.Drawing.Point(153, 76);
            this.btRemoverVendas.Name = "btRemoverVendas";
            this.btRemoverVendas.Size = new System.Drawing.Size(88, 42);
            this.btRemoverVendas.TabIndex = 9;
            this.btRemoverVendas.Text = "Remover";
            this.btRemoverVendas.UseVisualStyleBackColor = true;
            this.btRemoverVendas.Click += new System.EventHandler(this.btRemoverVendas_Click);
            // 
            // btAdicionarVendas
            // 
            this.btAdicionarVendas.Location = new System.Drawing.Point(40, 76);
            this.btAdicionarVendas.Name = "btAdicionarVendas";
            this.btAdicionarVendas.Size = new System.Drawing.Size(88, 42);
            this.btAdicionarVendas.TabIndex = 8;
            this.btAdicionarVendas.Text = "Adicionar";
            this.btAdicionarVendas.UseVisualStyleBackColor = true;
            this.btAdicionarVendas.Click += new System.EventHandler(this.btAdicionarVendas_Click);
            // 
            // txPrecoUnit
            // 
            this.txPrecoUnit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "PrecoUnit", true));
            this.txPrecoUnit.Enabled = false;
            this.txPrecoUnit.Location = new System.Drawing.Point(371, 49);
            this.txPrecoUnit.Name = "txPrecoUnit";
            this.txPrecoUnit.Size = new System.Drawing.Size(100, 23);
            this.txPrecoUnit.TabIndex = 6;
            this.txPrecoUnit.TextChanged += new System.EventHandler(this.txPrecoUnit_TextChanged);
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.lojaDaCrisDataSetNovo;
            // 
            // lbQtdProdutosLista
            // 
            this.lbQtdProdutosLista.AutoSize = true;
            this.lbQtdProdutosLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQtdProdutosLista.Location = new System.Drawing.Point(660, 49);
            this.lbQtdProdutosLista.Name = "lbQtdProdutosLista";
            this.lbQtdProdutosLista.Size = new System.Drawing.Size(29, 31);
            this.lbQtdProdutosLista.TabIndex = 5;
            this.lbQtdProdutosLista.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(619, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Itens no carrinho:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(486, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Quantidade:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(368, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Preço unitário:";
            // 
            // cbProduto
            // 
            this.cbProduto.DataSource = this.produtoBindingSource;
            this.cbProduto.DisplayMember = "NomeProduto";
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(10, 49);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(275, 24);
            this.cbProduto.TabIndex = 1;
            this.cbProduto.ValueMember = "CodigoDeBarras";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Produto:";
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(133, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "Vendedor:";
            // 
            // txVendedor
            // 
            this.txVendedor.Enabled = false;
            this.txVendedor.Location = new System.Drawing.Point(136, 122);
            this.txVendedor.Name = "txVendedor";
            this.txVendedor.Size = new System.Drawing.Size(164, 20);
            this.txVendedor.TabIndex = 15;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // mtxIDVenda
            // 
            this.mtxIDVenda.Location = new System.Drawing.Point(15, 29);
            this.mtxIDVenda.Mask = "00000";
            this.mtxIDVenda.Name = "mtxIDVenda";
            this.mtxIDVenda.Size = new System.Drawing.Size(100, 20);
            this.mtxIDVenda.TabIndex = 16;
            // 
            // pbProduto
            // 
            this.pbProduto.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.produtoBindingSource, "Imagem", true));
            this.pbProduto.Location = new System.Drawing.Point(448, 13);
            this.pbProduto.Name = "pbProduto";
            this.pbProduto.Size = new System.Drawing.Size(328, 192);
            this.pbProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProduto.TabIndex = 17;
            this.pbProduto.TabStop = false;
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Loja_da_Cris.Properties.Resources.Loja_da_Cris__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.pbProduto);
            this.Controls.Add(this.mtxIDVenda);
            this.Controls.Add(this.txVendedor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txQtdVendas);
            this.Controls.Add(this.lbPrecoTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btExcluirVendas);
            this.Controls.Add(this.btIncluirVendas);
            this.Controls.Add(this.btConsulta);
            this.Controls.Add(this.dtpDataVenda);
            this.Controls.Add(this.cbClienteVenda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vendas";
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.Vendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDaCrisDataSetNovo)).EndInit();
            this.txQtdVendas.ResumeLayout(false);
            this.txQtdVendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbClienteVenda;
        private System.Windows.Forms.DateTimePicker dtpDataVenda;
        private System.Windows.Forms.Button btConsulta;
        private System.Windows.Forms.Button btIncluirVendas;
        private System.Windows.Forms.Button btExcluirVendas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbPrecoTotal;
        private System.Windows.Forms.GroupBox txQtdVendas;
        private System.Windows.Forms.Button btRemoverVendas;
        private System.Windows.Forms.Button btAdicionarVendas;
        private System.Windows.Forms.TextBox txPrecoUnit;
        private System.Windows.Forms.Label lbQtdProdutosLista;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbProduto;
        private System.Windows.Forms.Label label7;
        private LojaDaCrisDataSetNovo lojaDaCrisDataSetNovo;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private LojaDaCrisDataSetNovoTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txVendedor;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private LojaDaCrisDataSetNovoTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.MaskedTextBox mtxIDVenda;
        private System.Windows.Forms.DataGridView dgvCarrinho;
        private System.Windows.Forms.MaskedTextBox mtxQuantidade;
        private System.Windows.Forms.PictureBox pbProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDeBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoParcial;
    }
}