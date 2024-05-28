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
        private CN_Bodega objcn_bodega = new CN_Bodega(); // instancia de la capa de negocio
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

        private void tomarSeleccionBodega(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["btnseleccionar"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                string nombreBodega = fila.Cells["nombre"].Value.ToString();

                objcn_bodega.tomarSeleccionBodega(nombreBodega); 

                // Lo guardo de prueba por el momento
                MessageBox.Show($"Bodega seleccionada: {nombreBodega}");
            }

        }

        private void frmBodegas_Load(object sender, EventArgs e)
        {

        }
    }
}
