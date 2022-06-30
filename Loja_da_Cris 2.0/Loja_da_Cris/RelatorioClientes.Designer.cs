namespace Loja_da_Cris
{
    partial class RelatorioClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioClientes));
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lojaDaCrisDataSetNovo = new Loja_da_Cris.LojaDaCrisDataSetNovo();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipoRel = new System.Windows.Forms.ComboBox();
            this.btGerRel = new System.Windows.Forms.Button();
            this.txInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.clienteTableAdapter = new Loja_da_Cris.LojaDaCrisDataSetNovoTableAdapters.ClienteTableAdapter();
            this.mtxCPF = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDaCrisDataSetNovo)).BeginInit();
            this.SuspendLayout();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Digite o nome ou o CPF\r\n";
            // 
            // cbTipoRel
            // 
            this.cbTipoRel.FormattingEnabled = true;
            this.cbTipoRel.Items.AddRange(new object[] {
            "Nome",
            "CPF"});
            this.cbTipoRel.Location = new System.Drawing.Point(13, 49);
            this.cbTipoRel.Name = "cbTipoRel";
            this.cbTipoRel.Size = new System.Drawing.Size(121, 21);
            this.cbTipoRel.TabIndex = 34;
            this.cbTipoRel.SelectedValueChanged += new System.EventHandler(this.cbTipoRel_SelectedValueChanged);
            // 
            // btGerRel
            // 
            this.btGerRel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGerRel.Image = global::Loja_da_Cris.Properties.Resources.criar_relatorio;
            this.btGerRel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btGerRel.Location = new System.Drawing.Point(417, 13);
            this.btGerRel.Name = "btGerRel";
            this.btGerRel.Size = new System.Drawing.Size(122, 59);
            this.btGerRel.TabIndex = 33;
            this.btGerRel.Text = "Emitir Relatório";
            this.btGerRel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btGerRel.UseVisualStyleBackColor = true;
            this.btGerRel.Click += new System.EventHandler(this.btGerRel_Click);
            // 
            // txInfo
            // 
            this.txInfo.Location = new System.Drawing.Point(164, 51);
            this.txInfo.Name = "txInfo";
            this.txInfo.Size = new System.Drawing.Size(223, 20);
            this.txInfo.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Filtrar por:";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetCliente";
            reportDataSource1.Value = this.clienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Loja_da_Cris.ReportCliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 77);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(801, 374);
            this.reportViewer1.TabIndex = 36;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // mtxCPF
            // 
            this.mtxCPF.Location = new System.Drawing.Point(164, 50);
            this.mtxCPF.Mask = "000,000,000-00";
            this.mtxCPF.Name = "mtxCPF";
            this.mtxCPF.Size = new System.Drawing.Size(85, 20);
            this.mtxCPF.TabIndex = 39;
            // 
            // RelatorioClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mtxCPF);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTipoRel);
            this.Controls.Add(this.btGerRel);
            this.Controls.Add(this.txInfo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RelatorioClientes";
            this.Text = "RelatorioClientes";
            this.Load += new System.EventHandler(this.RelatorioClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDaCrisDataSetNovo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTipoRel;
        private System.Windows.Forms.Button btGerRel;
        private System.Windows.Forms.TextBox txInfo;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private LojaDaCrisDataSetNovo lojaDaCrisDataSetNovo;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private LojaDaCrisDataSetNovoTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.MaskedTextBox mtxCPF;
    }
}