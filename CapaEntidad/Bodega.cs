using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Spatial;


namespace CapaEntidad
{
    public class Bodega
    {
        public string nombre {  get; set; }
        public string descripcion { get; set;}
        public string historia { get; set;}
        public string coordenadasUbicacion { get; set; }
        public DateTime fechaUltimaActualizacion { get; set; }
        public int periodoActualizacion { get; set;} //en meses

        public bool tieneActualizacionNovedadesVino(DateTime fechaActual)
        {
            int diferencia = (fechaActual.Year - fechaUltimaActualizacion.Year) * 12
                        + fechaActual.Month - fechaUltimaActualizacion.Month;

            if (fechaActual.Day < fechaUltimaActualizacion.Day)
            {
                diferencia--; 
            }
            
            return diferencia >= periodoActualizacion;
        }
    }
}
