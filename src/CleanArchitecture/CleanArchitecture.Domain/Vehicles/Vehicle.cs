using CleanArchitecture.Domain.Abstractions;

namespace CleanArchitecture.Domain.Vehicles;

public sealed class Vehicle : Entity
{
    public Vehicle(
        Guid id,
        Model model,
        Vin vin,
        Currency price,
        Currency maintenance,
        DateTime? lastRentalDate,
        List<Accessory> accessories,
        Direction? direction
        ) : base(id)
    {
        Model = model;
        Vin = vin;
        Price = price;
        Maintenance = maintenance;
        LastRentalDate = lastRentalDate;
        Accessories = accessories;
        Direction = direction;
    }
    public Model? Model { get; private set; }
    public Vin? Vin { get; private set; }
    public Direction? Direction { get; private set; }
    public Currency? Price { get; private set; }
    public Currency? Maintenance { get; private set; }
    public DateTime? LastRentalDate { get; private set; }
    public List<Accessory> Accessories { get; private set; } = new();
}
