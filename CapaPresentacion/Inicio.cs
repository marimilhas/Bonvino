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
        public Inicio()
        {
            InitializeComponent();
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
        
        
        private void opcionImportarActualizacionBodega(object sender, EventArgs e)
        {
            habilitarPantalla((IconMenuItem)sender, new frmBodegas());
        }


        // eliminar metodos de abajo - ver luego ahora no tengo ganas
        private void contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
