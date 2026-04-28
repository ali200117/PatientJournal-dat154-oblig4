using BackendApi.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SharedLibrary.Models;


namespace BackendApi.Controllers
{


    [ApiController]
    [Route("api/[Controller]")]

    public class PatientCasesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PatientCasesController(AppDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<List<PatientCase>>> GetAll()
        {
            return await _context.PatientCases.ToListAsync();
        }

        [HttpGet("active")]

        public async Task<ActionResult<PatientCase>> GetActive()
        {
            var patientCase = await _context.PatientCases
                .FirstOrDefaultAsync(c => c.Active);

            if(patientCase == null)
            {
                return NotFound();
            }
            return patientCase;

        }



        [HttpPost]
        public async Task<ActionResult<PatientCase>> Create(PatientCase patientCase)
        {
            _context.PatientCases.Add(patientCase);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAll), new { id = patientCase.Id }, patientCase);
        }




        [HttpPut("{id}/activate")]
        public async Task<IActionResult> Activate(int id)
        {
            var cases = await _context.PatientCases.ToListAsync();

            foreach (var patientCase in cases)
            {
                patientCase.Active = patientCase.Id == id;
            }

            await _context.SaveChangesAsync();

            return NoContent();
        }



    }






}
