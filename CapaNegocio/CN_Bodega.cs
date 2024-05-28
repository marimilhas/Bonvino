using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Bodega
    {
        private CD_Bodega objcd_bodega = new CD_Bodega(); // instancia de la capa de datos
        private List<string> bodegasSeleccionadas = new List<string>();

        public void opcionImportarActualizacionBodegas() //?? no sé q hay q poner ahi pero de que va va
        {

        }

        private DateTime obtenerFechaActual()
        {
            return DateTime.Now.Date;
        }

        public List<string> buscarBodegasActualizables()
        {
            DateTime fechaActual = DateTime.Now.Date;
            List<Bodega> bodegas = objcd_bodega.Listar();
            List<string> nombresActualizables = new List<string>();

            foreach (Bodega bodega in bodegas)
            {
                if (bodega.tieneActualizacionNovedadesVino(fechaActual))
                {
                    nombresActualizables.Add(bodega.nombre);
                }
            }
            return nombresActualizables;
        }

        public void tomarSeleccionBodega(string nombreBodega)
        {
            bodegasSeleccionadas.Add(nombreBodega);
        }
    }
}
