using CarRentalManagement.Shared.Models;

namespace CarRentalManagement.Server.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        Task SaveAsync(HttpContext httpContext);
        IGenericRepository<Manufacturer> Manufacturers { get; }
        IGenericRepository<Model> Models { get; }
        IGenericRepository<Vehicle> Vehicles { get; }
        IGenericRepository<Colour> Colours { get; }
        IGenericRepository<Booking> Bookings { get; }
        IGenericRepository<Customer> Customers { get; }
    }
}
