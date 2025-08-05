namespace CleanArchitecture.Domain.Vehicles;

public interface IVehiclesRepository
{
    Task<Vehicle?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
}