namespace ERP
{
    partial class mainWindow
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.ventanaAbrir = new System.Windows.Forms.OpenFileDialog();
            this.userWelcome = new MetroFramework.Controls.MetroLabel();
            this.helpTile = new MetroFramework.Controls.MetroTile();
            this.tileGestionar = new MetroFramework.Controls.MetroTile();
            this.tileLogOff = new MetroFramework.Controls.MetroTile();
            this.tileOptions = new MetroFramework.Controls.MetroTile();
            this.tileOpen = new MetroFramework.Controls.MetroTile();
            this.tileNew = new MetroFramework.Controls.MetroTile();
            this.AYUdAAAAaAA = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Gestión";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(148, 64);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(0, 0);
            this.metroLabel2.TabIndex = 6;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(291, 64);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(72, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Recientes...";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(148, 64);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(66, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Utilidades";
            // 
            // userWelcome
            // 
            this.userWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userWelcome.AutoSize = true;
            this.userWelcome.Location = new System.Drawing.Point(633, 25);
            this.userWelcome.Name = "userWelcome";
            this.userWelcome.Size = new System.Drawing.Size(144, 19);
            this.userWelcome.TabIndex = 12;
            this.userWelcome.Text = "Bienvenido, <usuario>!";
            // 
            // helpTile
            // 
            this.helpTile.ActiveControl = null;
            this.helpTile.Location = new System.Drawing.Point(148, 195);
            this.helpTile.Name = "helpTile";
            this.helpTile.Size = new System.Drawing.Size(100, 100);
            this.helpTile.TabIndex = 13;
            this.helpTile.Text = "Ayuda";
            this.helpTile.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.helpTile.TileImage = global::ERP.Properties.Resources.help;
            this.helpTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.helpTile.UseSelectable = true;
            this.helpTile.UseTileImage = true;
            // 
            // tileGestionar
            // 
            this.tileGestionar.ActiveControl = null;
            this.tileGestionar.Location = new System.Drawing.Point(23, 301);
            this.tileGestionar.Name = "tileGestionar";
            this.tileGestionar.Size = new System.Drawing.Size(100, 100);
            this.tileGestionar.TabIndex = 7;
            this.tileGestionar.Text = "Gestionar...";
            this.tileGestionar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tileGestionar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tileGestionar.TileImage = global::ERP.Properties.Resources.gest;
            this.tileGestionar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileGestionar.UseSelectable = true;
            this.tileGestionar.UseTileImage = true;
            this.tileGestionar.Click += new System.EventHandler(this.tileGestionar_Click);
            // 
            // tileLogOff
            // 
            this.tileLogOff.ActiveControl = null;
            this.tileLogOff.Location = new System.Drawing.Point(148, 301);
            this.tileLogOff.Name = "tileLogOff";
            this.tileLogOff.Size = new System.Drawing.Size(100, 100);
            this.tileLogOff.TabIndex = 3;
            this.tileLogOff.Text = "Cerrar sesión...";
            this.tileLogOff.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tileLogOff.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tileLogOff.TileImage = global::ERP.Properties.Resources.logoff;
            this.tileLogOff.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileLogOff.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tileLogOff.UseSelectable = true;
            this.tileLogOff.UseTileImage = true;
            this.tileLogOff.Click += new System.EventHandler(this.tileLogOff_Click);
            // 
            // tileOptions
            // 
            this.tileOptions.ActiveControl = null;
            this.tileOptions.Location = new System.Drawing.Point(148, 89);
            this.tileOptions.Name = "tileOptions";
            this.tileOptions.Size = new System.Drawing.Size(100, 100);
            this.tileOptions.TabIndex = 2;
            this.tileOptions.Text = "Opciones...";
            this.tileOptions.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tileOptions.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tileOptions.TileImage = global::ERP.Properties.Resources.settings;
            this.tileOptions.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileOptions.UseSelectable = true;
            this.tileOptions.UseTileImage = true;
            this.tileOptions.Click += new System.EventHandler(this.tileOptions_Click);
            // 
            // tileOpen
            // 
            this.tileOpen.ActiveControl = null;
            this.tileOpen.Location = new System.Drawing.Point(23, 195);
            this.tileOpen.Name = "tileOpen";
            this.tileOpen.Size = new System.Drawing.Size(100, 100);
            this.tileOpen.TabIndex = 1;
            this.tileOpen.Text = "Abrir...";
            this.tileOpen.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tileOpen.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tileOpen.TileImage = global::ERP.Properties.Resources.open;
            this.tileOpen.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileOpen.UseSelectable = true;
            this.tileOpen.UseTileImage = true;
            this.tileOpen.Click += new System.EventHandler(this.tileOpen_Click);
            // 
            // tileNew
            // 
            this.tileNew.ActiveControl = null;
            this.tileNew.Location = new System.Drawing.Point(23, 89);
            this.tileNew.Name = "tileNew";
            this.tileNew.Size = new System.Drawing.Size(100, 100);
            this.tileNew.TabIndex = 0;
            this.tileNew.Text = "Nuevo...";
            this.tileNew.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tileNew.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tileNew.TileImage = global::ERP.Properties.Resources.plus;
            this.tileNew.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileNew.UseSelectable = true;
            this.tileNew.UseTileImage = true;
            this.tileNew.Click += new System.EventHandler(this.tileNew_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.helpTile);
            this.Controls.Add(this.userWelcome);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.tileGestionar);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tileLogOff);
            this.Controls.Add(this.tileOptions);
            this.Controls.Add(this.tileOpen);
            this.Controls.Add(this.tileNew);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(670, 420);
            this.Name = "mainWindow";
            this.AYUdAAAAaAA.SetShowHelp(this, true);
            this.Text = "Gestión Empresa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile tileNew;
        private MetroFramework.Controls.MetroTile tileOpen;
        private MetroFramework.Controls.MetroTile tileOptions;
        private MetroFramework.Controls.MetroTile tileLogOff;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile tileGestionar;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.OpenFileDialog ventanaAbrir;
        private MetroFramework.Controls.MetroLabel userWelcome;
        private MetroFramework.Controls.MetroTile helpTile;
        private System.Windows.Forms.HelpProvider AYUdAAAAaAA;
    }
}

