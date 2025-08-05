using CleanArchitecture.Domain.Abstractions;

namespace CleanArchitecture.Domain.Vehicles;

public sealed class Vehicle : Entity
{
    public Vehicle(Guid id) : base(id)
    { }
    public Model? Model { get; private set; }
    public Vin? Vin { get; private set; }
    public Direction? Direction { get; private set; }
    public string Price { get; private set; }
    public string? CurrencyType { get; private set; }
    public decimal Mantainance { get; private set; }
    public string? MaintenanceCurrencyType { get; private set; }
    public DateTime? LastRentalDate { get; private set; }
    public List<Accessory> Accessories { get; private set; } = new();
}
