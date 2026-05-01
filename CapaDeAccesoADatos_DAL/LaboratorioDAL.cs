using CapaDeEntidades;
using System.Collections.Generic;

namespace CapaDeAccesoADatos_DAL
{
    //lista en memoria para 1era entrega, sp en la 2da.
    public class LaboratorioDAL
    {
        private static List<Laboratorio> _laboratorios = new List<Laboratorio>
        {
            new Laboratorio(1, "Bayers S.A.", "30-12345678-9", "11-4444-5555", "ventas@bayer.com", "Calle Falsa 123", true),
            new Laboratorio(2, "Roemmers", "30-87654321-0", "11-2222-3333", "contacto@roemmers.com", "Av. Santa Fe 456", true),
            new Laboratorio(3, "Bagó", "30-55556666-1", "11-9999-8888", "info@bago.com.ar", "Rivadavia 789", true)
        };

        public List<Laboratorio> ObtenerTodos()
        {
            return _laboratorios;
        }
    }
}
