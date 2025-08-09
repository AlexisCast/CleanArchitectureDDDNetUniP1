using CleanArchitecture.Domain.Abstractions;

namespace CleanArchitecture.Domain.Rentals;

public class Rental : Entity
{
    public Rental(Guid id) : base(id)
    {

    }
    public RentalStatus Status { get; private set; }

}