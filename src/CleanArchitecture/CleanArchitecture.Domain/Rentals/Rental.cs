using CleanArchitecture.Domain.Abstractions;
using CleanArchitecture.Domain.Vehicles;

namespace CleanArchitecture.Domain.Rentals;

public sealed class Rental : Entity
{
    private Rental(
        Guid id,
        Guid vehicleId,
        Guid userId,
        DateRange duration,
        Currency pricePerPeriod,
        Currency maintenence,
        Currency accesories,
        Currency totalPrice,
        RentalStatus status,
        DateTime dateCreation
        ) : base(id)
    {
        VehicleId = vehicleId;
        UserId = userId;
        Duration = duration;
        PricePerPeriod = pricePerPeriod;
        Maintenence = maintenence;
        Accesories = accesories;
        TotalPrice = totalPrice;
        Status = status;
        DateCreation = dateCreation;
    }
    public Guid VehicleId { get; private set; }
    public Guid UserId { get; private set; }
    public Currency? PricePerPeriod { get; private set; }
    public Currency? Maintenence { get; private set; }
    public Currency? Accesories { get; private set; }
    public Currency? TotalPrice { get; private set; }
    public RentalStatus Status { get; private set; }
    public DateRange? Duration { get; private set; }
    public DateTime? DateCreation { get; private set; }
    public DateTime? DateConfirmation { get; private set; }
    public DateTime? DateDenied { get; private set; }
    public DateTime? DateCompleted { get; private set; }
    public DateTime? DateCancelation { get; private set; }
}