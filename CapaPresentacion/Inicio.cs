using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static IconMenuItem menuActivo = null;
        private static Form formularioActivo = null;

        public Inicio() // contructor de la clase, no tocar pq se rompe todo
        {
            InitializeComponent();
        }

        public void opcionImportarActualizacionBodega(object sender, EventArgs e) // ?? no se si es para eso pero va si o si
        {
            habilitarPantalla((IconMenuItem)sender, new frmBodegas());
        }
        private void habilitarPantalla(IconMenuItem menu, Form formulario)
        {
            // tiene sentido si están desarrolladas las demás opciones
            if (menuActivo != null) {
                menuActivo.BackColor = Color.White;
            }

            menu.BackColor = Color.Silver;
            menuActivo = menu;

            if (formularioActivo != null){
                formularioActivo.Close();
            }

            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.White;

            contenedor.Controls.Add(formulario);
            formulario.Show();
        }
    }
}
