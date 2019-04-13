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
    /// Ventana de opciones.
    /// </summary>
    /// <seealso cref="MetroFramework.Forms.MetroForm" />
    public partial class settingsWindow : MetroFramework.Forms.MetroForm
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="settingsWindow"/> class.
        /// </summary>
        public settingsWindow()
        {
            InitializeComponent();
            if (GlobalProperties.getDarkMode() == true)
                this.Theme = MetroFramework.MetroThemeStyle.Dark;
            else if (GlobalProperties.getDarkMode() == false)
                this.Theme = MetroFramework.MetroThemeStyle.Light;
        }

        /// <summary>
        /// Handles the Load event of the settingsWindow control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void settingsWindow_Load(object sender, EventArgs e)
        {
            AboutPanel.Hide();
            licensePanel.Hide();
            panelOpts.Hide();
        }

        /// <summary>
        /// Handles the CheckedChanged event of dark mode in the entire application.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            GlobalProperties.setDarkMode(metroToggle1.Checked);
            if (GlobalProperties.getDarkMode() == true)
                this.Theme = MetroFramework.MetroThemeStyle.Dark;
            else if (GlobalProperties.getDarkMode() == false)
                this.Theme = MetroFramework.MetroThemeStyle.Light;
        }

        /// <summary>
        /// Handles the Click event of the OpcionesTile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OpcionesTile_Click(object sender, EventArgs e)
        {
            panelOpts.Show();
            AboutPanel.Hide();
            licensePanel.Hide();
        }

        /// <summary>
        /// Handles the Click event of the LicenciaTile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void LicenciaTile_Click(object sender, EventArgs e)
        {
            licensePanel.Show();
            panelOpts.Hide();
            AboutPanel.Hide();
        }

        /// <summary>
        /// Handles the Click event of the AcercaTile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void AcercaTile_Click(object sender, EventArgs e)
        {
            AboutPanel.Show();
            licensePanel.Hide();
            panelOpts.Hide();
        }

        /// <summary>
        /// Handles the Click event of the report window initializer.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void bton_Click(object sender, EventArgs e)
        {
            if (itemsCBox.Text.ToString() != "")
            {
                Visor vis = new Visor(itemsCBox.Text.ToString());
                vis.ShowDialog();
            }
        }
    }
}
