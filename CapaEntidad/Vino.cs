using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Vino
    {
        public string nombre { get; set; }
        public int añada { get; set; }
        public string notaDeCataBodega {  get; set; }
        public decimal precioArs {  get; set; }
        public DateTime fechaActualizacion {  get; set; }
        public string imagenEtiqueta { get; set; } // Nombre de archivo simulado
        public List<Varietal> varietal { get; set; } //Uno a muchos 
        public List<Maridaje> maridaje { get; set; } //Cero a muchos
        public Bodega bodega { get; set; }
    }
}
