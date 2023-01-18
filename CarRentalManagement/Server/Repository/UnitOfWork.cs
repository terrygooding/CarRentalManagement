using CarRentalManagement.Server.Contracts;
using CarRentalManagement.Server.Data;
using CarRentalManagement.Server.Models;
using CarRentalManagement.Shared.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace CarRentalManagement.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Manufacturer> _manufacturers;
        private IGenericRepository<Model> _models;
        private IGenericRepository<Vehicle> _vehicles;
        private IGenericRepository<Colour> _colours;
        private IGenericRepository<Booking> _bookings;
        private IGenericRepository<Customer> _customers;

        private UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IGenericRepository<Manufacturer> Manufacturers 
            => _manufacturers ??= new GenericRepository<Manufacturer>(_context);

        public IGenericRepository<Model> Models
            => _models ??= new GenericRepository<Model>(_context);

        public IGenericRepository<Vehicle> Vehicles
            => _vehicles ??= new GenericRepository<Vehicle>(_context);

        public IGenericRepository<Colour> Colours
            => _colours ??= new GenericRepository<Colour>(_context);

        public IGenericRepository<Booking> Bookings
            => _bookings ??= new GenericRepository<Booking>(_context);

        public IGenericRepository<Customer> Customers
            => _customers ??= new GenericRepository<Customer>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task SaveAsync(HttpContext httpContext)
        {
            //var user = httpContext.User.Identity.Name;
            var userId = httpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var user = await _userManager.FindByIdAsync(userId);

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);

            foreach (var entry in entries)
            {
                ((BaseModel)entry.Entity).DateUpdated = DateTime.Now;
                ((BaseModel)entry.Entity).UpdatedBy = user.UserName;
                if (entry.State == EntityState.Added)
                {
                    ((BaseModel)entry.Entity).DateCreated = DateTime.Now;
                    ((BaseModel)entry.Entity).CreatedBy = user.UserName;
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}
