namespace Loja_da_Cris
{
    partial class RelatorioVendedor
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioVendedor));
            this.vendedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lojaDaCrisDataSetNovo = new Loja_da_Cris.LojaDaCrisDataSetNovo();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipoRel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btLimparComissao = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btGerRel = new System.Windows.Forms.Button();
            this.vendedorTableAdapter = new Loja_da_Cris.LojaDaCrisDataSetNovoTableAdapters.VendedorTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.vendedorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lojaDaCrisDataSetNovo1 = new Loja_da_Cris.LojaDaCrisDataSetNovo();
            ((System.ComponentModel.ISupportInitialize)(this.vendedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDaCrisDataSetNovo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDaCrisDataSetNovo1)).BeginInit();
            this.SuspendLayout();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 34);
            this.label2.TabIndex = 40;
            this.label2.Text = "Selecione o nome de usuário do \r\nvendedor:";
            this.label2.Visible = false;
            // 
            // cbTipoRel
            // 
            this.cbTipoRel.FormattingEnabled = true;
            this.cbTipoRel.Items.AddRange(new object[] {
            "Vendedor",
            "Maiores Comissões"});
            this.cbTipoRel.Location = new System.Drawing.Point(15, 54);
            this.cbTipoRel.Name = "cbTipoRel";
            this.cbTipoRel.Size = new System.Drawing.Size(121, 21);
            this.cbTipoRel.TabIndex = 39;
            this.cbTipoRel.SelectedValueChanged += new System.EventHandler(this.cbTipoRel_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Filtrar por:";
            // 
            // btLimparComissao
            // 
            this.btLimparComissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimparComissao.Location = new System.Drawing.Point(671, 28);
            this.btLimparComissao.Name = "btLimparComissao";
            this.btLimparComissao.Size = new System.Drawing.Size(108, 47);
            this.btLimparComissao.TabIndex = 41;
            this.btLimparComissao.Text = "Limpar Comissão";
            this.btLimparComissao.UseVisualStyleBackColor = true;
            this.btLimparComissao.Click += new System.EventHandler(this.btLimparComissao_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetVendedor";
            reportDataSource1.Value = this.vendedorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Loja_da_Cris.ReportVendedor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 94);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(795, 355);
            this.reportViewer1.TabIndex = 42;
            // 
            // btGerRel
            // 
            this.btGerRel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGerRel.Image = global::Loja_da_Cris.Properties.Resources.criar_relatorio;
            this.btGerRel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btGerRel.Location = new System.Drawing.Point(419, 18);
            this.btGerRel.Name = "btGerRel";
            this.btGerRel.Size = new System.Drawing.Size(122, 59);
            this.btGerRel.TabIndex = 38;
            this.btGerRel.Text = "Emitir Relatório";
            this.btGerRel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btGerRel.UseVisualStyleBackColor = true;
            this.btGerRel.Click += new System.EventHandler(this.btGerRel_Click);
            // 
            // vendedorTableAdapter
            // 
            this.vendedorTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.vendedorBindingSource1;
            this.comboBox1.DisplayMember = "Usuario";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(166, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 21);
            this.comboBox1.TabIndex = 43;
            this.comboBox1.ValueMember = "Usuario";
            this.comboBox1.Visible = false;
            // 
            // vendedorBindingSource1
            // 
            this.vendedorBindingSource1.DataMember = "Vendedor";
            this.vendedorBindingSource1.DataSource = this.lojaDaCrisDataSetNovo1;
            // 
            // lojaDaCrisDataSetNovo1
            // 
            this.lojaDaCrisDataSetNovo1.DataSetName = "LojaDaCrisDataSetNovo";
            this.lojaDaCrisDataSetNovo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RelatorioVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btLimparComissao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTipoRel);
            this.Controls.Add(this.btGerRel);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RelatorioVendedor";
            this.Text = "RelatorioVendedor";
            this.Load += new System.EventHandler(this.RelatorioVendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDaCrisDataSetNovo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDaCrisDataSetNovo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTipoRel;
        private System.Windows.Forms.Button btGerRel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btLimparComissao;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private LojaDaCrisDataSetNovo lojaDaCrisDataSetNovo;
        private System.Windows.Forms.BindingSource vendedorBindingSource;
        private LojaDaCrisDataSetNovoTableAdapters.VendedorTableAdapter vendedorTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private LojaDaCrisDataSetNovo lojaDaCrisDataSetNovo1;
        private System.Windows.Forms.BindingSource vendedorBindingSource1;
    }
}