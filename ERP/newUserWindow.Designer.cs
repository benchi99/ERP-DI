﻿namespace ERP
{
    partial class newUserWindow
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.abririmg = new MetroFramework.Controls.MetroButton();
            this.imagenPf = new MetroFramework.Controls.MetroLabel();
            this.pfp = new System.Windows.Forms.PictureBox();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.apellidostb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.emil = new MetroFramework.Controls.MetroTextBox();
            this.edad = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.fechanac = new System.Windows.Forms.DateTimePicker();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.movil = new MetroFramework.Controls.MetroTextBox();
            this.fijo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.sexoCb = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.document = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.docType = new MetroFramework.Controls.MetroComboBox();
            this.idGener = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.nombretb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.okUser = new MetroFramework.Controls.MetroButton();
            this.cancelUser = new MetroFramework.Controls.MetroButton();
            this.clearUser = new MetroFramework.Controls.MetroButton();
            this.passUs = new MetroFramework.Controls.MetroTextBox();
            this.confPassUs = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.lvlUs = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.nombreUs = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.flowLayoutPanel1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pfp)).BeginInit();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.metroPanel1);
            this.flowLayoutPanel1.Controls.Add(this.metroPanel2);
            this.flowLayoutPanel1.Controls.Add(this.metroPanel3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(23, 63);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(793, 403);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.abririmg);
            this.metroPanel1.Controls.Add(this.imagenPf);
            this.metroPanel1.Controls.Add(this.pfp);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(161, 397);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // abririmg
            // 
            this.abririmg.Location = new System.Drawing.Point(3, 183);
            this.abririmg.Name = "abririmg";
            this.abririmg.Size = new System.Drawing.Size(155, 23);
            this.abririmg.TabIndex = 4;
            this.abririmg.Text = "Añadir...";
            this.abririmg.UseSelectable = true;
            this.abririmg.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // imagenPf
            // 
            this.imagenPf.AutoSize = true;
            this.imagenPf.Location = new System.Drawing.Point(3, 0);
            this.imagenPf.Name = "imagenPf";
            this.imagenPf.Size = new System.Drawing.Size(105, 19);
            this.imagenPf.TabIndex = 3;
            this.imagenPf.Text = "Imagen de Perfil";
            // 
            // pfp
            // 
            this.pfp.BackColor = System.Drawing.Color.Silver;
            this.pfp.Location = new System.Drawing.Point(3, 22);
            this.pfp.Name = "pfp";
            this.pfp.Size = new System.Drawing.Size(155, 155);
            this.pfp.TabIndex = 2;
            this.pfp.TabStop = false;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.apellidostb);
            this.metroPanel2.Controls.Add(this.metroLabel18);
            this.metroPanel2.Controls.Add(this.metroLabel11);
            this.metroPanel2.Controls.Add(this.emil);
            this.metroPanel2.Controls.Add(this.edad);
            this.metroPanel2.Controls.Add(this.metroLabel10);
            this.metroPanel2.Controls.Add(this.metroLabel9);
            this.metroPanel2.Controls.Add(this.fechanac);
            this.metroPanel2.Controls.Add(this.metroLabel8);
            this.metroPanel2.Controls.Add(this.metroLabel7);
            this.metroPanel2.Controls.Add(this.movil);
            this.metroPanel2.Controls.Add(this.fijo);
            this.metroPanel2.Controls.Add(this.metroLabel6);
            this.metroPanel2.Controls.Add(this.sexoCb);
            this.metroPanel2.Controls.Add(this.metroLabel5);
            this.metroPanel2.Controls.Add(this.document);
            this.metroPanel2.Controls.Add(this.metroLabel4);
            this.metroPanel2.Controls.Add(this.docType);
            this.metroPanel2.Controls.Add(this.idGener);
            this.metroPanel2.Controls.Add(this.metroLabel3);
            this.metroPanel2.Controls.Add(this.nombretb);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(170, 3);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(307, 397);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // apellidostb
            // 
            // 
            // 
            // 
            this.apellidostb.CustomButton.Image = null;
            this.apellidostb.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.apellidostb.CustomButton.Name = "";
            this.apellidostb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.apellidostb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.apellidostb.CustomButton.TabIndex = 1;
            this.apellidostb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.apellidostb.CustomButton.UseSelectable = true;
            this.apellidostb.CustomButton.Visible = false;
            this.apellidostb.Lines = new string[0];
            this.apellidostb.Location = new System.Drawing.Point(68, 51);
            this.apellidostb.MaxLength = 32767;
            this.apellidostb.Name = "apellidostb";
            this.apellidostb.PasswordChar = '\0';
            this.apellidostb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.apellidostb.SelectedText = "";
            this.apellidostb.SelectionLength = 0;
            this.apellidostb.SelectionStart = 0;
            this.apellidostb.ShortcutsEnabled = true;
            this.apellidostb.Size = new System.Drawing.Size(236, 23);
            this.apellidostb.TabIndex = 23;
            this.apellidostb.UseSelectable = true;
            this.apellidostb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.apellidostb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(3, 51);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(63, 19);
            this.metroLabel18.TabIndex = 22;
            this.metroLabel18.Text = "Apellidos";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(3, 278);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(57, 19);
            this.metroLabel11.TabIndex = 21;
            this.metroLabel11.Text = "E-mail *";
            // 
            // emil
            // 
            // 
            // 
            // 
            this.emil.CustomButton.Image = null;
            this.emil.CustomButton.Location = new System.Drawing.Point(216, 1);
            this.emil.CustomButton.Name = "";
            this.emil.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.emil.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.emil.CustomButton.TabIndex = 1;
            this.emil.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.emil.CustomButton.UseSelectable = true;
            this.emil.CustomButton.Visible = false;
            this.emil.Lines = new string[0];
            this.emil.Location = new System.Drawing.Point(66, 278);
            this.emil.MaxLength = 32767;
            this.emil.Name = "emil";
            this.emil.PasswordChar = '\0';
            this.emil.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emil.SelectedText = "";
            this.emil.SelectionLength = 0;
            this.emil.SelectionStart = 0;
            this.emil.ShortcutsEnabled = true;
            this.emil.Size = new System.Drawing.Size(238, 23);
            this.emil.TabIndex = 8;
            this.emil.UseSelectable = true;
            this.emil.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.emil.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // edad
            // 
            // 
            // 
            // 
            this.edad.CustomButton.Image = null;
            this.edad.CustomButton.Location = new System.Drawing.Point(43, 1);
            this.edad.CustomButton.Name = "";
            this.edad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.edad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.edad.CustomButton.TabIndex = 1;
            this.edad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.edad.CustomButton.UseSelectable = true;
            this.edad.CustomButton.Visible = false;
            this.edad.Enabled = false;
            this.edad.Lines = new string[0];
            this.edad.Location = new System.Drawing.Point(239, 249);
            this.edad.MaxLength = 32767;
            this.edad.Name = "edad";
            this.edad.PasswordChar = '\0';
            this.edad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.edad.SelectedText = "";
            this.edad.SelectionLength = 0;
            this.edad.SelectionStart = 0;
            this.edad.ShortcutsEnabled = true;
            this.edad.Size = new System.Drawing.Size(65, 23);
            this.edad.TabIndex = 7;
            this.edad.UseSelectable = true;
            this.edad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.edad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(202, 250);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(39, 19);
            this.metroLabel10.TabIndex = 19;
            this.metroLabel10.Text = "Edad";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(3, 249);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(121, 19);
            this.metroLabel9.TabIndex = 18;
            this.metroLabel9.Text = "Fecha nacimiento *";
            // 
            // fechanac
            // 
            this.fechanac.Location = new System.Drawing.Point(130, 249);
            this.fechanac.Name = "fechanac";
            this.fechanac.Size = new System.Drawing.Size(66, 20);
            this.fechanac.TabIndex = 6;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(3, 214);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(41, 19);
            this.metroLabel8.TabIndex = 16;
            this.metroLabel8.Text = "Móvil";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(3, 185);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(40, 19);
            this.metroLabel7.TabIndex = 15;
            this.metroLabel7.Text = "Fijo *";
            // 
            // movil
            // 
            // 
            // 
            // 
            this.movil.CustomButton.Image = null;
            this.movil.CustomButton.Location = new System.Drawing.Point(232, 1);
            this.movil.CustomButton.Name = "";
            this.movil.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.movil.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.movil.CustomButton.TabIndex = 1;
            this.movil.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.movil.CustomButton.UseSelectable = true;
            this.movil.CustomButton.Visible = false;
            this.movil.Lines = new string[0];
            this.movil.Location = new System.Drawing.Point(50, 214);
            this.movil.MaxLength = 32767;
            this.movil.Name = "movil";
            this.movil.PasswordChar = '\0';
            this.movil.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.movil.SelectedText = "";
            this.movil.SelectionLength = 0;
            this.movil.SelectionStart = 0;
            this.movil.ShortcutsEnabled = true;
            this.movil.Size = new System.Drawing.Size(254, 23);
            this.movil.TabIndex = 5;
            this.movil.UseSelectable = true;
            this.movil.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.movil.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // fijo
            // 
            // 
            // 
            // 
            this.fijo.CustomButton.Image = null;
            this.fijo.CustomButton.Location = new System.Drawing.Point(232, 1);
            this.fijo.CustomButton.Name = "";
            this.fijo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.fijo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.fijo.CustomButton.TabIndex = 1;
            this.fijo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.fijo.CustomButton.UseSelectable = true;
            this.fijo.CustomButton.Visible = false;
            this.fijo.Lines = new string[0];
            this.fijo.Location = new System.Drawing.Point(50, 185);
            this.fijo.MaxLength = 32767;
            this.fijo.Name = "fijo";
            this.fijo.PasswordChar = '\0';
            this.fijo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fijo.SelectedText = "";
            this.fijo.SelectionLength = 0;
            this.fijo.SelectionStart = 0;
            this.fijo.ShortcutsEnabled = true;
            this.fijo.Size = new System.Drawing.Size(254, 23);
            this.fijo.TabIndex = 4;
            this.fijo.UseSelectable = true;
            this.fijo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.fijo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(3, 162);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(63, 19);
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "Teléfonos";
            // 
            // sexoCb
            // 
            this.sexoCb.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.sexoCb.FormattingEnabled = true;
            this.sexoCb.ItemHeight = 19;
            this.sexoCb.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.sexoCb.Location = new System.Drawing.Point(222, 121);
            this.sexoCb.Name = "sexoCb";
            this.sexoCb.Size = new System.Drawing.Size(82, 25);
            this.sexoCb.TabIndex = 3;
            this.sexoCb.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(179, 125);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(47, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Sexo *";
            // 
            // document
            // 
            // 
            // 
            // 
            this.document.CustomButton.Image = null;
            this.document.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.document.CustomButton.Name = "";
            this.document.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.document.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.document.CustomButton.TabIndex = 1;
            this.document.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.document.CustomButton.UseSelectable = true;
            this.document.CustomButton.Visible = false;
            this.document.Lines = new string[0];
            this.document.Location = new System.Drawing.Point(3, 121);
            this.document.MaxLength = 32767;
            this.document.Name = "document";
            this.document.PasswordChar = '\0';
            this.document.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.document.SelectedText = "";
            this.document.SelectionLength = 0;
            this.document.SelectionStart = 0;
            this.document.ShortcutsEnabled = true;
            this.document.Size = new System.Drawing.Size(170, 23);
            this.document.TabIndex = 2;
            this.document.UseSelectable = true;
            this.document.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.document.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 90);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(135, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Tipo de documento *";
            // 
            // docType
            // 
            this.docType.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.docType.FormattingEnabled = true;
            this.docType.ItemHeight = 19;
            this.docType.Items.AddRange(new object[] {
            "",
            "DNI",
            "Carné de conducir"});
            this.docType.Location = new System.Drawing.Point(144, 90);
            this.docType.Name = "docType";
            this.docType.Size = new System.Drawing.Size(160, 25);
            this.docType.TabIndex = 1;
            this.docType.UseSelectable = true;
            // 
            // idGener
            // 
            // 
            // 
            // 
            this.idGener.CustomButton.Image = null;
            this.idGener.CustomButton.Location = new System.Drawing.Point(43, 1);
            this.idGener.CustomButton.Name = "";
            this.idGener.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.idGener.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.idGener.CustomButton.TabIndex = 1;
            this.idGener.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.idGener.CustomButton.UseSelectable = true;
            this.idGener.CustomButton.Visible = false;
            this.idGener.Enabled = false;
            this.idGener.Lines = new string[0];
            this.idGener.Location = new System.Drawing.Point(239, 22);
            this.idGener.MaxLength = 32767;
            this.idGener.Name = "idGener";
            this.idGener.PasswordChar = '\0';
            this.idGener.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.idGener.SelectedText = "";
            this.idGener.SelectionLength = 0;
            this.idGener.SelectionStart = 0;
            this.idGener.ShortcutsEnabled = true;
            this.idGener.Size = new System.Drawing.Size(65, 23);
            this.idGener.TabIndex = 6;
            this.idGener.UseSelectable = true;
            this.idGener.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.idGener.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(212, 22);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(21, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "ID";
            // 
            // nombretb
            // 
            // 
            // 
            // 
            this.nombretb.CustomButton.Image = null;
            this.nombretb.CustomButton.Location = new System.Drawing.Point(116, 1);
            this.nombretb.CustomButton.Name = "";
            this.nombretb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nombretb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nombretb.CustomButton.TabIndex = 1;
            this.nombretb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nombretb.CustomButton.UseSelectable = true;
            this.nombretb.CustomButton.Visible = false;
            this.nombretb.Lines = new string[0];
            this.nombretb.Location = new System.Drawing.Point(68, 22);
            this.nombretb.MaxLength = 32767;
            this.nombretb.Name = "nombretb";
            this.nombretb.PasswordChar = '\0';
            this.nombretb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nombretb.SelectedText = "";
            this.nombretb.SelectionLength = 0;
            this.nombretb.SelectionStart = 0;
            this.nombretb.ShortcutsEnabled = true;
            this.nombretb.Size = new System.Drawing.Size(138, 23);
            this.nombretb.TabIndex = 0;
            this.nombretb.UseSelectable = true;
            this.nombretb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nombretb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.nombretb.TextChanged += new System.EventHandler(this.nombretb_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 22);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(69, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Nombre *";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(133, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Información personal";
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.metroLabel17);
            this.metroPanel3.Controls.Add(this.okUser);
            this.metroPanel3.Controls.Add(this.cancelUser);
            this.metroPanel3.Controls.Add(this.clearUser);
            this.metroPanel3.Controls.Add(this.passUs);
            this.metroPanel3.Controls.Add(this.confPassUs);
            this.metroPanel3.Controls.Add(this.metroLabel16);
            this.metroPanel3.Controls.Add(this.metroLabel15);
            this.metroPanel3.Controls.Add(this.lvlUs);
            this.metroPanel3.Controls.Add(this.metroLabel14);
            this.metroPanel3.Controls.Add(this.nombreUs);
            this.metroPanel3.Controls.Add(this.metroLabel13);
            this.metroPanel3.Controls.Add(this.metroLabel12);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(483, 3);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(307, 397);
            this.metroPanel3.TabIndex = 2;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(100, 349);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(204, 19);
            this.metroLabel17.TabIndex = 19;
            this.metroLabel17.Text = "Los campos con * son requeridos";
            // 
            // okUser
            // 
            this.okUser.Location = new System.Drawing.Point(229, 371);
            this.okUser.Name = "okUser";
            this.okUser.Size = new System.Drawing.Size(75, 23);
            this.okUser.TabIndex = 18;
            this.okUser.Text = "Aceptar";
            this.okUser.UseSelectable = true;
            this.okUser.Click += new System.EventHandler(this.okUser_Click);
            // 
            // cancelUser
            // 
            this.cancelUser.Location = new System.Drawing.Point(148, 371);
            this.cancelUser.Name = "cancelUser";
            this.cancelUser.Size = new System.Drawing.Size(75, 23);
            this.cancelUser.TabIndex = 17;
            this.cancelUser.Text = "Cancelar";
            this.cancelUser.UseSelectable = true;
            this.cancelUser.Click += new System.EventHandler(this.cancelUser_Click);
            // 
            // clearUser
            // 
            this.clearUser.Location = new System.Drawing.Point(67, 371);
            this.clearUser.Name = "clearUser";
            this.clearUser.Size = new System.Drawing.Size(75, 23);
            this.clearUser.TabIndex = 16;
            this.clearUser.Text = "Limpiar";
            this.clearUser.UseSelectable = true;
            this.clearUser.Click += new System.EventHandler(this.clearUser_Click);
            // 
            // passUs
            // 
            // 
            // 
            // 
            this.passUs.CustomButton.Image = null;
            this.passUs.CustomButton.Location = new System.Drawing.Point(137, 1);
            this.passUs.CustomButton.Name = "";
            this.passUs.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passUs.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passUs.CustomButton.TabIndex = 1;
            this.passUs.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passUs.CustomButton.UseSelectable = true;
            this.passUs.CustomButton.Visible = false;
            this.passUs.Lines = new string[0];
            this.passUs.Location = new System.Drawing.Point(145, 90);
            this.passUs.MaxLength = 32767;
            this.passUs.Name = "passUs";
            this.passUs.PasswordChar = '*';
            this.passUs.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passUs.SelectedText = "";
            this.passUs.SelectionLength = 0;
            this.passUs.SelectionStart = 0;
            this.passUs.ShortcutsEnabled = true;
            this.passUs.Size = new System.Drawing.Size(159, 23);
            this.passUs.TabIndex = 15;
            this.passUs.UseSelectable = true;
            this.passUs.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passUs.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // confPassUs
            // 
            // 
            // 
            // 
            this.confPassUs.CustomButton.Image = null;
            this.confPassUs.CustomButton.Location = new System.Drawing.Point(137, 1);
            this.confPassUs.CustomButton.Name = "";
            this.confPassUs.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.confPassUs.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.confPassUs.CustomButton.TabIndex = 1;
            this.confPassUs.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.confPassUs.CustomButton.UseSelectable = true;
            this.confPassUs.CustomButton.Visible = false;
            this.confPassUs.Lines = new string[0];
            this.confPassUs.Location = new System.Drawing.Point(145, 119);
            this.confPassUs.MaxLength = 32767;
            this.confPassUs.Name = "confPassUs";
            this.confPassUs.PasswordChar = '*';
            this.confPassUs.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.confPassUs.SelectedText = "";
            this.confPassUs.SelectionLength = 0;
            this.confPassUs.SelectionStart = 0;
            this.confPassUs.ShortcutsEnabled = true;
            this.confPassUs.Size = new System.Drawing.Size(159, 23);
            this.confPassUs.TabIndex = 14;
            this.confPassUs.UseSelectable = true;
            this.confPassUs.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.confPassUs.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(3, 119);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(146, 19);
            this.metroLabel16.TabIndex = 13;
            this.metroLabel16.Text = "Confirmar contraseña *";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(3, 90);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(85, 19);
            this.metroLabel15.TabIndex = 12;
            this.metroLabel15.Text = "Contraseña *";
            // 
            // lvlUs
            // 
            this.lvlUs.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.lvlUs.FormattingEnabled = true;
            this.lvlUs.ItemHeight = 19;
            this.lvlUs.Items.AddRange(new object[] {
            "Usuario",
            "Administrador"});
            this.lvlUs.Location = new System.Drawing.Point(145, 59);
            this.lvlUs.Name = "lvlUs";
            this.lvlUs.Size = new System.Drawing.Size(159, 25);
            this.lvlUs.TabIndex = 11;
            this.lvlUs.UseSelectable = true;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(3, 59);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(113, 19);
            this.metroLabel14.TabIndex = 10;
            this.metroLabel14.Text = "Nivel de usuario *";
            // 
            // nombreUs
            // 
            // 
            // 
            // 
            this.nombreUs.CustomButton.Image = null;
            this.nombreUs.CustomButton.Location = new System.Drawing.Point(137, 1);
            this.nombreUs.CustomButton.Name = "";
            this.nombreUs.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nombreUs.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nombreUs.CustomButton.TabIndex = 1;
            this.nombreUs.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nombreUs.CustomButton.UseSelectable = true;
            this.nombreUs.CustomButton.Visible = false;
            this.nombreUs.Lines = new string[0];
            this.nombreUs.Location = new System.Drawing.Point(145, 22);
            this.nombreUs.MaxLength = 32767;
            this.nombreUs.Name = "nombreUs";
            this.nombreUs.PasswordChar = '\0';
            this.nombreUs.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nombreUs.SelectedText = "";
            this.nombreUs.SelectionLength = 0;
            this.nombreUs.SelectionStart = 0;
            this.nombreUs.ShortcutsEnabled = true;
            this.nombreUs.Size = new System.Drawing.Size(159, 23);
            this.nombreUs.TabIndex = 9;
            this.nombreUs.UseSelectable = true;
            this.nombreUs.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nombreUs.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(3, 26);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(134, 19);
            this.metroLabel13.TabIndex = 3;
            this.metroLabel13.Text = "Nombre de usuario *";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(3, 0);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(134, 19);
            this.metroLabel12.TabIndex = 2;
            this.metroLabel12.Text = "Información empresa";
            // 
            // newUserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 486);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "newUserWindow";
            this.Text = "Nuevo usuario...";
            this.Load += new System.EventHandler(this.newUserWindow_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pfp)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroLabel imagenPf;
        private System.Windows.Forms.PictureBox pfp;
        private MetroFramework.Controls.MetroButton abririmg;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox nombretb;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox idGener;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox document;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox docType;
        private MetroFramework.Controls.MetroComboBox sexoCb;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox fijo;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox movil;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.DateTimePicker fechanac;
        private MetroFramework.Controls.MetroTextBox edad;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox emil;
        private MetroFramework.Controls.MetroTextBox nombreUs;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroButton okUser;
        private MetroFramework.Controls.MetroButton cancelUser;
        private MetroFramework.Controls.MetroButton clearUser;
        private MetroFramework.Controls.MetroTextBox passUs;
        private MetroFramework.Controls.MetroTextBox confPassUs;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroComboBox lvlUs;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroTextBox apellidostb;
        private MetroFramework.Controls.MetroLabel metroLabel18;
    }
}