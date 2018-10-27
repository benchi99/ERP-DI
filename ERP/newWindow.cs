
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
        public newWindow()
        {
            InitializeComponent();
            dataTabCtrl.Hide();
            tramiteCtrl.Hide();
        }

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
        }

        private void tramiteTile_Click(object sender, EventArgs e)
        {
            dataTabCtrl.Hide();
            tramiteCtrl.Show();
        }

        private void volverTile_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btCancelTram_Click(object sender, EventArgs e)
        {
            tramiteCtrl.Hide();
        }

        private void cancelarBtDat_Click(object sender, EventArgs e)
        {
            dataTabCtrl.Hide();
        }

        private void newWindow_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
