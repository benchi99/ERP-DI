namespace ERP
{
    partial class Visor
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
            this.InvoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Facturas = new ERP.Facturas();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.InvoicesTableAdapter = new ERP.FacturasTableAdapters.InvoicesTableAdapter();
            this.filterCBX = new MetroFramework.Controls.MetroComboBox();
            this.filterLb = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.InvoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Facturas)).BeginInit();
            this.SuspendLayout();
            // 
            // InvoicesBindingSource
            // 
            this.InvoicesBindingSource.DataMember = "Invoices";
            this.InvoicesBindingSource.DataSource = this.Facturas;
            // 
            // Facturas
            // 
            this.Facturas.DataSetName = "Facturas";
            this.Facturas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Facturas";
            reportDataSource1.Value = this.InvoicesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ERP.Facturas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(18, 98);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(768, 401);
            this.reportViewer1.TabIndex = 0;
            // 
            // InvoicesTableAdapter
            // 
            this.InvoicesTableAdapter.ClearBeforeFill = true;
            // 
            // filterCBX
            // 
            this.filterCBX.FormattingEnabled = true;
            this.filterCBX.ItemHeight = 23;
            this.filterCBX.Location = new System.Drawing.Point(89, 64);
            this.filterCBX.Margin = new System.Windows.Forms.Padding(2);
            this.filterCBX.Name = "filterCBX";
            this.filterCBX.Size = new System.Drawing.Size(92, 29);
            this.filterCBX.TabIndex = 1;
            this.filterCBX.UseSelectable = true;
            this.filterCBX.SelectedIndexChanged += new System.EventHandler(this.filterCBX_SelectedIndexChanged);
            // 
            // filterLb
            // 
            this.filterLb.AutoSize = true;
            this.filterLb.Location = new System.Drawing.Point(18, 69);
            this.filterLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.filterLb.Name = "filterLb";
            this.filterLb.Size = new System.Drawing.Size(68, 19);
            this.filterLb.TabIndex = 2;
            this.filterLb.Text = "Filtrar por";
            // 
            // Visor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 518);
            this.Controls.Add(this.filterLb);
            this.Controls.Add(this.filterCBX);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Visor";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "Visor";
            this.Load += new System.EventHandler(this.Visor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InvoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Facturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource InvoicesBindingSource;
        private Facturas Facturas;
        private FacturasTableAdapters.InvoicesTableAdapter InvoicesTableAdapter;
        private MetroFramework.Controls.MetroComboBox filterCBX;
        private MetroFramework.Controls.MetroLabel filterLb;
    }
}