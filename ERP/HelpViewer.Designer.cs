namespace ERP
{
    partial class HelpViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpViewer));
            this.pdfView = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.pdfView)).BeginInit();
            this.SuspendLayout();
            // 
            // pdfView
            // 
            this.pdfView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfView.Enabled = true;
            this.pdfView.Location = new System.Drawing.Point(23, 63);
            this.pdfView.Name = "pdfView";
            this.pdfView.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdfView.OcxState")));
            this.pdfView.Size = new System.Drawing.Size(754, 364);
            this.pdfView.TabIndex = 0;
            // 
            // HelpViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pdfView);
            this.Name = "HelpViewer";
            this.Text = "Ayuda";
            this.Load += new System.EventHandler(this.HelpViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pdfView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF pdfView;
    }
}