using Entities;
using System.Security.Cryptography.X509Certificates;

namespace MAUI_UD8_EJ5_DAL
{
    /// <summary>
    /// clase para los listados (DAL)
    /// </summary>
    public class ClsListados
    {

        /// <summary>
        /// funcion para crear el listado de personas
        /// </summary>
        /// <returns></returns>
        public static List<ClsPersona> ListadoPersonas()
        {
            List<ClsPersona> listado = new List<ClsPersona>();



            // Añadir personas al listado
            listado.Add(new ClsPersona(1, "Juan", "Pérez", new DateTime(1990, 5, 15), "Calle Falsa 123", "foto1.jpg", "555-1234", 1));
            listado.Add(new ClsPersona(2, "María", "González", new DateTime(1985, 3, 20), "Avenida Siempre Viva 742", "foto2.jpg", "555-5678", 2));
            listado.Add(new ClsPersona(3, "Carlos", "Sánchez", new DateTime(2000, 12, 10), "Boulevard de los Sueños Rotos", "foto3.jpg", "555-8765", 1));
            listado.Add(new ClsPersona(4, "Laura", "Martínez", new DateTime(1995, 8, 25), "Plaza de la Paz 456", "foto4.jpg", "555-4321", 2));
            listado.Add(new ClsPersona(5, "Miguel", "Hernández", new DateTime(1992, 7, 30), "Calle de la Amistad 89", "foto5.jpg", "555-1122", 1));



            return listado;
        }



    }
}
