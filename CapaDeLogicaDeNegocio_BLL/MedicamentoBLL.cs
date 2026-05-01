using CapaDeAccesoADatos_DAL;
using CapaDeEntidades;
using System.Collections.Generic;

namespace CapaDeLogicaDeNegocio_BLL
{
    // delega la persistencia al dal y aplica reglas de dominio
    public class MedicamentoBLL
    {
        private readonly MedicamentoDAL _medicamentoDAL = new MedicamentoDAL();

        public List<Medicamento> ObtenerTodos()
        {
            return _medicamentoDAL.ObtenerTodos();
        }

        public List<Medicamento> ObtenerCriticos()
        {
            return _medicamentoDAL.ObtenerCriticos();
        }

        public bool ProcesarIngresoStock(List<Medicamento> itemsComprados)
        {
            // si no hay items no hay nada que sumar al stock
            if (itemsComprados == null || itemsComprados.Count == 0)
            {
                return false;
            }

            return _medicamentoDAL.ActualizarStockPorIngreso(itemsComprados);
        }
    }
}
