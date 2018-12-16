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
    public partial class newUserWindow : MetroFramework.Forms.MetroForm
    {

        int id = 0;

        string nombre;
        string apellidos;
        int doc;
        string sexo;
        int telefonoFijo;
        int telefonoMovil;
        string fecha;
        string email;
        int identificador;
        string nombreUsuario;
        string contraseña;
        DateTime fechaHoy;
        DateTime fechaNac;

        public newUserWindow()
        {
            InitializeComponent();
        }

        private void newUserWindow_Load(object sender, EventArgs e)
        {
            fechaHoy = DateTime.Now;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();

            opd.Filter = "Imagenes|*.jpg;*.png";
            opd.Title = "Abrir Imagen";

            if (opd.ShowDialog() == DialogResult.OK)
            {
                string url = opd.FileName;
                string nombre = opd.SafeFileName;

                pfp.SizeMode = PictureBoxSizeMode.CenterImage;
                pfp.SizeMode = PictureBoxSizeMode.Zoom;
                pfp.Load(url);

            }
        }

        private void vaciar()
        {
            pfp.Load("");
            nombretb.Text = "";
            nombreUs.Text = "";
            docType.Text = "";
            document.Text = "";
            sexoCb.Text = "";
            fijo.Text = "";
            movil.Text = "";
            fechanac.Text = "";
            emil.Text = "";
            passUs.Text = "";
            confPassUs.Text = "";
            lvlUs.Text = "";

        }

        private void clearUser_Click(object sender, EventArgs e)
        {
            vaciar();
        }

        private void cancelUser_Click(object sender, EventArgs e)
        {
            vaciar();
            this.Hide();
        }

        private void nombretb_TextChanged(object sender, EventArgs e)
        {
            id++;
            idGener.Text = id.ToString();
        }

        private void okUser_Click(object sender, EventArgs e)
        {
            bool valido = false;

            nombre = nombretb.Text;
            apellidos = apellidostb.Text;
            doc = int.Parse(document.Text);
            sexo = sexoCb.Text;
            telefonoFijo = int.Parse(fijo.Text);
            telefonoMovil = int.Parse(movil.Text);
            fechaNac = new DateTime(int.Parse(fechanac.Value.ToString("yyyy")), int.Parse(fechanac.Value.ToString("MM")), int.Parse(fechanac.Value.ToString("dd")));
            
        }
    }
}
