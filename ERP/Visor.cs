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
        private List<string> filtro = new List<string>();
        SoundPlayer midi;

        public Visor()
        {
            InitializeComponent();
            Text = "Visor de Informes";
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

            idCBX.DataSource = ids;
        }

        private void Visor_Load(object sender, EventArgs e)
        {
            if (tipoDoc == "Facturas")
            {
                filtro.Add("ID de Factura");
                filtro.Add("Cliente");


                this.InvoicesTableAdapter.Fill(this.Facturas.Invoices, ids[0]);

                this.reportViewer1.RefreshReport();
            }
            else if (tipoDoc == "Ventas Totales")
            {

            }
            else if (tipoDoc == "Facturas (Subinformes)")
            {

            }

            reproducirMIDI(Path.Combine(Environment.CurrentDirectory, @"res\sound\", "gth.wav"));
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
    }
}
