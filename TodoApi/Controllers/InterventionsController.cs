using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterventionsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public InterventionsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/Interventions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Intervention>>> getInterventions()
        {
            return await _context.interventions.Where(intervention => intervention.status == "Pending" && intervention.int_started_at == null).ToListAsync();
        }

        // PUT: 
         [HttpPut("{id}")]
        public async Task<IActionResult> putIntsProgress(int id)
        {
            var inProgress = await _context.interventions.FindAsync(id);
             if (inProgress.status == "Pending")
                {   
                    inProgress.int_started_at = DateTime.UtcNow;
                    inProgress.status = "InProgress";
                }
                _context.interventions.Update(inProgress);
                 await _context.SaveChangesAsync();
                 return Content("Intervention ID " + inProgress.id + " status has changed to: " + inProgress.status);
             
        }[HttpPut("{id}/{status}")]
        public async Task<IActionResult> putIntsComplete([FromRoute] int id, [FromRoute] string status)
        {
            var completed = await _context.interventions.FindAsync(id);
             if (completed.status == "InProgress")
                {   
                    
                    completed.int_ended_at = DateTime.UtcNow;
                    completed.status = "Completed";
                }
                _context.interventions.Update(completed);
                await _context.SaveChangesAsync();
                return Content("Intervention: " + completed.id + ", status has been changed to: " + completed.status);
        }

        private bool InterventionExists(int id)
        {
            return (_context.interventions.Any(e => e.id == id));
        }
    }
}
