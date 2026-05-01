using CapaDeAccesoADatos_DAL;
using CapaDeEntidades;
using System.Collections.Generic;

namespace CapaDeLogicaDeNegocio_BLL
{
    // por ahora solo lista, en proximas entregas se suma el abm
    public class LaboratorioBLL
    {
        private readonly LaboratorioDAL _laboratorioDAL = new LaboratorioDAL();

        public List<Laboratorio> ObtenerTodos()
        {
            return _laboratorioDAL.ObtenerTodos();
        }
    }
}
