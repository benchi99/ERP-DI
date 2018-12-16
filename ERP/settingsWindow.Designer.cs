namespace ERP
{
    partial class settingsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsWindow));
            this.sideBarPanel = new MetroFramework.Controls.MetroPanel();
            this.AcercaTile = new MetroFramework.Controls.MetroTile();
            this.LicenciaTile = new MetroFramework.Controls.MetroTile();
            this.OpcionesTile = new MetroFramework.Controls.MetroTile();
            this.panelOpts = new MetroFramework.Controls.MetroPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.calAlarma1 = new Control_Calendario.CalAlarma();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bton = new MetroFramework.Controls.MetroButton();
            this.tboxSaveDir = new MetroFramework.Controls.MetroTextBox();
            this.saveLabel = new MetroFramework.Controls.MetroLabel();
            this.itemsCBox = new MetroFramework.Controls.MetroComboBox();
            this.labelInf1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.licensePanel = new MetroFramework.Controls.MetroPanel();
            this.validarCDK = new MetroFramework.Controls.MetroButton();
            this.pdtkey = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.LicenciaLbl = new MetroFramework.Controls.MetroLabel();
            this.AboutPanel = new MetroFramework.Controls.MetroPanel();
            this.lbl1 = new MetroFramework.Controls.MetroLabel();
            this.lbltitle = new MetroFramework.Controls.MetroLabel();
            this.sideBarPanel.SuspendLayout();
            this.panelOpts.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.licensePanel.SuspendLayout();
            this.AboutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBarPanel
            // 
            this.sideBarPanel.Controls.Add(this.AcercaTile);
            this.sideBarPanel.Controls.Add(this.LicenciaTile);
            this.sideBarPanel.Controls.Add(this.OpcionesTile);
            this.sideBarPanel.HorizontalScrollbarBarColor = true;
            this.sideBarPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.sideBarPanel.HorizontalScrollbarSize = 10;
            this.sideBarPanel.Location = new System.Drawing.Point(24, 64);
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Size = new System.Drawing.Size(293, 585);
            this.sideBarPanel.TabIndex = 0;
            this.sideBarPanel.VerticalScrollbarBarColor = true;
            this.sideBarPanel.VerticalScrollbarHighlightOnWheel = false;
            this.sideBarPanel.VerticalScrollbarSize = 10;
            // 
            // AcercaTile
            // 
            this.AcercaTile.ActiveControl = null;
            this.AcercaTile.Location = new System.Drawing.Point(3, 137);
            this.AcercaTile.Name = "AcercaTile";
            this.AcercaTile.Size = new System.Drawing.Size(287, 61);
            this.AcercaTile.TabIndex = 4;
            this.AcercaTile.Text = "Acerca de...";
            this.AcercaTile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AcercaTile.UseSelectable = true;
            this.AcercaTile.Click += new System.EventHandler(this.AcercaTile_Click);
            // 
            // LicenciaTile
            // 
            this.LicenciaTile.ActiveControl = null;
            this.LicenciaTile.Location = new System.Drawing.Point(3, 70);
            this.LicenciaTile.Name = "LicenciaTile";
            this.LicenciaTile.Size = new System.Drawing.Size(287, 61);
            this.LicenciaTile.TabIndex = 3;
            this.LicenciaTile.Text = "Licencia";
            this.LicenciaTile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LicenciaTile.UseSelectable = true;
            this.LicenciaTile.Click += new System.EventHandler(this.LicenciaTile_Click);
            // 
            // OpcionesTile
            // 
            this.OpcionesTile.ActiveControl = null;
            this.OpcionesTile.Location = new System.Drawing.Point(3, 3);
            this.OpcionesTile.Name = "OpcionesTile";
            this.OpcionesTile.Size = new System.Drawing.Size(287, 61);
            this.OpcionesTile.TabIndex = 2;
            this.OpcionesTile.Text = "Opciones...";
            this.OpcionesTile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpcionesTile.UseSelectable = true;
            this.OpcionesTile.Click += new System.EventHandler(this.OpcionesTile_Click);
            // 
            // panelOpts
            // 
            this.panelOpts.Controls.Add(this.groupBox3);
            this.panelOpts.Controls.Add(this.groupBox2);
            this.panelOpts.Controls.Add(this.groupBox1);
            this.panelOpts.HorizontalScrollbarBarColor = true;
            this.panelOpts.HorizontalScrollbarHighlightOnWheel = false;
            this.panelOpts.HorizontalScrollbarSize = 10;
            this.panelOpts.Location = new System.Drawing.Point(323, 64);
            this.panelOpts.Name = "panelOpts";
            this.panelOpts.Size = new System.Drawing.Size(603, 585);
            this.panelOpts.TabIndex = 1;
            this.panelOpts.VerticalScrollbarBarColor = true;
            this.panelOpts.VerticalScrollbarHighlightOnWheel = false;
            this.panelOpts.VerticalScrollbarSize = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.calAlarma1);
            this.groupBox3.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.groupBox3.Location = new System.Drawing.Point(3, 204);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(597, 378);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alarmas y Calendario";
            // 
            // calAlarma1
            // 
            this.calAlarma1.Location = new System.Drawing.Point(64, 27);
            this.calAlarma1.Margin = new System.Windows.Forms.Padding(4);
            this.calAlarma1.Name = "calAlarma1";
            this.calAlarma1.Size = new System.Drawing.Size(484, 344);
            this.calAlarma1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bton);
            this.groupBox2.Controls.Add(this.tboxSaveDir);
            this.groupBox2.Controls.Add(this.saveLabel);
            this.groupBox2.Controls.Add(this.itemsCBox);
            this.groupBox2.Controls.Add(this.labelInf1);
            this.groupBox2.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.groupBox2.Location = new System.Drawing.Point(3, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(597, 113);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informes";
            // 
            // bton
            // 
            this.bton.Location = new System.Drawing.Point(516, 23);
            this.bton.Name = "bton";
            this.bton.Size = new System.Drawing.Size(75, 23);
            this.bton.TabIndex = 4;
            this.bton.Text = "Generar";
            this.bton.UseSelectable = true;
            // 
            // tboxSaveDir
            // 
            // 
            // 
            // 
            this.tboxSaveDir.CustomButton.Image = null;
            this.tboxSaveDir.CustomButton.Location = new System.Drawing.Point(413, 1);
            this.tboxSaveDir.CustomButton.Name = "";
            this.tboxSaveDir.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tboxSaveDir.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tboxSaveDir.CustomButton.TabIndex = 1;
            this.tboxSaveDir.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tboxSaveDir.CustomButton.UseSelectable = true;
            this.tboxSaveDir.CustomButton.Visible = false;
            this.tboxSaveDir.Lines = new string[] {
        "C:\\"};
            this.tboxSaveDir.Location = new System.Drawing.Point(156, 71);
            this.tboxSaveDir.MaxLength = 32767;
            this.tboxSaveDir.Name = "tboxSaveDir";
            this.tboxSaveDir.PasswordChar = '\0';
            this.tboxSaveDir.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxSaveDir.SelectedText = "";
            this.tboxSaveDir.SelectionLength = 0;
            this.tboxSaveDir.SelectionStart = 0;
            this.tboxSaveDir.ShortcutsEnabled = true;
            this.tboxSaveDir.Size = new System.Drawing.Size(435, 23);
            this.tboxSaveDir.TabIndex = 3;
            this.tboxSaveDir.Text = "C:\\";
            this.tboxSaveDir.UseSelectable = true;
            this.tboxSaveDir.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tboxSaveDir.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // saveLabel
            // 
            this.saveLabel.AutoSize = true;
            this.saveLabel.Location = new System.Drawing.Point(6, 71);
            this.saveLabel.Name = "saveLabel";
            this.saveLabel.Size = new System.Drawing.Size(144, 19);
            this.saveLabel.TabIndex = 2;
            this.saveLabel.Text = "Dirección de guardado";
            // 
            // itemsCBox
            // 
            this.itemsCBox.FormattingEnabled = true;
            this.itemsCBox.ItemHeight = 23;
            this.itemsCBox.Items.AddRange(new object[] {
            "Clientes",
            "Articulos",
            "Proveedores",
            "Pedidos"});
            this.itemsCBox.Location = new System.Drawing.Point(142, 17);
            this.itemsCBox.Name = "itemsCBox";
            this.itemsCBox.Size = new System.Drawing.Size(368, 29);
            this.itemsCBox.TabIndex = 1;
            this.itemsCBox.UseSelectable = true;
            // 
            // labelInf1
            // 
            this.labelInf1.AutoSize = true;
            this.labelInf1.Location = new System.Drawing.Point(6, 27);
            this.labelInf1.Name = "labelInf1";
            this.labelInf1.Size = new System.Drawing.Size(130, 19);
            this.labelInf1.TabIndex = 0;
            this.labelInf1.Text = "Generar informes de";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroToggle1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 76);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visual";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 30);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(88, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Modo oscuro";
            // 
            // metroToggle1
            // 
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.Location = new System.Drawing.Point(100, 30);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(80, 23);
            this.metroToggle1.TabIndex = 2;
            this.metroToggle1.Text = "Off";
            this.metroToggle1.UseSelectable = true;
            this.metroToggle1.CheckedChanged += new System.EventHandler(this.metroToggle1_CheckedChanged);
            // 
            // licensePanel
            // 
            this.licensePanel.Controls.Add(this.validarCDK);
            this.licensePanel.Controls.Add(this.pdtkey);
            this.licensePanel.Controls.Add(this.metroLabel2);
            this.licensePanel.Controls.Add(this.LicenciaLbl);
            this.licensePanel.HorizontalScrollbarBarColor = true;
            this.licensePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.licensePanel.HorizontalScrollbarSize = 10;
            this.licensePanel.Location = new System.Drawing.Point(323, 61);
            this.licensePanel.Name = "licensePanel";
            this.licensePanel.Size = new System.Drawing.Size(603, 553);
            this.licensePanel.TabIndex = 2;
            this.licensePanel.VerticalScrollbarBarColor = true;
            this.licensePanel.VerticalScrollbarHighlightOnWheel = false;
            this.licensePanel.VerticalScrollbarSize = 10;
            // 
            // validarCDK
            // 
            this.validarCDK.Location = new System.Drawing.Point(519, 33);
            this.validarCDK.Name = "validarCDK";
            this.validarCDK.Size = new System.Drawing.Size(75, 23);
            this.validarCDK.TabIndex = 6;
            this.validarCDK.Text = "Validar";
            this.validarCDK.UseSelectable = true;
            // 
            // pdtkey
            // 
            // 
            // 
            // 
            this.pdtkey.CustomButton.Image = null;
            this.pdtkey.CustomButton.Location = new System.Drawing.Point(317, 1);
            this.pdtkey.CustomButton.Name = "";
            this.pdtkey.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.pdtkey.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pdtkey.CustomButton.TabIndex = 1;
            this.pdtkey.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pdtkey.CustomButton.UseSelectable = true;
            this.pdtkey.CustomButton.Visible = false;
            this.pdtkey.Lines = new string[0];
            this.pdtkey.Location = new System.Drawing.Point(174, 33);
            this.pdtkey.MaxLength = 32767;
            this.pdtkey.Name = "pdtkey";
            this.pdtkey.PasswordChar = '\0';
            this.pdtkey.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pdtkey.SelectedText = "";
            this.pdtkey.SelectionLength = 0;
            this.pdtkey.SelectionStart = 0;
            this.pdtkey.ShortcutsEnabled = true;
            this.pdtkey.Size = new System.Drawing.Size(339, 23);
            this.pdtkey.TabIndex = 5;
            this.pdtkey.UseSelectable = true;
            this.pdtkey.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pdtkey.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(10, 32);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(158, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Inserte clave de producto";
            // 
            // LicenciaLbl
            // 
            this.LicenciaLbl.AutoSize = true;
            this.LicenciaLbl.Location = new System.Drawing.Point(10, 11);
            this.LicenciaLbl.Name = "LicenciaLbl";
            this.LicenciaLbl.Size = new System.Drawing.Size(54, 19);
            this.LicenciaLbl.TabIndex = 3;
            this.LicenciaLbl.Text = "Licencia";
            // 
            // AboutPanel
            // 
            this.AboutPanel.Controls.Add(this.lbl1);
            this.AboutPanel.Controls.Add(this.lbltitle);
            this.AboutPanel.HorizontalScrollbarBarColor = true;
            this.AboutPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.AboutPanel.HorizontalScrollbarSize = 10;
            this.AboutPanel.Location = new System.Drawing.Point(320, 58);
            this.AboutPanel.Name = "AboutPanel";
            this.AboutPanel.Size = new System.Drawing.Size(603, 553);
            this.AboutPanel.TabIndex = 2;
            this.AboutPanel.VerticalScrollbarBarColor = true;
            this.AboutPanel.VerticalScrollbarHighlightOnWheel = false;
            this.AboutPanel.VerticalScrollbarSize = 10;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(10, 37);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(186, 19);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Realizado por Rubén Bermejo";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Location = new System.Drawing.Point(9, 14);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(87, 19);
            this.lbltitle.TabIndex = 2;
            this.lbltitle.Text = "ERP Software";
            // 
            // settingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 672);
            this.Controls.Add(this.panelOpts);
            this.Controls.Add(this.sideBarPanel);
            this.Controls.Add(this.AboutPanel);
            this.Controls.Add(this.licensePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "settingsWindow";
            this.Text = "Opciones";
            this.Load += new System.EventHandler(this.settingsWindow_Load);
            this.sideBarPanel.ResumeLayout(false);
            this.panelOpts.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.licensePanel.ResumeLayout(false);
            this.licensePanel.PerformLayout();
            this.AboutPanel.ResumeLayout(false);
            this.AboutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel sideBarPanel;
        private MetroFramework.Controls.MetroTile AcercaTile;
        private MetroFramework.Controls.MetroTile LicenciaTile;
        private MetroFramework.Controls.MetroTile OpcionesTile;
        private MetroFramework.Controls.MetroPanel panelOpts;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton bton;
        private MetroFramework.Controls.MetroTextBox tboxSaveDir;
        private MetroFramework.Controls.MetroLabel saveLabel;
        private MetroFramework.Controls.MetroComboBox itemsCBox;
        private MetroFramework.Controls.MetroLabel labelInf1;
        private MetroFramework.Controls.MetroPanel licensePanel;
        private MetroFramework.Controls.MetroPanel AboutPanel;
        private MetroFramework.Controls.MetroTextBox pdtkey;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel LicenciaLbl;
        private MetroFramework.Controls.MetroLabel lbl1;
        private MetroFramework.Controls.MetroLabel lbltitle;
        private MetroFramework.Controls.MetroButton validarCDK;
        private System.Windows.Forms.GroupBox groupBox3;
        private Control_Calendario.CalAlarma calAlarma1;
    }
}