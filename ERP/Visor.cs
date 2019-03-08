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

    /// <summary>
    /// Visor de informes.
    /// </summary>
    /// <seealso cref="MetroFramework.Forms.MetroForm" />
    public partial class Visor : MetroFramework.Forms.MetroForm
    {

        /// <summary>
        /// El tipo de documento.
        /// </summary>
        private string tipoDoc;
        /// <summary>
        /// The ids
        /// </summary>
        private List<int> ids = new List<int>();
        private List<string> nombresCli = new List<string>();


        /// <summary>
        /// Initializes a new instance of the <see cref="Visor"/> class.
        /// </summary>
        public Visor()
        {
            InitializeComponent();
            Text = "Visor de Informes";
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Visor"/> class.
        /// </summary>
        /// <param name="tipoDoc">Èl tipo de formulario que queremos mostrar..</param>
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
            desdeFchCbx.DataSource = devolverTodasLasFechas();
            hastaFchCbx.DataSource = devolverFechasDespuesDe(desdeFchCbx.Text.ToString());

            filtrCbx.Text = "ID";

            this.InvoicesTableAdapter.Fill(this.Facturas.Invoices, ids[0]);
            this.VentasTableAdapter.Fill(this.Facturas.Ventas);            
        }

        /// <summary>
        /// Handles the Load event of the Visor control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Handles the SelectedIndexChanged event of the filterCBX control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Handles the SelectedIndexChanged event of the filtrCbx control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void filtrCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(filtrCbx.Text.ToString() == "ID")
            {
                cliLbl.Visible = false;
                cliFiltrCBX.Visible = false;
                desdeFchLbl.Visible = false;
                desdeFchCbx.Visible = false;
                hastaFchLbl.Visible = false;
                hastaFchCbx.Visible = false;
                factIdLbl.Visible = true;
                filterCBX.Visible = true;
                filterCBX.DataSource = ids;
            } else if (filtrCbx.Text.ToString() == "Cliente")
            {
                cliLbl.Visible = true;
                cliFiltrCBX.Visible = true;
                desdeFchLbl.Visible = false;
                desdeFchCbx.Visible = false;
                hastaFchLbl.Visible = false;
                hastaFchCbx.Visible = false;
                factIdLbl.Visible = true;
                filterCBX.Visible = true;
                filterCBX.DataSource = devolverFactsCli(cliFiltrCBX.Text.ToString());
            } else if (filtrCbx.Text.ToString() == "Fecha") 
            {
                cliLbl.Visible = false;
                cliFiltrCBX.Visible = false;
                desdeFchLbl.Visible = true;
                desdeFchCbx.Visible = true;
                hastaFchLbl.Visible = true;
                hastaFchCbx.Visible = true;
                factIdLbl.Visible = true;
                filterCBX.Visible = true;
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the cliFiltrCBX control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cliFiltrCBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterCBX.DataSource = devolverFactsCli(cliFiltrCBX.Text.ToString());
        }

        /// <summary>
        /// Devuelve una lista con los IDs de pedido del cliente especificado si existe.
        /// </summary>
        /// <param name="nombre">El nombre del cliente.</param>
        /// <returns>Lista con todas las facturas del cliente especificado</returns>
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

        /// <summary>
        /// Devuelve una lista con todas las fechas de factura de la base de datos.
        /// </summary>
        /// <returns>Lista con todas las fechas.</returns>
        private List<string> devolverTodasLasFechas()
        {
            List<string> fechas = new List<string>();

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OAODKRI\SQLBENCHO;Initial Catalog=Northwind;Integrated Security=True");
            con.Open();
            SqlCommand sql = new SqlCommand("SELECT OrderDate FROM dbo.Invoices GROUP BY OrderDate", con);
            SqlDataReader reader = sql.ExecuteReader();

            while (reader.Read())
            {
                fechas.Add(reader[0].ToString().Substring(0, 9));
            }

            reader.Close();
            con.Close();

            return fechas;
        }

        /// <summary>
        /// Devuelve una lista con todas las fechas posteriores a la especificada.
        /// </summary>
        /// <param name="fecha">Fecha mínima</param>
        /// <returns>Lista con las fechas que coinciden con el parámetro</returns>
        private List<string> devolverFechasDespuesDe(string fecha)
        {
            List<string> fechasPosteriores = new List<string>();

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OAODKRI\SQLBENCHO;Initial Catalog=Northwind;Integrated Security=True");
            con.Open();
            SqlCommand sql = new SqlCommand("SELECT OrderDate FROM dbo.Invoices WHERE CAST(OrderDate AS Date) >= '" + fecha + "' GROUP BY OrderDate", con);
            SqlDataReader reader = sql.ExecuteReader();

            while (reader.Read())
            {
                fechasPosteriores.Add(reader[0].ToString().Substring(0,9));
            }
            
            return fechasPosteriores;
        }

        /// <summary>
        /// Devuelve IDs de Facturas de pedidos que hayan sido realizados
        /// comprendidos entre ambas fechas.
        /// </summary>
        /// <param name="fecha1"></param>
        /// <param name="fecha2"></param>
        /// <returns>IDs de pedidos realizados comprendidos entre estas fechas.</returns>
        private List<int> devolverFacturasComprendidasEntreFecha(string fecha1, string fecha2)
        {
            List<int> fechIds = new List<int>();

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OAODKRI\SQLBENCHO;Initial Catalog=Northwind;Integrated Security=True");
            con.Open();
            SqlCommand sql = new SqlCommand("SELECT OrderID FROM dbo.Invoices WHERE CAST(OrderDate AS Date) >= '" + fecha1 + "' AND CAST(OrderDate AS Date) <= '" + fecha2 + "' GROUP BY OrderID", con);
            SqlDataReader reader = sql.ExecuteReader();

            while (reader.Read())
            {
                fechIds.Add(Convert.ToInt32(reader[0]));
            }

            return fechIds;
        }

        /// <summary>
        /// Handler del evento SelectedIndexChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hastaFchCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterCBX.DataSource = devolverFacturasComprendidasEntreFecha(desdeFchCbx.Text.ToString(), hastaFchCbx.Text.ToString());
        }
    }
}
