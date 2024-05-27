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
            dataGridView1.Rows.Clear();
            foreach (string actualizable in actualizables)
            {
                dataGridView1.Rows.Add(actualizable,"");
            }
        }
    }
}
