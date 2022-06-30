
namespace Loja_da_Cris
{
    partial class Produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produtos));
            this.btRelCliente = new System.Windows.Forms.Button();
            this.btAdcProduto = new System.Windows.Forms.Button();
            this.btEdtProduto = new System.Windows.Forms.Button();
            this.btExcProduto = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Data = new System.Windows.Forms.ToolStripStatusLabel();
            this.Hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsData = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoDeBarrasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.margemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lojaDaCrisDataSet = new Loja_da_Cris.LojaDaCrisDataSet();
            this.btConsultarProduto = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            this.txCodigoBarras = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.categoriaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mtxCusto = new System.Windows.Forms.MaskedTextBox();
            this.mtxMargem = new System.Windows.Forms.MaskedTextBox();
            this.mtxVenda = new System.Windows.Forms.MaskedTextBox();
            this.mtxQuantidade = new System.Windows.Forms.MaskedTextBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaTableAdapter = new Loja_da_Cris.LojaDaCrisDataSetTableAdapters.CategoriaTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.produtosTableAdapter = new Loja_da_Cris.LojaDaCrisDataSetTableAdapters.ProdutosTableAdapter();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDaCrisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btRelCliente
            // 
            this.btRelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRelCliente.Image = global::Loja_da_Cris.Properties.Resources.criar_relatorio;
            this.btRelCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btRelCliente.Location = new System.Drawing.Point(643, 24);
            this.btRelCliente.Name = "btRelCliente";
            this.btRelCliente.Size = new System.Drawing.Size(129, 59);
            this.btRelCliente.TabIndex = 29;
            this.btRelCliente.Text = "Emitir Relatório";
            this.btRelCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btRelCliente.UseVisualStyleBackColor = true;
            this.btRelCliente.Click += new System.EventHandler(this.btRelCliente_Click);
            // 
            // btAdcProduto
            // 
            this.btAdcProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdcProduto.Image = global::Loja_da_Cris.Properties.Resources.adicionar_produto;
            this.btAdcProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAdcProduto.Location = new System.Drawing.Point(643, 91);
            this.btAdcProduto.Name = "btAdcProduto";
            this.btAdcProduto.Size = new System.Drawing.Size(129, 59);
            this.btAdcProduto.TabIndex = 28;
            this.btAdcProduto.Text = "Adicionar Produto";
            this.btAdcProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAdcProduto.UseVisualStyleBackColor = true;
            this.btAdcProduto.Click += new System.EventHandler(this.btAdcProduto_Click);
            // 
            // btEdtProduto
            // 
            this.btEdtProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdtProduto.Image = global::Loja_da_Cris.Properties.Resources.alterar_produto;
            this.btEdtProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btEdtProduto.Location = new System.Drawing.Point(643, 158);
            this.btEdtProduto.Name = "btEdtProduto";
            this.btEdtProduto.Size = new System.Drawing.Size(129, 59);
            this.btEdtProduto.TabIndex = 27;
            this.btEdtProduto.Text = "Alterar Produto";
            this.btEdtProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btEdtProduto.UseVisualStyleBackColor = true;
            this.btEdtProduto.Click += new System.EventHandler(this.btEdtProduto_Click);
            // 
            // btExcProduto
            // 
            this.btExcProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcProduto.Image = global::Loja_da_Cris.Properties.Resources.excluir_produto;
            this.btExcProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btExcProduto.Location = new System.Drawing.Point(643, 225);
            this.btExcProduto.Name = "btExcProduto";
            this.btExcProduto.Size = new System.Drawing.Size(129, 59);
            this.btExcProduto.TabIndex = 26;
            this.btExcProduto.Text = "Excluir Produto";
            this.btExcProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btExcProduto.UseVisualStyleBackColor = true;
            this.btExcProduto.Click += new System.EventHandler(this.btExcProduto_Click);
            // 
            // btVoltar
            // 
            this.btVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.Image = global::Loja_da_Cris.Properties.Resources.voltar;
            this.btVoltar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btVoltar.Location = new System.Drawing.Point(15, 23);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(86, 59);
            this.btVoltar.TabIndex = 25;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
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
            this.statusStrip1.TabIndex = 30;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(127, 17);
            this.toolStripStatusLabel1.Text = "Produtos - Loja da Cris";
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDeBarrasDataGridViewTextBoxColumn,
            this.nomeProdutoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.custoDataGridViewTextBoxColumn,
            this.margemDataGridViewTextBoxColumn,
            this.vendaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produtosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 295);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(770, 132);
            this.dataGridView1.TabIndex = 65;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // codigoDeBarrasDataGridViewTextBoxColumn
            // 
            this.codigoDeBarrasDataGridViewTextBoxColumn.DataPropertyName = "CodigoDeBarras";
            this.codigoDeBarrasDataGridViewTextBoxColumn.HeaderText = "CodigoDeBarras";
            this.codigoDeBarrasDataGridViewTextBoxColumn.Name = "codigoDeBarrasDataGridViewTextBoxColumn";
            // 
            // nomeProdutoDataGridViewTextBoxColumn
            // 
            this.nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "NomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.HeaderText = "NomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            // 
            // custoDataGridViewTextBoxColumn
            // 
            this.custoDataGridViewTextBoxColumn.DataPropertyName = "Custo";
            this.custoDataGridViewTextBoxColumn.HeaderText = "Custo";
            this.custoDataGridViewTextBoxColumn.Name = "custoDataGridViewTextBoxColumn";
            // 
            // margemDataGridViewTextBoxColumn
            // 
            this.margemDataGridViewTextBoxColumn.DataPropertyName = "Margem";
            this.margemDataGridViewTextBoxColumn.HeaderText = "Margem";
            this.margemDataGridViewTextBoxColumn.Name = "margemDataGridViewTextBoxColumn";
            // 
            // vendaDataGridViewTextBoxColumn
            // 
            this.vendaDataGridViewTextBoxColumn.DataPropertyName = "Venda";
            this.vendaDataGridViewTextBoxColumn.HeaderText = "Venda";
            this.vendaDataGridViewTextBoxColumn.Name = "vendaDataGridViewTextBoxColumn";
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
            this.produtosBindingSource.DataSource = this.lojaDaCrisDataSet;
            // 
            // lojaDaCrisDataSet
            // 
            this.lojaDaCrisDataSet.DataSetName = "LojaDaCrisDataSet";
            this.lojaDaCrisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btConsultarProduto
            // 
            this.btConsultarProduto.Location = new System.Drawing.Point(519, 23);
            this.btConsultarProduto.Name = "btConsultarProduto";
            this.btConsultarProduto.Size = new System.Drawing.Size(75, 23);
            this.btConsultarProduto.TabIndex = 64;
            this.btConsultarProduto.Text = "Consultar";
            this.btConsultarProduto.UseVisualStyleBackColor = true;
            this.btConsultarProduto.Click += new System.EventHandler(this.btConsultarProduto_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(235, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 59;
            this.label9.Text = "Venda:";
            // 
            // txNome
            // 
            this.txNome.Location = new System.Drawing.Point(359, 58);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(272, 20);
            this.txNome.TabIndex = 55;
            // 
            // txCodigoBarras
            // 
            this.txCodigoBarras.Location = new System.Drawing.Point(359, 26);
            this.txCodigoBarras.Name = "txCodigoBarras";
            this.txCodigoBarras.Size = new System.Drawing.Size(151, 20);
            this.txCodigoBarras.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(235, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 51;
            this.label6.Text = "Margem:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(235, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 50;
            this.label5.Text = "Quantidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(235, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 49;
            this.label4.Text = "Custo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 48;
            this.label3.Text = "Categoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(235, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 47;
            this.label2.Text = "Nome do produto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "Código de Barras:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DataSource = this.categoriaBindingSource1;
            this.cbCategoria.DisplayMember = "Categoria";
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(304, 124);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbCategoria.TabIndex = 66;
            // 
            // categoriaBindingSource1
            // 
            this.categoriaBindingSource1.DataMember = "Categoria";
            this.categoriaBindingSource1.DataSource = this.lojaDaCrisDataSet;
            // 
            // mtxCusto
            // 
            this.mtxCusto.Location = new System.Drawing.Point(279, 157);
            this.mtxCusto.Mask = "000.00";
            this.mtxCusto.Name = "mtxCusto";
            this.mtxCusto.Size = new System.Drawing.Size(42, 20);
            this.mtxCusto.TabIndex = 69;
            this.mtxCusto.ValidatingType = typeof(int);
            // 
            // mtxMargem
            // 
            this.mtxMargem.Location = new System.Drawing.Point(295, 190);
            this.mtxMargem.Mask = "00";
            this.mtxMargem.Name = "mtxMargem";
            this.mtxMargem.Size = new System.Drawing.Size(42, 20);
            this.mtxMargem.TabIndex = 70;
            this.mtxMargem.ValidatingType = typeof(int);
            // 
            // mtxVenda
            // 
            this.mtxVenda.Location = new System.Drawing.Point(287, 223);
            this.mtxVenda.Mask = "000.00";
            this.mtxVenda.Name = "mtxVenda";
            this.mtxVenda.Size = new System.Drawing.Size(42, 20);
            this.mtxVenda.TabIndex = 71;
            this.mtxVenda.ValidatingType = typeof(int);
            // 
            // mtxQuantidade
            // 
            this.mtxQuantidade.Location = new System.Drawing.Point(319, 91);
            this.mtxQuantidade.Mask = "00000";
            this.mtxQuantidade.Name = "mtxQuantidade";
            this.mtxQuantidade.Size = new System.Drawing.Size(42, 20);
            this.mtxQuantidade.TabIndex = 72;
            this.mtxQuantidade.ValidatingType = typeof(int);
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.lojaDaCrisDataSet;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(317, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 17);
            this.label7.TabIndex = 73;
            this.label7.Text = "%";
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Loja_da_Cris.Properties.Resources.Loja_da_Cris__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mtxQuantidade);
            this.Controls.Add(this.mtxVenda);
            this.Controls.Add(this.mtxMargem);
            this.Controls.Add(this.mtxCusto);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btConsultarProduto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.txCodigoBarras);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btRelCliente);
            this.Controls.Add(this.btAdcProduto);
            this.Controls.Add(this.btEdtProduto);
            this.Controls.Add(this.btExcProduto);
            this.Controls.Add(this.btVoltar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Produtos";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.Produtos_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDaCrisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btRelCliente;
        private System.Windows.Forms.Button btAdcProduto;
        private System.Windows.Forms.Button btEdtProduto;
        private System.Windows.Forms.Button btExcProduto;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel Data;
        private System.Windows.Forms.ToolStripStatusLabel Hora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tsData;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tsHora;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btConsultarProduto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.TextBox txCodigoBarras;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.MaskedTextBox mtxCusto;
        private System.Windows.Forms.MaskedTextBox mtxMargem;
        private System.Windows.Forms.MaskedTextBox mtxVenda;
        private System.Windows.Forms.MaskedTextBox mtxQuantidade;
        private LojaDaCrisDataSet lojaDaCrisDataSet;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private LojaDaCrisDataSetTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource categoriaBindingSource1;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private LojaDaCrisDataSetTableAdapters.ProdutosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDeBarrasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn margemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendaDataGridViewTextBoxColumn;
    }
}