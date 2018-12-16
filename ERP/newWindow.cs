
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
    public partial class newWindow : MetroFramework.Forms.MetroForm
    {

        bool volverPuls = false;
        bool tramitODatOn = false;

        public newWindow()
        {
            InitializeComponent();
            dataTabCtrl.Hide();
            tramiteCtrl.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            /*
             * ESTAS LINEAS SI LA BASE DE DATOS NO ESTÁ INSTALADA HARÁ QUE CRASHEE EL PROGRAMA
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
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        private void tileAñadDatos_Click(object sender, EventArgs e)
        {
            tramiteCtrl.Hide();
            dataTabCtrl.Show();
            tramitODatOn = true;
        }

        private void tramiteTile_Click(object sender, EventArgs e)
        {
            dataTabCtrl.Hide();
            tramiteCtrl.Show();
            tramitODatOn = true;
        }

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
        }

        private void btCancelTram_Click(object sender, EventArgs e)
        {
            tramiteCtrl.Hide();
            tramitODatOn = false;
        }

        private void cancelarBtDat_Click(object sender, EventArgs e)
        {
            dataTabCtrl.Hide();
            tramitODatOn = false;
        }

        private void cancelArtDat_Click(object sender, EventArgs e)
        {
            dataTabCtrl.Hide();
            tramitODatOn = false;
        }

        private void cancelProvBt_Click(object sender, EventArgs e)
        {
            dataTabCtrl.Hide();
            tramitODatOn = false;
        }

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
