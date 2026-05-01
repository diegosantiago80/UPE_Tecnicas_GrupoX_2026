using Microsoft.AspNetCore.Mvc;
using CapaDeLogicaDeNegocio_BLL;
using CapaDeEntidades;           
using System.Collections.Generic;

namespace CapaPresentacion_Web.Controllers
{
    public class MedicamentoController : Controller
    {
        private readonly MedicamentoBLL _medicamentoBLL = new MedicamentoBLL();

        public IActionResult Index(bool soloCriticos = false)
        {
            List<Medicamento> lista;

            if (soloCriticos)
            {
                lista = _medicamentoBLL.ObtenerCriticos();
                ViewData["Titulo"] = "Alertas de Stock Crítico";
            }
            else
            {
                lista = _medicamentoBLL.ObtenerTodos();
                ViewData["Titulo"] = "Panel de Control de Stock";
            }

            return View(lista);
        }

        // CU-INV0003 Gestionar medicamentos (ABM)
        // pendiente de implementar, mientras tanto cae al fallback "en construccion"
        public IActionResult Gestionar()
        {
            return NotFound();
        }
    }
}