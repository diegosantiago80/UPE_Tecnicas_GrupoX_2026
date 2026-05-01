using Microsoft.AspNetCore.Mvc;
using CapaDeLogicaDeNegocio_BLL;
using CapaDeEntidades;
using System.Collections.Generic;

namespace CapaPresentacion_Web.Controllers
{
    public class CompraController : Controller
    {
        private readonly MedicamentoBLL _medicamentoBLL = new MedicamentoBLL();
        private readonly LaboratorioBLL _laboratorioBLL = new LaboratorioBLL();

        public IActionResult Registrar()
        {
            // los combos del form se arman desde la bll
            ViewBag.Laboratorios = _laboratorioBLL.ObtenerTodos();
            ViewBag.Medicamentos = _medicamentoBLL.ObtenerTodos();

            return View();
        }

        [HttpPost]
        public IActionResult Procesar([FromBody] List<Medicamento> items)
        {
            if (items == null || items.Count == 0)
            {
                return BadRequest("La lista de productos está vacía.");
            }

            bool exito = _medicamentoBLL.ProcesarIngresoStock(items);

            if (exito)
            {
                return Ok(new { mensaje = "¡Stock actualizado correctamente!" });
            }
            else
            {
                return StatusCode(500, "Ocurrió un error al procesar la compra.");
            }
        }
    }
}