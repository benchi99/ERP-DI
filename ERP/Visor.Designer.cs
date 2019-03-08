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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.InvoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Facturas = new ERP.Informes();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.InvoicesTableAdapter = new ERP.FacturasTableAdapters.InvoicesTableAdapter();
            this.idCBX = new MetroFramework.Controls.MetroComboBox();
            this.filterLb = new MetroFramework.Controls.MetroLabel();
            this.VentasTableAdapter = new ERP.FacturasTableAdapters.VentasTableAdapter();
            this.filtrCbx = new MetroFramework.Controls.MetroComboBox();
            this.factIdLbl = new MetroFramework.Controls.MetroLabel();
            this.cliFiltrCBX = new MetroFramework.Controls.MetroComboBox();
            this.cliLbl = new MetroFramework.Controls.MetroLabel();
            this.hastaFchCbx = new MetroFramework.Controls.MetroComboBox();
            this.desdeFchCbx = new MetroFramework.Controls.MetroComboBox();
            this.desdeFchLbl = new MetroFramework.Controls.MetroLabel();
            this.hastaFchLbl = new MetroFramework.Controls.MetroLabel();
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
            reportDataSource3.Name = "Facturas";
            reportDataSource3.Value = this.InvoicesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ERP.Facturas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(18, 98);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(968, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // InvoicesTableAdapter
            // 
            this.InvoicesTableAdapter.ClearBeforeFill = true;
            // 
            // idCBX
            // 
            this.filterCBX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterCBX.FormattingEnabled = true;
            this.filterCBX.ItemHeight = 23;
            this.filterCBX.Location = new System.Drawing.Point(894, 64);
            this.filterCBX.Margin = new System.Windows.Forms.Padding(2);
            this.filterCBX.Name = "filterCBX";
            this.filterCBX.Size = new System.Drawing.Size(92, 29);
            this.filterCBX.TabIndex = 3;
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
            this.filterLb.TabIndex = 9999;
            this.filterLb.Text = "Filtrar por";
            // 
            // VentasTableAdapter
            // 
            this.VentasTableAdapter.ClearBeforeFill = true;
            // 
            // filtrCbx
            // 
            this.filtrCbx.FormattingEnabled = true;
            this.filtrCbx.ItemHeight = 23;
            this.filtrCbx.Items.AddRange(new object[] {
            "ID",
            "Cliente",
            "Fecha"});
            this.filtrCbx.Location = new System.Drawing.Point(91, 63);
            this.filtrCbx.Name = "filtrCbx";
            this.filtrCbx.Size = new System.Drawing.Size(121, 29);
            this.filtrCbx.TabIndex = 1;
            this.filtrCbx.UseSelectable = true;
            this.filtrCbx.SelectedIndexChanged += new System.EventHandler(this.filtrCbx_SelectedIndexChanged);
            // 
            // factIdLbl
            // 
            this.factIdLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.factIdLbl.AutoSize = true;
            this.factIdLbl.Location = new System.Drawing.Point(773, 69);
            this.factIdLbl.Name = "factIdLbl";
            this.factIdLbl.Size = new System.Drawing.Size(116, 19);
            this.factIdLbl.TabIndex = 49999;
            this.factIdLbl.Text = "Seleccione Factura";
            // 
            // cliFiltrCBX
            // 
            this.cliFiltrCBX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cliFiltrCBX.FormattingEnabled = true;
            this.cliFiltrCBX.ItemHeight = 23;
            this.cliFiltrCBX.Location = new System.Drawing.Point(646, 64);
            this.cliFiltrCBX.Name = "cliFiltrCBX";
            this.cliFiltrCBX.Size = new System.Drawing.Size(121, 29);
            this.cliFiltrCBX.TabIndex = 2;
            this.cliFiltrCBX.UseSelectable = true;
            this.cliFiltrCBX.SelectedIndexChanged += new System.EventHandler(this.cliFiltrCBX_SelectedIndexChanged);
            // 
            // cliLbl
            // 
            this.cliLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cliLbl.AutoSize = true;
            this.cliLbl.Location = new System.Drawing.Point(529, 69);
            this.cliLbl.Name = "cliLbl";
            this.cliLbl.Size = new System.Drawing.Size(111, 19);
            this.cliLbl.TabIndex = 69999;
            this.cliLbl.Text = "Seleccione cliente";
            // 
            // hastaFchCbx
            // 
            this.hastaFchCbx.FormattingEnabled = true;
            this.hastaFchCbx.ItemHeight = 23;
            this.hastaFchCbx.Location = new System.Drawing.Point(646, 64);
            this.hastaFchCbx.Name = "hastaFchCbx";
            this.hastaFchCbx.Size = new System.Drawing.Size(121, 29);
            this.hastaFchCbx.TabIndex = 70000;
            this.hastaFchCbx.UseSelectable = true;
            this.hastaFchCbx.SelectedIndexChanged += new System.EventHandler(this.hastaFchCbx_SelectedIndexChanged);
            // 
            // desdeFchCbx
            // 
            this.desdeFchCbx.FormattingEnabled = true;
            this.desdeFchCbx.ItemHeight = 23;
            this.desdeFchCbx.Location = new System.Drawing.Point(402, 63);
            this.desdeFchCbx.Name = "desdeFchCbx";
            this.desdeFchCbx.Size = new System.Drawing.Size(121, 29);
            this.desdeFchCbx.TabIndex = 70001;
            this.desdeFchCbx.UseSelectable = true;
            // 
            // desdeFchLbl
            // 
            this.desdeFchLbl.AutoSize = true;
            this.desdeFchLbl.Location = new System.Drawing.Point(285, 68);
            this.desdeFchLbl.Name = "desdeFchLbl";
            this.desdeFchLbl.Size = new System.Drawing.Size(45, 19);
            this.desdeFchLbl.TabIndex = 70002;
            this.desdeFchLbl.Text = "Desde";
            // 
            // hastaFchLbl
            // 
            this.hastaFchLbl.AutoSize = true;
            this.hastaFchLbl.Location = new System.Drawing.Point(529, 69);
            this.hastaFchLbl.Name = "hastaFchLbl";
            this.hastaFchLbl.Size = new System.Drawing.Size(41, 19);
            this.hastaFchLbl.TabIndex = 70003;
            this.hastaFchLbl.Text = "Hasta";
            // 
            // Visor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 567);
            this.Controls.Add(this.hastaFchLbl);
            this.Controls.Add(this.desdeFchLbl);
            this.Controls.Add(this.desdeFchCbx);
            this.Controls.Add(this.hastaFchCbx);
            this.Controls.Add(this.factIdLbl);
            this.Controls.Add(this.filtrCbx);
            this.Controls.Add(this.filterLb);
            this.Controls.Add(this.idCBX);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.cliFiltrCBX);
            this.Controls.Add(this.cliLbl);
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
        private FacturasTableAdapters.VentasTableAdapter VentasTableAdapter;
        private MetroFramework.Controls.MetroComboBox filtrCbx;
        private MetroFramework.Controls.MetroLabel factIdLbl;
        private MetroFramework.Controls.MetroComboBox cliFiltrCBX;
        private MetroFramework.Controls.MetroLabel cliLbl;
        private MetroFramework.Controls.MetroComboBox hastaFchCbx;
        private MetroFramework.Controls.MetroComboBox desdeFchCbx;
        private MetroFramework.Controls.MetroLabel desdeFchLbl;
        private MetroFramework.Controls.MetroLabel hastaFchLbl;
    }
}