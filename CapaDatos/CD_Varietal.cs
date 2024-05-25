using System.Collections.Generic;
using CapaEntidad;

namespace CapaDatos
{
    // Simulación de extracción de datos de varietales en BD
    public class CD_Varietal
    {
        public List<Varietal> lista = new List<Varietal>
        {
            new Varietal
            {
                descripcion = "Malbec puro",
                porcentajeComposicion = 100,
                tipoUva = new TipoUva { nombre = "Malbec", descripcion = "Vino puro de uva Malbec" }
            },
            new Varietal
            {
                descripcion = "Cabernet Sauvignon - Malbec",
                porcentajeComposicion = 70,
                tipoUva = new TipoUva { nombre = "Cabernet Sauvignon", descripcion = "Vino combinado de uva Cabernet Sauvignon y Malbec" }
            },
            new Varietal
            {
                descripcion = "Chardonnay - Viura",
                porcentajeComposicion = 50,
                tipoUva = new TipoUva { nombre = "Chardonnay", descripcion = "Vino combinado de uva Chardonnay y Viura" }
            },
            new Varietal
            {
                descripcion = "Pinot Noir - Carmenere",
                porcentajeComposicion = 60,
                tipoUva = new TipoUva { nombre = "Pinot Noir", descripcion = "Vino combinado de uva Pinot Noir y Carmenere" }
            },
            new Varietal
            {
                descripcion = "Merlot - Tempranillo",
                porcentajeComposicion = 80,
                tipoUva = new TipoUva { nombre = "Merlot", descripcion = "Vino combinado de uva Merlot y Tempranillo" }
            }
        };
    }
}
