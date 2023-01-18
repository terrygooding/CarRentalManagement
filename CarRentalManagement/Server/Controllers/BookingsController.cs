using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement.Shared.Models;
using CarRentalManagement.Server.Contracts;


namespace CarRentalManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public BookingsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: /Bookings
        [HttpGet]
        public async Task<IActionResult> GetBookings()
        {
            var includes = new List<string> { "Vehicle", "Customer" };
            var bookings = await _unitOfWork.Bookings.GetAllAsync(includes : includes);
            return Ok(bookings);
        }

        // GET: /Bookings/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBooking(int id)
        {
            var includes = new List<string> { "Vehicle", "Customer" };
            var booking = await _unitOfWork.Bookings.GetAsync(q => q.Id == id, includes);

            if (booking == null)
            {
                return NotFound();
            }

            return Ok(booking);
        }

        // PUT: /Bookings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBooking(int id, Booking booking)
        {
            if (id != booking.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Bookings.Update(booking);

            try
            {
                await _unitOfWork.SaveAsync(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await BookingExists(id))
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

        // POST: /Bookings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Booking>> PostBooking(Booking Booking)
        {
            await _unitOfWork.Bookings.InsertAsync(Booking);
            await _unitOfWork.SaveAsync(HttpContext);

            return CreatedAtAction("GetBooking", new { id = Booking.Id }, Booking);
        }

        // DELETE: /Bookings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBooking(int id)
        {
            var booking = await _unitOfWork.Bookings.GetAsync(q => q.Id == id);
            if (booking == null)
            {
                return NotFound();
            }

            await _unitOfWork.Bookings.DeleteAsync(id);
            await _unitOfWork.SaveAsync(HttpContext);

            return NoContent();
        }

        private async Task<bool> BookingExists(int id)
        {
            var Booking = await _unitOfWork.Bookings.GetAsync(q => q.Id == id);
            return Booking != null;
        }
    }
}
