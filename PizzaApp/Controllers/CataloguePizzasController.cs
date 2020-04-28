using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzaApp.Database.Context;
using PizzaApp.Database.Models;

namespace PizzaApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CataloguePizzasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CataloguePizzasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/CataloguePizzas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CataloguePizza>>> GetCataloguePizzas()
        {
            return await _context.CataloguePizzas.ToListAsync();
        }

        // GET: api/CataloguePizzas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CataloguePizza>> GetCataloguePizza(int id)
        {
            var cataloguePizza = await _context.CataloguePizzas.FindAsync(id);

            if (cataloguePizza == null)
            {
                return NotFound();
            }

            return cataloguePizza;
        }

        // PUT: api/CataloguePizzas/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCataloguePizza(int id, CataloguePizza cataloguePizza)
        {
            if (id != cataloguePizza.NumPizza)
            {
                return BadRequest();
            }

            _context.Entry(cataloguePizza).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CataloguePizzaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/CataloguePizzas
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CataloguePizza>> PostCataloguePizza(CataloguePizza cataloguePizza)
        {
            _context.CataloguePizzas.Add(cataloguePizza);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCataloguePizza", new { id = cataloguePizza.NumPizza }, cataloguePizza);
        }

        // DELETE: api/CataloguePizzas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CataloguePizza>> DeleteCataloguePizza(int id)
        {
            var cataloguePizza = await _context.CataloguePizzas.FindAsync(id);
            if (cataloguePizza == null)
            {
                return NotFound();
            }

            _context.CataloguePizzas.Remove(cataloguePizza);
            await _context.SaveChangesAsync();

            return cataloguePizza;
        }

        private bool CataloguePizzaExists(int id)
        {
            return _context.CataloguePizzas.Any(e => e.NumPizza == id);
        }
    }
}
