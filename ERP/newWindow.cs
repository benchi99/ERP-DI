
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
    /// New Window.
    /// </summary>
    /// <seealso cref="MetroFramework.Forms.MetroForm" />
    public partial class newWindow : Form
    {

        bool volverPuls = false;
        bool tramitODatOn = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="newWindow"/> class.
        /// </summary>
        public newWindow()
        {
            InitializeComponent();
            dataTabCtrl.Hide();
            tramiteCtrl.Hide();
        }

        /// <summary>
        /// Handles the Load event of the Form1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Orders' Puede moverla o quitarla según sea necesario.
            this.ordersTableAdapter.Fill(this.northwindDataSet.Orders);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Products' Puede moverla o quitarla según sea necesario.
            this.productsTableAdapter.Fill(this.northwindDataSet.Products);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Suppliers' Puede moverla o quitarla según sea necesario.
            this.suppliersTableAdapter.Fill(this.northwindDataSet.Suppliers);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Customers' Puede moverla o quitarla según sea necesario.
            this.customersTableAdapter.Fill(this.northwindDataSet.Customers);

        }

        /// <summary>
        /// Handles the Click event of the customersBindingNavigatorSaveItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        /// <summary>
        /// Handles the Click event of the tileAñadDatos control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void tileAñadDatos_Click(object sender, EventArgs e)
        {
            tramiteCtrl.Hide();
            dataTabCtrl.Show();
            tramitODatOn = true;
        }

        /// <summary>
        /// Handles the Click event of the tramiteTile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void tramiteTile_Click(object sender, EventArgs e)
        {
            dataTabCtrl.Hide();
            tramiteCtrl.Show();
            tramitODatOn = true;
        }

        /// <summary>
        /// Handles the Click event of the volverTile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void volverTile_Click(object sender, EventArgs e)
        {
            volverPuls = true;
            if (tramitODatOn)
            {
                if (MetroMessageBox.Show(this, "Hay datos sin guardar. ¿Estás seguro de cerrar la ventana?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this.Hide();
                }
            }
            else
            {
                this.Hide();
            }
        }

        /// <summary>
        /// Handles the Click event of the btCancelTram control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btCancelTram_Click(object sender, EventArgs e)
        {
            tramiteCtrl.Hide();
            tramitODatOn = false;
        }

        /// <summary>
        /// Handles the Click event of the cancelarBtDat control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cancelarBtDat_Click(object sender, EventArgs e)
        {
            dataTabCtrl.Hide();
            tramitODatOn = false;
        }

        /// <summary>
        /// Handles the Click event of the cancelArtDat control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cancelArtDat_Click(object sender, EventArgs e)
        {
            dataTabCtrl.Hide();
            tramitODatOn = false;
        }

        /// <summary>
        /// Handles the Click event of the cancelProvBt control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cancelProvBt_Click(object sender, EventArgs e)
        {
            dataTabCtrl.Hide();
            tramitODatOn = false;
        }

        /// <summary>
        /// Handles the FormClosing event of the newWindow control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void newWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(volverPuls == false)
            {
                if (tramitODatOn)
                {
                    if (MetroMessageBox.Show(this, "Hay datos sin guardar. ¿Estás seguro de cerrar la ventana?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }
    }
}
