using System;
using System.Collections.Generic;
using CapaEntidad;

namespace CapaDatos
{
    // Simulación de extracción de datos de bodega en BD
    public class CD_Bodega
    {
        public List<Bodega> lista = new List<Bodega>()
        {
            new Bodega
            {
                nombre = "Bodega Aconcagua",
                descripcion = "Bodega fundada en 1890, especializada en vinos tintos.",
                historia = "Historia rica en tradición vitivinícola.",
                coordenadasUbicacion = "-33.9238, 18.4232",
                fechaUltimaActualizacion = DateTime.Now, //VER
                periodoActualizacion = 12 //VER
            },
            new Bodega
            {
                nombre = "Bodega Maipo",
                descripcion = "Bodega centenaria conocida por sus vinos de alta gama.",
                historia = "Fue fundada en 1905 por inmigrantes italianos.",
                coordenadasUbicacion = "-33.4691, -70.6420",
                fechaUltimaActualizacion = DateTime.Now, //VER
                periodoActualizacion = 6 //VER
            },
            new Bodega
            {
                nombre = "Bodega Rioja",
                descripcion = "Bodega familiar desde 1875, especializada en vinos reserva.",
                historia = "Ha sido gestionada por seis generaciones de la familia Rioja.",
                coordenadasUbicacion = "42.4602, -2.4455", //VER
                fechaUltimaActualizacion = DateTime.Now,
                periodoActualizacion = 8 //VER
            },
            new Bodega
            {
                nombre = "Bodega Napa Valley",
                descripcion = "Una de las bodegas más prestigiosas de California, conocida por sus vinos de alta calidad.",
                historia = "Fundada en 1882, es un ícono en la historia vitivinícola de Estados Unidos.",
                coordenadasUbicacion = "38.5025, -122.2654",
                fechaUltimaActualizacion = DateTime.Now, //VER
                periodoActualizacion = 10 //VER
            }
        };
    }
}
