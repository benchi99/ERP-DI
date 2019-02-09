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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.InvoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Facturas = new ERP.Informes();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.InvoicesTableAdapter = new ERP.FacturasTableAdapters.InvoicesTableAdapter();
            this.idCBX = new MetroFramework.Controls.MetroComboBox();
            this.filterLb = new MetroFramework.Controls.MetroLabel();
            this.f = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.InvoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Facturas)).BeginInit();
            this.SuspendLayout();
            // 
            // InvoicesBindingSource
            // 
            this.InvoicesBindingSource.DataMember = "Invoices";
            this.InvoicesBindingSource.DataSource = this.Facturas;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            reportDataSource2.Name = "Facturas";
            reportDataSource2.Value = this.InvoicesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
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
            // idCBX
            // 
            this.idCBX.FormattingEnabled = true;
            this.idCBX.ItemHeight = 23;
            this.idCBX.Location = new System.Drawing.Point(337, 64);
            this.idCBX.Margin = new System.Windows.Forms.Padding(2);
            this.idCBX.Name = "idCBX";
            this.idCBX.Size = new System.Drawing.Size(111, 29);
            this.idCBX.TabIndex = 1;
            this.idCBX.UseSelectable = true;
            this.idCBX.SelectedIndexChanged += new System.EventHandler(this.idCBX_SelectedIndexChanged);
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
            // f
            // 
            this.f.FormattingEnabled = true;
            this.f.ItemHeight = 23;
            this.f.Items.AddRange(new object[] {
            "ID de Factura",
            "Cliente"});
            this.f.Location = new System.Drawing.Point(91, 64);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(121, 29);
            this.f.TabIndex = 3;
            this.f.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(218, 69);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(114, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Seleccione factura";
            // 
            // Visor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 518);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.f);
            this.Controls.Add(this.filterLb);
            this.Controls.Add(this.idCBX);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Visor";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "Visor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Visor_FormClosing);
            this.Load += new System.EventHandler(this.Visor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InvoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Facturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource InvoicesBindingSource;
        private Informes Facturas;
        private FacturasTableAdapters.InvoicesTableAdapter InvoicesTableAdapter;
        private MetroFramework.Controls.MetroComboBox idCBX;
        private MetroFramework.Controls.MetroLabel filterLb;
        private MetroFramework.Controls.MetroComboBox f;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}