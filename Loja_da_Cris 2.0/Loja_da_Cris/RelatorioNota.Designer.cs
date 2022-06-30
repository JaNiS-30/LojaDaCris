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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioNota));
            this.dataTable4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lojaDaCrisDataSetNovo = new Loja_da_Cris.LojaDaCrisDataSetNovo();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataTable4TableAdapter = new Loja_da_Cris.LojaDaCrisDataSetNovoTableAdapters.DataTable4TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDaCrisDataSetNovo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable4BindingSource
            // 
            this.dataTable4BindingSource.DataMember = "DataTable4";
            this.dataTable4BindingSource.DataSource = this.lojaDaCrisDataSetNovo;
            // 
            // lojaDaCrisDataSetNovo
            // 
            this.lojaDaCrisDataSetNovo.DataSetName = "LojaDaCrisDataSetNovo";
            this.lojaDaCrisDataSetNovo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataTable4BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Loja_da_Cris.ReportNota.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(4, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(793, 449);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataTable4TableAdapter
            // 
            this.dataTable4TableAdapter.ClearBeforeFill = true;
            // 
            // RelatorioNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RelatorioNota";
            this.Text = "RelatorioNota";
            this.Load += new System.EventHandler(this.RelatorioNota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDaCrisDataSetNovo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private LojaDaCrisDataSetNovo lojaDaCrisDataSetNovo;
        private System.Windows.Forms.BindingSource dataTable4BindingSource;
        private LojaDaCrisDataSetNovoTableAdapters.DataTable4TableAdapter dataTable4TableAdapter;
    }
}