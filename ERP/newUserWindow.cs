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
    /// Ventana nuevo usuario
    /// </summary>
    /// <seealso cref="MetroFramework.Forms.MetroForm" />
    public partial class newUserWindow : MetroFramework.Forms.MetroForm
    {

        int id = 0;

        string nombre;
        string apellidos;
        string doc;
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

        /// <summary>
        /// Initializes a new instance of the <see cref="newUserWindow"/> class.
        /// </summary>
        public newUserWindow()
        {
            InitializeComponent();
            if (GlobalProperties.getDarkMode() == true)
                this.Theme = MetroFramework.MetroThemeStyle.Dark;
            else if (GlobalProperties.getDarkMode() == false)
                this.Theme = MetroFramework.MetroThemeStyle.Light;
        }

        /// <summary>
        /// Handles the Load event of the newUserWindow control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void newUserWindow_Load(object sender, EventArgs e)
        {
            fechaHoy = DateTime.Now;
        }

        /// <summary>
        /// Handles the Click event of the metroButton1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Vacia el formulario.
        /// </summary>
        private void vaciar()
        {
            pfp.Load("");
            nombretb.Text = "";
            nombreUs.Text = "";
            docType.Text = "";
            document.Text = "";
            fijo.Text = "";
            movil.Text = "";
            fechanac.Text = "";
            emil.Text = "";
            passUs.Text = "";
            confPassUs.Text = "";
            lvlUs.Text = "";

        }

        /// <summary>
        /// Handles the Click event of the clearUser control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void clearUser_Click(object sender, EventArgs e)
        {
            vaciar();
        }

        /// <summary>
        /// Handles the Click event of the cancelUser control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cancelUser_Click(object sender, EventArgs e)
        {
            vaciar();
            this.Hide();
        }

        /// <summary>
        /// Handles the TextChanged event of the nombretb control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void nombretb_TextChanged(object sender, EventArgs e)
        {
            id++;
        }

        /// <summary>
        /// Handles the Click event of the okUser control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void okUser_Click(object sender, EventArgs e)
        {
            bool valido = false;

            nombre = nombretb.Text;
            apellidos = apellidostb.Text;
            doc = document.Text;
            telefonoFijo = int.Parse(fijo.Text);
            telefonoMovil = int.Parse(movil.Text);
            fechaNac = new DateTime(int.Parse(fechanac.Value.ToString("yyyy")), int.Parse(fechanac.Value.ToString("MM")), int.Parse(fechanac.Value.ToString("dd")));
            
        }

        
    }
}
