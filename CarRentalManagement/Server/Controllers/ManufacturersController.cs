using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement.Server.Data;
using CarRentalManagement.Shared.Models;
using CarRentalManagement.Server.Contracts;
using CarRentalManagement.Server.Repository;

namespace CarRentalManagement.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ManufacturersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ManufacturersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: /Manufacturers
        [HttpGet]
        public async Task<IActionResult> GetManufacturers()
        {
            var manufacturers = await _unitOfWork.Manufacturers.GetAllAsync();
            return Ok(manufacturers);
        }

        // GET: /Manufacturers/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetManufacturer(int id)
        {
            var manufacturer = await _unitOfWork.Manufacturers.GetAsync(q => q.Id == id);

            if (manufacturer == null)
            {
                return NotFound();
            }

            return Ok(manufacturer);
        }

        // PUT: /Manufacturers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutManufacturer(int id, Manufacturer manufacturer)
        {
            if (id != manufacturer.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Manufacturers.Update(manufacturer);

            try
            {
                await _unitOfWork.SaveAsync(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ManufacturerExists(id))
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

        // POST: /Manufacturers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Manufacturer>> PostManufacturer(Manufacturer manufacturer)
        {
            await _unitOfWork.Manufacturers.InsertAsync(manufacturer);
            await _unitOfWork.SaveAsync(HttpContext);

            return CreatedAtAction("GetManufacturer", new { id = manufacturer.Id }, manufacturer);
        }

        // DELETE: /Manufacturers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteManufacturer(int id)
        {
            var manufacturer = await _unitOfWork.Manufacturers.GetAsync(q => q.Id == id);
            if (manufacturer == null)
            {
                return NotFound();
            }

            await _unitOfWork.Manufacturers.DeleteAsync(id);
            await _unitOfWork.SaveAsync(HttpContext);

            return NoContent();
        }

        private async Task<bool> ManufacturerExists(int id)
        {
            var manufacturer = await _unitOfWork.Manufacturers.GetAsync(q => q.Id == id);
            return manufacturer != null;
        }
    }
}