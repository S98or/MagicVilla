using MagicVilla_API.Data;
using MagicVilla_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlTypes;

namespace MagicVilla_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaController : ControllerBase
    {
        private readonly ILogger<VillaController> _logger;
        private readonly DataContext _context;

        public VillaController(ILogger<VillaController> logger, DataContext context)
        {
            _logger = logger;
            _context = context;
        }



        [HttpGet(Name = "getVillas")]
        public async Task<ActionResult<IEnumerable<Villa>>> GetVillas() {

            return await _context.Villas.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Villa>> GetVillas(int id)
        {
            var Variable = await _context.Villas.FindAsync(id);

            if (Variable == null)
            {
                return NotFound();
            }

            return Variable;
        }


        [HttpPost(Name = "postVillas")]

        public async Task<ActionResult<Villa>> Post(Villa villas)
        {
            _context.Add(villas);
            await _context.SaveChangesAsync();

            return new CreatedAtRouteResult("Getvillas", new { id = villas.Id }, villas);
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<Villa>> DeleteProducto(int id)
        {
            var ProductoDel = await _context.Villas.FindAsync(id);
            if (ProductoDel == null)
            {
                return NotFound();
            }

            _context.Villas.Remove(ProductoDel);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        private bool ProductItemExists(long id)
        {
            return _context.Villas.Any(e => e.Id == id);
        }
    }



    }
}
