
namespace Loja_da_Cris
{
    partial class RelatorioNota
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
            this.NotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LojaDaCrisDataSet = new Loja_da_Cris.LojaDaCrisDataSet();
            this.ProdutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProdutosTableAdapter = new Loja_da_Cris.LojaDaCrisDataSetTableAdapters.ProdutosTableAdapter();
            this.NotasTableAdapter = new Loja_da_Cris.LojaDaCrisDataSetTableAdapters.NotasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.NotasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LojaDaCrisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NotasBindingSource
            // 
            this.NotasBindingSource.DataMember = "Notas";
            this.NotasBindingSource.DataSource = this.LojaDaCrisDataSet;
            // 
            // LojaDaCrisDataSet
            // 
            this.LojaDaCrisDataSet.DataSetName = "LojaDaCrisDataSet";
            this.LojaDaCrisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProdutosBindingSource
            // 
            this.ProdutosBindingSource.DataMember = "Produtos";
            this.ProdutosBindingSource.DataSource = this.LojaDaCrisDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackgroundImage = global::Loja_da_Cris.Properties.Resources.Loja_da_Cris__1_;
            this.reportViewer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetNotas";
            reportDataSource1.Value = this.NotasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Loja_da_Cris.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ProdutosTableAdapter
            // 
            this.ProdutosTableAdapter.ClearBeforeFill = true;
            // 
            // NotasTableAdapter
            // 
            this.NotasTableAdapter.ClearBeforeFill = true;
            // 
            // RelatorioNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelatorioNota";
            this.Text = "RelatorioNota";
            this.Load += new System.EventHandler(this.RelatorioNota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NotasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LojaDaCrisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProdutosBindingSource;
        private LojaDaCrisDataSet LojaDaCrisDataSet;
        private LojaDaCrisDataSetTableAdapters.ProdutosTableAdapter ProdutosTableAdapter;
        private System.Windows.Forms.BindingSource NotasBindingSource;
        private LojaDaCrisDataSetTableAdapters.NotasTableAdapter NotasTableAdapter;
    }
}