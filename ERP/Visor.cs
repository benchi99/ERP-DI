using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP
{
    public partial class Visor : MetroFramework.Forms.MetroForm
    {
        private string tipoDoc;
        private List<int> ids = new List<int>();

        public Visor()
        {
            InitializeComponent();
        }

        public Visor(string tipoDoc)
        {
            InitializeComponent();
            this.tipoDoc = tipoDoc;
            Text = "Visor de " + tipoDoc;
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OAODKRI\SQLBENCHO;Initial Catalog=Northwind;Integrated Security=True");
            con.Open();
            SqlCommand sql = new SqlCommand("SELECT OrderID FROM dbo.Invoices", con);
            SqlDataReader reader = sql.ExecuteReader();

            while (reader.Read())
            {
                ids.Add(Convert.ToInt32(reader[0]));
            }

            filterCBX.DataSource = ids;
        }

        private void Visor_Load(object sender, EventArgs e)
        {
            if (tipoDoc == "Facturas")
            {
                this.InvoicesTableAdapter.Fill(this.Facturas.Invoices, ids[0]);

                this.reportViewer1.RefreshReport();
            }
            else if (tipoDoc == "Ventas Totales")
            {

            }
            else if (tipoDoc == "Facturas (Subinformes)")
            {

            }
        }

        private void filterCBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.InvoicesTableAdapter.Fill(this.Facturas.Invoices, Int32.Parse(filterCBX.Text.ToString()));

            this.reportViewer1.RefreshReport();
        }
    }
}
