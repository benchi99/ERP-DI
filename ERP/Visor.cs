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
using System.Media;
using System.IO;

namespace ERP
{
    public partial class Visor : MetroFramework.Forms.MetroForm
    {
        private string tipoDoc;
        private List<int> ids = new List<int>();
        private List<string> nombresCli = new List<string>();

        public Visor()
        {
            InitializeComponent();
            Text = "Visor de Informes";
        }

        public Visor(string tipoDoc)
        {
            InitializeComponent();
            filterCBX.Visible = false;
            cliFiltrCBX.Visible = false;
            cliLbl.Visible = false;
            factIdLbl.Visible = false;
            this.tipoDoc = tipoDoc;
            Text = "Visor de " + tipoDoc;
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OAODKRI\SQLBENCHO;Initial Catalog=Northwind;Integrated Security=True");
            con.Open();
            SqlCommand sql = new SqlCommand("SELECT OrderID FROM dbo.Invoices GROUP BY OrderID", con);
            SqlDataReader reader = sql.ExecuteReader();

            while (reader.Read())
            {
                ids.Add(Convert.ToInt32(reader[0]));
            }

            reader.Close();

            sql.CommandText = "SELECT Salesperson FROM dbo.Invoices GROUP BY Salesperson";
            reader = sql.ExecuteReader();

            while (reader.Read()){
                nombresCli.Add(Convert.ToString(reader[0]));
            }

            reader.Close();
            con.Close();

            filterCBX.DataSource = ids;
            cliFiltrCBX.DataSource = nombresCli;

            filtrCbx.Text = "ID";

            this.InvoicesTableAdapter.Fill(this.Facturas.Invoices, ids[0]);
            this.VentasTableAdapter.Fill(this.Facturas.Ventas);            
        }

        private void Visor_Load(object sender, EventArgs e)
        {
            this.reportViewer1.Reset();
            var bind = new BindingSource();
            
            if (tipoDoc == "Facturas")
            {
                this.InvoicesBindingSource.DataMember = "Invoices";
                this.InvoicesBindingSource.DataSource = this.Facturas;
                bind.DataSource = this.Facturas.Invoices;
                ReportDataSource rds = new ReportDataSource("Facturas", bind);
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "ERP.Facturas.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(rds);
            }
            else if (tipoDoc == "Ventas Totales")
            {
                filterLb.Enabled = false;
                filtrCbx.Enabled = false;
                this.InvoicesBindingSource.DataMember = "Ventas";
                this.InvoicesBindingSource.DataSource = this.Facturas;
                bind.DataSource = this.Facturas.Ventas;
                ReportDataSource rds = new ReportDataSource("Ventas", bind);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(rds);
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "ERP.Ventas.rdlc";
            }
            else if (tipoDoc == "Facturas (Subinformes)")
            {
                filterLb.Enabled = false;
                filtrCbx.Enabled = false;
                this.InvoicesBindingSource.DataMember = "Invoices";
                this.InvoicesBindingSource.DataSource = this.Facturas;
                bind.DataSource = this.Facturas.Ventas;
                ReportDataSource rds = new ReportDataSource("FacturasSubinf", bind);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(rds);
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "ERP.FacturaSubinf.rdlc";
            }

            this.reportViewer1.RefreshReport();
        }

        private void reproducirMIDI(string archivo)
        {
            midi = new SoundPlayer();
            midi.SoundLocation = archivo;
            midi.Load();
            midi.PlayLooping();
        }

        private void filterCBX_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Visor_FormClosing(object sender, FormClosingEventArgs e)
        {
            midi.Stop();
        }

        private void idCBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.InvoicesTableAdapter.Fill(this.Informes.Invoices, Int32.Parse(idCBX.Text.ToString()));

            this.reportViewer1.RefreshReport();
        }

        private void filtrCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(filtrCbx.Text.ToString() == "ID")
            {
                cliLbl.Visible = false;
                cliFiltrCBX.Visible = false;
                factIdLbl.Visible = true;
                filterCBX.Visible = true;
                filterCBX.DataSource = ids;
            } else if (filtrCbx.Text.ToString() == "Cliente")
            {
                cliLbl.Visible = true;
                cliFiltrCBX.Visible = true;
                factIdLbl.Visible = true;
                filterCBX.Visible = true;
                filterCBX.DataSource = devolverFactsCli(cliFiltrCBX.Text.ToString());
            }
        }

        private void cliFiltrCBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterCBX.DataSource = devolverFactsCli(cliFiltrCBX.Text.ToString());
        }

        private List<int> devolverFactsCli(string nombre)
        {
            List<int> cliIds = new List<int>();

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OAODKRI\SQLBENCHO;Initial Catalog=Northwind;Integrated Security=True");
            con.Open();
            SqlCommand sql = new SqlCommand("SELECT OrderID FROM dbo.Invoices WHERE Salesperson = '" + nombre + "' GROUP BY OrderID", con);
            SqlDataReader reader = sql.ExecuteReader();

            while (reader.Read())
            {
                cliIds.Add(Convert.ToInt32(reader[0]));
            }

            reader.Close();
            con.Close();

            return cliIds;

        }
    }
}
