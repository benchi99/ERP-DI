using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP
{
    public partial class mainWindow : MetroFramework.Forms.MetroForm
    {

        bool loggedIn = false;

        public mainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!loggedIn)
            {
                tileNew.Enabled = false;
                tileGestionar.Enabled = false;
                tileOpen.Enabled = false;
                tileOptions.Enabled = false;

                tileLogOff.Text = "Nuevo usuario...";
                tileLogOff.TileImage = ERP.Properties.Resources.newUser;

                userWelcome.Text = "Bienvenido!";
            }
            else
            {
                tileNew.Enabled = true;
                tileGestionar.Enabled = true;
                tileOpen.Enabled = true;
                tileOptions.Enabled = true;
            }
        }

        private void tileNew_Click(object sender, EventArgs e)
        {
            Hide();
            newWindow nuevo = new newWindow();
            nuevo.ShowDialog();
            Show();
        }

        private void tileOpen_Click(object sender, EventArgs e)
        {
            ventanaAbrir.ShowDialog();
        }

        private void tileGestionar_Click(object sender, EventArgs e)
        {
            Hide();
            manageWindow gest = new manageWindow();
            gest.ShowDialog();
            Show();
        }

        private void tileOptions_Click(object sender, EventArgs e)
        {
            Hide();
            settingsWindow sett = new settingsWindow();
            sett.ShowDialog();
            Show();
        }

        private void tileLogOff_Click(object sender, EventArgs e)
        {
            if (loggedIn)
            {
                if (MetroMessageBox.Show(this, "Está a punto de cerrar sesión. ¿Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else
            {
                newUserWindow nUs = new newUserWindow();
                nUs.ShowDialog();
                Show();
            }
        }
    }
}
