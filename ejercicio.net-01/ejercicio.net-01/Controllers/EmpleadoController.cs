using ejercicio_01.net.Config;
using ejercicio_01.net.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ejercicio_01.net.Controllers
{
    public class EmpleadoController : Controller
    {

        private readonly DBEmpresaContext _context;

        public EmpleadoController(DBEmpresaContext context)
        {
            _context = context;
        }
        [HttpGet("list")]
        public async Task<ActionResult<List<Empleado>>> Get()
        {
            return await _context.Empresa.ToListAsync();
        }

        [HttpPost("save")]
        public async Task<ActionResult> Post(Empleado empleado)
        {
            _context.Add(empleado);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
