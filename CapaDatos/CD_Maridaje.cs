using System.Collections.Generic;
using CapaEntidad;

namespace CapaDatos
{
    // Simulación de extracción de datos de maridajes en BD
    public class CD_Maridaje
    {
        public List<Maridaje> maridajes = new List<Maridaje>
        {
            new Maridaje { nombre = "Carne Asada", descripcion = "Perfecto para carnes rojas a la parrilla." },
            new Maridaje { nombre = "Pescado Blanco", descripcion = "Ideal para acompañar pescados blancos." },
            new Maridaje { nombre = "Quesos Maduros", descripcion = "Marida bien con quesos maduros y curados." },
            new Maridaje { nombre = "Chocolate Amargo", descripcion = "Excelente con postres de chocolate amargo." }
        };
    }
}
