namespace CleanArchitecture.Domain.Vehicles;

public record Currency(decimal Amount, CurrencyType CurrencyType)
{
    public static Currency operator +(Currency firstValue, Currency secondValue)
    {
        if (firstValue.CurrencyType != secondValue.CurrencyType)
        {
            throw new InvalidOperationException("The type of Currency must be the same");
        }

        return new Currency(firstValue.Amount + secondValue.Amount, firstValue.CurrencyType);
    }

    public static Currency Zero() => new Currency(0, CurrencyType.None);
    public static Currency Zero(CurrencyType currencyType) => new(0, currencyType);
    public bool isZero => this == Zero(CurrencyType);
}