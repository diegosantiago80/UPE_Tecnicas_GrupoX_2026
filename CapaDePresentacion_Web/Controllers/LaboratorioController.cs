using Microsoft.AspNetCore.Mvc;
using CapaDeLogicaDeNegocio_BLL;
using CapaDeEntidades;
using System.Collections.Generic;

namespace CapaPresentacion_Web.Controllers
{
    // CU-INV0004 Gestionar laboratorios proveedores (ABM)
    // pendiente de implementar, mientras tanto cae al fallback "en construccion"
    public class LaboratorioController : Controller
    {
        private readonly LaboratorioBLL _laboratorioBLL = new LaboratorioBLL();

        public IActionResult Index()
        {
            return NotFound();
        }
    }
}
