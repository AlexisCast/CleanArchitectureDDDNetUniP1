using CleanArchitecture.Domain.Abstractions;

namespace CleanArchitecture.Domain.Vehicles;

public sealed class Vehicle : Entity
{
    public Vehicle(Guid id) : base(id)
    { }
    public string? Model { get; private set; }
    public string? Vin { get; private set; }
    public string? Street { get; private set; }
    public string? Department { get; private set; }
    public string? Province { get; private set; }
    public string? City { get; private set; }
    public string? Country { get; private set; }
    public string Price { get; private set; }
    public string? CurrencyType { get; private set; }
    public decimal Mantainance { get; private set; }
    public string? MaintenanceCurrencyType { get; private set; }
    public DateTime? LastRentalDate { get; private set; }
    public List<Accessory> Accessories { get; private set; } = new();
}
