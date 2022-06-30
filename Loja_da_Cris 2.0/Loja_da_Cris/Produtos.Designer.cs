
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
            this.btAdcProduto = new System.Windows.Forms.Button();
            this.btEdtProduto = new System.Windows.Forms.Button();
            this.btExcProduto = new System.Windows.Forms.Button();
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
            this.imagemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lojaDaCrisDataSetNovo = new Loja_da_Cris.LojaDaCrisDataSetNovo();
            this.lojaDaCrisDataSet = new Loja_da_Cris.LojaDaCrisDataSet();
            this.btConsultarProduto = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            this.txCodigoBarras = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mtxPreco = new System.Windows.Forms.MaskedTextBox();
            this.mtxQuantidade = new System.Windows.Forms.MaskedTextBox();
            this.categoriaTableAdapter = new Loja_da_Cris.LojaDaCrisDataSetTableAdapters.CategoriaTableAdapter();
            this.produtosTableAdapter = new Loja_da_Cris.LojaDaCrisDataSetTableAdapters.ProdutosTableAdapter();
            this.pbImagemProdutos = new System.Windows.Forms.PictureBox();
            this.produtoTableAdapter = new Loja_da_Cris.LojaDaCrisDataSetNovoTableAdapters.ProdutoTableAdapter();
            this.itemVendaTableAdapter = new Loja_da_Cris.LojaDaCrisDataSetNovoTableAdapters.ItemVendaTableAdapter();
            this.categoriaTableAdapter1 = new Loja_da_Cris.LojaDaCrisDataSetNovoTableAdapters.CategoriaTableAdapter();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDaCrisDataSetNovo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDaCrisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // btAdcProduto
            // 
            this.btAdcProduto.BackColor = System.Drawing.Color.LightGreen;
            this.btAdcProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdcProduto.Image = global::Loja_da_Cris.Properties.Resources.adicionar_produto;
            this.btAdcProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAdcProduto.Location = new System.Drawing.Point(635, 44);
            this.btAdcProduto.Name = "btAdcProduto";
            this.btAdcProduto.Size = new System.Drawing.Size(129, 59);
            this.btAdcProduto.TabIndex = 28;
            this.btAdcProduto.Text = "Adicionar Produto";
            this.btAdcProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAdcProduto.UseVisualStyleBackColor = false;
            this.btAdcProduto.Click += new System.EventHandler(this.btAdcProduto_Click);
            // 
            // btEdtProduto
            // 
            this.btEdtProduto.BackColor = System.Drawing.Color.Khaki;
            this.btEdtProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdtProduto.Image = global::Loja_da_Cris.Properties.Resources.alterar_produto;
            this.btEdtProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btEdtProduto.Location = new System.Drawing.Point(635, 111);
            this.btEdtProduto.Name = "btEdtProduto";
            this.btEdtProduto.Size = new System.Drawing.Size(129, 59);
            this.btEdtProduto.TabIndex = 27;
            this.btEdtProduto.Text = "Alterar Produto";
            this.btEdtProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btEdtProduto.UseVisualStyleBackColor = false;
            this.btEdtProduto.Click += new System.EventHandler(this.btEdtProduto_Click);
            // 
            // btExcProduto
            // 
            this.btExcProduto.BackColor = System.Drawing.Color.Salmon;
            this.btExcProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcProduto.Image = global::Loja_da_Cris.Properties.Resources.excluir_produto;
            this.btExcProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btExcProduto.Location = new System.Drawing.Point(635, 178);
            this.btExcProduto.Name = "btExcProduto";
            this.btExcProduto.Size = new System.Drawing.Size(129, 59);
            this.btExcProduto.TabIndex = 26;
            this.btExcProduto.Text = "Excluir Produto";
            this.btExcProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btExcProduto.UseVisualStyleBackColor = false;
            this.btExcProduto.Click += new System.EventHandler(this.btExcProduto_Click);
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
            this.imagemDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.precoUnitDataGridViewTextBoxColumn,
            this.iDCategoriaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produtoBindingSource;
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
            // imagemDataGridViewTextBoxColumn
            // 
            this.imagemDataGridViewTextBoxColumn.DataPropertyName = "Imagem";
            this.imagemDataGridViewTextBoxColumn.HeaderText = "Imagem";
            this.imagemDataGridViewTextBoxColumn.Name = "imagemDataGridViewTextBoxColumn";
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            // 
            // precoUnitDataGridViewTextBoxColumn
            // 
            this.precoUnitDataGridViewTextBoxColumn.DataPropertyName = "PrecoUnit";
            this.precoUnitDataGridViewTextBoxColumn.HeaderText = "PrecoUnit";
            this.precoUnitDataGridViewTextBoxColumn.Name = "precoUnitDataGridViewTextBoxColumn";
            // 
            // iDCategoriaDataGridViewTextBoxColumn
            // 
            this.iDCategoriaDataGridViewTextBoxColumn.DataPropertyName = "ID_Categoria";
            this.iDCategoriaDataGridViewTextBoxColumn.HeaderText = "ID_Categoria";
            this.iDCategoriaDataGridViewTextBoxColumn.Name = "iDCategoriaDataGridViewTextBoxColumn";
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.lojaDaCrisDataSetNovo;
            // 
            // lojaDaCrisDataSetNovo
            // 
            this.lojaDaCrisDataSetNovo.DataSetName = "LojaDaCrisDataSetNovo";
            this.lojaDaCrisDataSetNovo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lojaDaCrisDataSet
            // 
            this.lojaDaCrisDataSet.DataSetName = "LojaDaCrisDataSet";
            this.lojaDaCrisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btConsultarProduto
            // 
            this.btConsultarProduto.Location = new System.Drawing.Point(172, 27);
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
            this.label9.Location = new System.Drawing.Point(12, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 17);
            this.label9.TabIndex = 59;
            this.label9.Text = "Preço Unitário:";
            // 
            // txNome
            // 
            this.txNome.Location = new System.Drawing.Point(15, 78);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(272, 20);
            this.txNome.TabIndex = 55;
            // 
            // txCodigoBarras
            // 
            this.txCodigoBarras.Location = new System.Drawing.Point(15, 29);
            this.txCodigoBarras.Name = "txCodigoBarras";
            this.txCodigoBarras.Size = new System.Drawing.Size(151, 20);
            this.txCodigoBarras.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(197, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 50;
            this.label5.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 48;
            this.label3.Text = "Categoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 47;
            this.label2.Text = "Nome do produto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "Código de Barras:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoriaBindingSource, "ID_Categoria", true));
            this.cbCategoria.DataSource = this.categoriaBindingSource;
            this.cbCategoria.DisplayMember = "Categoria";
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(15, 129);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(131, 21);
            this.cbCategoria.TabIndex = 66;
            this.cbCategoria.ValueMember = "ID_Categoria";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.lojaDaCrisDataSetNovo;
            // 
            // mtxPreco
            // 
            this.mtxPreco.Location = new System.Drawing.Point(15, 178);
            this.mtxPreco.Mask = "0000.00";
            this.mtxPreco.Name = "mtxPreco";
            this.mtxPreco.Size = new System.Drawing.Size(60, 20);
            this.mtxPreco.TabIndex = 71;
            this.mtxPreco.ValidatingType = typeof(int);
            this.mtxPreco.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mtxPreco_MouseUp);
            // 
            // mtxQuantidade
            // 
            this.mtxQuantidade.Location = new System.Drawing.Point(200, 128);
            this.mtxQuantidade.Mask = "00000";
            this.mtxQuantidade.Name = "mtxQuantidade";
            this.mtxQuantidade.Size = new System.Drawing.Size(87, 20);
            this.mtxQuantidade.TabIndex = 72;
            this.mtxQuantidade.ValidatingType = typeof(int);
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // pbImagemProdutos
            // 
            this.pbImagemProdutos.Image = global::Loja_da_Cris.Properties.Resources.R;
            this.pbImagemProdutos.ImageLocation = "";
            this.pbImagemProdutos.InitialImage = null;
            this.pbImagemProdutos.Location = new System.Drawing.Point(310, 44);
            this.pbImagemProdutos.Name = "pbImagemProdutos";
            this.pbImagemProdutos.Size = new System.Drawing.Size(310, 193);
            this.pbImagemProdutos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagemProdutos.TabIndex = 73;
            this.pbImagemProdutos.TabStop = false;
            this.pbImagemProdutos.Click += new System.EventHandler(this.pbImagemProdutos_Click);
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // itemVendaTableAdapter
            // 
            this.itemVendaTableAdapter.ClearBeforeFill = true;
            // 
            // categoriaTableAdapter1
            // 
            this.categoriaTableAdapter1.ClearBeforeFill = true;
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Loja_da_Cris.Properties.Resources.Loja_da_Cris__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbImagemProdutos);
            this.Controls.Add(this.mtxQuantidade);
            this.Controls.Add(this.mtxPreco);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btConsultarProduto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.txCodigoBarras);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btAdcProduto);
            this.Controls.Add(this.btEdtProduto);
            this.Controls.Add(this.btExcProduto);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Produtos";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.Produtos_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDaCrisDataSetNovo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDaCrisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btAdcProduto;
        private System.Windows.Forms.Button btEdtProduto;
        private System.Windows.Forms.Button btExcProduto;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.MaskedTextBox mtxPreco;
        private System.Windows.Forms.MaskedTextBox mtxQuantidade;
        private LojaDaCrisDataSet lojaDaCrisDataSet;
        private LojaDaCrisDataSetTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private LojaDaCrisDataSetTableAdapters.ProdutosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.PictureBox pbImagemProdutos;
        private LojaDaCrisDataSetNovo lojaDaCrisDataSetNovo;
        private LojaDaCrisDataSetNovoTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private LojaDaCrisDataSetNovoTableAdapters.ItemVendaTableAdapter itemVendaTableAdapter;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private LojaDaCrisDataSetNovoTableAdapters.CategoriaTableAdapter categoriaTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDeBarrasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource produtoBindingSource;
    }
}