using Microsoft.Reporting.WinForms;
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

            this.InvoicesTableAdapter.Fill(this.Facturas.Invoices, ids[0]);
            this.VentasTableAdapter.Fill(this.Facturas.Ventas);
        }

        private void Visor_Load(object sender, EventArgs e)
        {
            this.reportViewer1.Reset();
            var bind = new BindingSource();


            if (tipoDoc == "Facturas")
            {
                bind.DataSource = this.Facturas.Invoices;
                ReportDataSource rds = new ReportDataSource("Facturas", bind);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(rds);
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "ERP.Facturas.rdlc";
            }
            else if (tipoDoc == "Ventas Totales")
            {
                bind.DataSource = this.Facturas.Ventas;
                ReportDataSource rds = new ReportDataSource("Ventas", bind);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(rds);
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "ERP.Ventas.rdlc";
            }
            else if (tipoDoc == "Facturas (Subinformes)")
            {

            }

            this.reportViewer1.RefreshReport();
        }

        private void filterCBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.InvoicesTableAdapter.Fill(this.Facturas.Invoices, Int32.Parse(filterCBX.Text.ToString()));

            this.reportViewer1.RefreshReport();
        }
    }
}
