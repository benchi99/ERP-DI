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
    public partial class settingsWindow : MetroFramework.Forms.MetroForm
    {
        public settingsWindow()
        {
            InitializeComponent();
        }

        private void settingsWindow_Load(object sender, EventArgs e)
        {
            AboutPanel.Hide();
            licensePanel.Hide();
            panelOpts.Hide();
            
        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            //Aquí iría el código para cambiar el tema a oscuro para no
            //quemar retinas.
        }

        private void OpcionesTile_Click(object sender, EventArgs e)
        {
            panelOpts.Show();
            AboutPanel.Hide();
            licensePanel.Hide();
        }

        private void LicenciaTile_Click(object sender, EventArgs e)
        {
            licensePanel.Show();
            panelOpts.Hide();
            AboutPanel.Hide();
        }

        private void AcercaTile_Click(object sender, EventArgs e)
        {
            AboutPanel.Show();
            licensePanel.Hide();
            panelOpts.Hide();
        }
    }
}
