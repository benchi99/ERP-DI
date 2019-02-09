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
            this.VentasTableAdapter = new ERP.FacturasTableAdapters.VentasTableAdapter();
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
            this.reportViewer1.Location = new System.Drawing.Point(24, 121);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1023, 493);
            this.reportViewer1.TabIndex = 0;
            // 
            // InvoicesTableAdapter
            // 
            this.InvoicesTableAdapter.ClearBeforeFill = true;
            // 
            // filterCBX
            // 
            this.filterCBX.FormattingEnabled = true;
            this.filterCBX.ItemHeight = 24;
            this.filterCBX.Location = new System.Drawing.Point(119, 79);
            this.filterCBX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterCBX.Name = "filterCBX";
            this.filterCBX.Size = new System.Drawing.Size(121, 30);
            this.filterCBX.TabIndex = 1;
            this.filterCBX.UseSelectable = true;
            this.filterCBX.SelectedIndexChanged += new System.EventHandler(this.filterCBX_SelectedIndexChanged);
            // 
            // filterLb
            // 
            this.filterLb.AutoSize = true;
            this.filterLb.Location = new System.Drawing.Point(24, 85);
            this.filterLb.Name = "filterLb";
            this.filterLb.Size = new System.Drawing.Size(68, 20);
            this.filterLb.TabIndex = 2;
            this.filterLb.Text = "Filtrar por";
            // 
            // VentasTableAdapter
            // 
            this.VentasTableAdapter.ClearBeforeFill = true;
            // 
            // Visor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 638);
            this.Controls.Add(this.filterLb);
            this.Controls.Add(this.filterCBX);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Visor";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
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
        private FacturasTableAdapters.VentasTableAdapter VentasTableAdapter;
    }
}