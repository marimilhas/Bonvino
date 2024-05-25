using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Varietal
    {
        //private int varietalId {  get; set; }
        public string descripcion {  get; set; }
        public float porcentajeComposicion { get; set; }
        public TipoUva tipoUva { get; set; }

    }
}
