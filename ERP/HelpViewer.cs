using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP
{
    /// <summary>
    /// Help Viewer.
    /// </summary>
    /// <seealso cref="MetroFramework.Forms.MetroForm" />
    public partial class HelpViewer : MetroFramework.Forms.MetroForm
    {
        string archivo = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"/res/pdf/manual.pdf";

        /// <summary>
        /// Initializes a new instance of the <see cref="HelpViewer"/> class.
        /// </summary>
        public HelpViewer()
        {
            InitializeComponent();
            if (GlobalProperties.getDarkMode() == true)
                this.Theme = MetroFramework.MetroThemeStyle.Dark;
            else if (GlobalProperties.getDarkMode() == false)
                this.Theme = MetroFramework.MetroThemeStyle.Light;
        }

        /// <summary>
        /// Handles the Load event of the HelpViewer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void HelpViewer_Load(object sender, EventArgs e)
        {
            pdfView.src = archivo;
        }
    }
}
