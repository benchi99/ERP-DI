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
    /// <summary>
    /// Ventana principal.
    /// </summary>
    /// <seealso cref="MetroFramework.Forms.MetroForm" />
    public partial class mainWindow : MetroFramework.Forms.MetroForm
    {

        bool loggedIn = true;

        /// <summary>
        /// Initializes a new instance of the <see cref="mainWindow"/> class.
        /// </summary>
        public mainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the Form1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Handles the Click event of the tileNew control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void tileNew_Click(object sender, EventArgs e)
        {
            Hide();
            newWindow nuevo = new newWindow();
            nuevo.ShowDialog();
            Show();
        }

        /// <summary>
        /// Handles the Click event of the tileOpen control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void tileOpen_Click(object sender, EventArgs e)
        {
            ventanaAbrir.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the tileGestionar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void tileGestionar_Click(object sender, EventArgs e)
        {
            Hide();
            manageWindow gest = new manageWindow();
            gest.ShowDialog();
            Show();
        }

        /// <summary>
        /// Handles the Click event of the tileOptions control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void tileOptions_Click(object sender, EventArgs e)
        {
            Hide();
            settingsWindow sett = new settingsWindow();
            sett.ShowDialog();
            Show();
        }

        /// <summary>
        /// Handles the Click event of the tileLogOff control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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
