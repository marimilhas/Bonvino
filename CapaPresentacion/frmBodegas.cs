using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmBodegas : Form
    {
        public frmBodegas() // constructor de la clase
        {
            InitializeComponent();
            mostrarBodegasActualizables();
        }

        private void mostrarBodegasActualizables() 
        {
            List<string> actualizables = new CN_Bodega().buscarBodegasActualizables();

            // Para probar que no haya bodegas actualizables
            // List<string> actualizables = new List<string>(); 

            if (actualizables.Count == 0)
            {
                Label lbl = this.Controls["label1"] as Label;

                lbl.Text = "No hay bodegas con actualizaciones disponibles";
                lbl.Visible = true;
            
                dataGridView1.DataSource = null;
                dataGridView1.Visible = false;
            } else
            {
                dataGridView1.Rows.Clear();
                foreach (string actualizable in actualizables)
                {
                    dataGridView1.Rows.Add(actualizable, "");
                }
            }
        }
        
    }
}
