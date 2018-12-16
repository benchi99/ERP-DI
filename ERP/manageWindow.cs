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
    public partial class manageWindow : MetroFramework.Forms.MetroForm
    {

        readonly String HEADMOD = "¿Qué desea modificar?";
        readonly String HEADDEL = "¿Qué desea eliminar?";
        readonly String HEADDEF = "¿Qué desea hacer?";

        readonly String MODIFICAR = "Modificar";
        readonly String ELIMINAR = "Eliminar";

        bool modif = false;
        bool elimin = false;

        bool modifOEliminOn = false;

        public manageWindow()
        {
            InitializeComponent();
        }

        private void manageWindow_Load(object sender, EventArgs e)
        {

            /*
             * SI LA BASE DE DATOS NO ESTÁ INSTALADA CRASHEARÁ EL PROGRAMA.
             * 
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Orders' Puede moverla o quitarla según sea necesario.
            this.ordersTableAdapter.Fill(this.northwindDataSet.Orders);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Products' Puede moverla o quitarla según sea necesario.
            this.productsTableAdapter.Fill(this.northwindDataSet.Products);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Suppliers' Puede moverla o quitarla según sea necesario.
            this.suppliersTableAdapter.Fill(this.northwindDataSet.Suppliers);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Customers' Puede moverla o quitarla según sea necesario.
            this.customersTableAdapter.Fill(this.northwindDataSet.Customers);
            */
            modificarTile.Show();
            eliminarTile.Show();
            volverTile.Hide();
            datosTile.Hide();
            tramiteTile.Hide();
            labelGest.Text = HEADDEF;
            tabContrlDatGest.Hide();
            tabTram.Hide();
            
        }

        private void modificarTile_Click(object sender, EventArgs e)
        {
            modif = true;
            muestraQueDatos();
            labelGest.Text = HEADMOD;
            volverMenuPrincTile.Hide();
        }

        private void eliminarTile_Click(object sender, EventArgs e)
        {
            elimin = true;
            muestraQueDatos();
            labelGest.Text = HEADDEL;
            volverMenuPrincTile.Hide();
        }

        private void muestraQueDatos()
        {
            modificarTile.Hide();
            eliminarTile.Hide();
            volverTile.Show();
            datosTile.Show();
            tramiteTile.Show();

        }

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

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

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

        private void datosTile_Click(object sender, EventArgs e)
        {
            txtBts();
            tabContrlDatGest.Show();
            tabTram.Hide();
            modifOEliminOn = true;
        }

        private void tramiteTile_Click(object sender, EventArgs e)
        {
            txtBts();
            tabContrlDatGest.Hide();
            tabTram.Show();
            modifOEliminOn = true;
        }

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

        private void volverMenuPrincTile_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
