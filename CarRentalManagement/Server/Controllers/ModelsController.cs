using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement.Shared.Models;
using CarRentalManagement.Server.Contracts;

namespace CarRentalManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ModelsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: /Models
        [HttpGet]
        public async Task<IActionResult> GetModels()
        {
            var models = await _unitOfWork.Models.GetAllAsync();
            return Ok(models);
        }

        // GET: /Models/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetModel(int id)
        {
            var model = await _unitOfWork.Models.GetAsync(q => q.Id == id);

            if (model == null)
            {
                return NotFound();
            }

            return Ok(model);
        }

        // PUT: /Models/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutModel(int id, Model model)
        {
            if (id != model.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Models.Update(model);

            try
            {
                await _unitOfWork.SaveAsync(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ModelExists(id))
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

        // POST: /Models
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Model>> PostModel(Model model)
        {
            await _unitOfWork.Models.InsertAsync(model);
            await _unitOfWork.SaveAsync(HttpContext);

            return CreatedAtAction("GetModel", new { id = model.Id }, model);
        }

        // DELETE: /Models/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteModel(int id)
        {
            var model = await _unitOfWork.Models.GetAsync(q => q.Id == id);
            if (model == null)
            {
                return NotFound();
            }

            await _unitOfWork.Models.DeleteAsync(id);
            await _unitOfWork.SaveAsync(HttpContext);

            return NoContent();
        }

        private async Task<bool> ModelExists(int id)
        {
            var model = await _unitOfWork.Models.GetAsync(q => q.Id == id);
            return model != null;
        }
    }
}
