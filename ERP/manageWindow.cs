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
    /// Ventana gestionar.
    /// </summary>
    /// <seealso cref="MetroFramework.Forms.MetroForm" />
    public partial class manageWindow : MetroFramework.Forms.MetroForm
    {

        /// <summary>
        /// The headmod
        /// </summary>
        readonly String HEADMOD = "¿Qué desea modificar?";
        /// <summary>
        /// The headdel
        /// </summary>
        readonly String HEADDEL = "¿Qué desea eliminar?";
        /// <summary>
        /// The headdef
        /// </summary>
        readonly String HEADDEF = "¿Qué desea hacer?";

        /// <summary>
        /// The modificar
        /// </summary>
        readonly String MODIFICAR = "Modificar";
        /// <summary>
        /// The eliminar
        /// </summary>
        readonly String ELIMINAR = "Eliminar";

        /// <summary>
        /// The modif
        /// </summary>
        bool modif = false;
        /// <summary>
        /// The elimin
        /// </summary>
        bool elimin = false;

        /// <summary>
        /// The modif o elimin on
        /// </summary>
        bool modifOEliminOn = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="manageWindow" /> class.
        /// </summary>
        public manageWindow()
        {
            InitializeComponent();
            if (GlobalProperties.getDarkMode() == true)
                this.Theme = MetroFramework.MetroThemeStyle.Dark;
            else if (GlobalProperties.getDarkMode() == false)
                this.Theme = MetroFramework.MetroThemeStyle.Light;
        }

        /// <summary>
        /// Handles the Load event of the manageWindow control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void manageWindow_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Orders' Puede moverla o quitarla según sea necesario.
            this.ordersTableAdapter.Fill(this.northwindDataSet.Orders);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Products' Puede moverla o quitarla según sea necesario.
            this.productsTableAdapter.Fill(this.northwindDataSet.Products);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Suppliers' Puede moverla o quitarla según sea necesario.
            this.suppliersTableAdapter.Fill(this.northwindDataSet.Suppliers);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Customers' Puede moverla o quitarla según sea necesario.
            this.customersTableAdapter.Fill(this.northwindDataSet.Customers);

            modificarTile.Show();
            eliminarTile.Show();
            volverTile.Hide();
            datosTile.Hide();
            tramiteTile.Hide();
            labelGest.Text = HEADDEF;
            tabContrlDatGest.Hide();
            tabTram.Hide();
            
        }

        /// <summary>
        /// Handles the Click event of the modificarTile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void modificarTile_Click(object sender, EventArgs e)
        {
            modif = true;
            muestraQueDatos();
            labelGest.Text = HEADMOD;
            volverMenuPrincTile.Hide();
        }

        /// <summary>
        /// Handles the Click event of the eliminarTile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void eliminarTile_Click(object sender, EventArgs e)
        {
            elimin = true;
            muestraQueDatos();
            labelGest.Text = HEADDEL;
            volverMenuPrincTile.Hide();
        }

        /// <summary>
        /// Muestras the que datos.
        /// </summary>
        private void muestraQueDatos()
        {
            modificarTile.Hide();
            eliminarTile.Hide();
            volverTile.Show();
            datosTile.Show();
            tramiteTile.Show();

        }

        /// <summary>
        /// Handles the Click event of the volverTile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void volverTile_Click(object sender, EventArgs e)
        {
            modif = false;
            elimin = false;
            modificarTile.Show();
            eliminarTile.Show();
            volverTile.Hide();
            datosTile.Hide();
            tramiteTile.Hide();
            labelGest.Text = HEADDEF;
            tabTram.Hide();
            tabContrlDatGest.Hide();
            modifOEliminOn = false;
            volverMenuPrincTile.Show();
        }

        /// <summary>
        /// Handles the Click event of the customersBindingNavigatorSaveItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        /// <summary>
        /// Texts the BTS.
        /// </summary>
        private void txtBts()
        {
            if (modif)
            {
                btArt.Text = MODIFICAR;
                btCli.Text = MODIFICAR;
                btPed.Text = MODIFICAR;
                btProv.Text = MODIFICAR;
            } else if (elimin)
            {
                btArt.Text = ELIMINAR;
                btCli.Text = ELIMINAR;
                btPed.Text = ELIMINAR;
                btProv.Text = ELIMINAR;
            }
        }

        /// <summary>
        /// Handles the Click event of the datosTile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void datosTile_Click(object sender, EventArgs e)
        {
            txtBts();
            tabContrlDatGest.Show();
            tabTram.Hide();
            modifOEliminOn = true;
        }

        /// <summary>
        /// Handles the Click event of the tramiteTile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void tramiteTile_Click(object sender, EventArgs e)
        {
            txtBts();
            tabContrlDatGest.Hide();
            tabTram.Show();
            modifOEliminOn = true;
        }

        /// <summary>
        /// Handles the FormClosing event of the manageWindow control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs" /> instance containing the event data.</param>
        private void manageWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (modifOEliminOn)
            {
                if (MetroMessageBox.Show(this, "Hay datos sin guardar. ¿Estás seguro de cerrar la ventana?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the volverMenuPrincTile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void volverMenuPrincTile_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
