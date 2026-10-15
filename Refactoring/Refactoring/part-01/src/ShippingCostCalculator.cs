using Refactoring.part_01.src;

namespace RefactoringLab;



public class AramexCarrier : Icarrier
{
    public decimal CalculateCost(decimal weightKg) => weightKg * 12m;
}

public class FedExCarrier : Icarrier
{
    public decimal CalculateCost(decimal weightKg) => weightKg * 15m;
}

public class DhlCarrier : Icarrier
{
    public decimal CalculateCost(decimal weightKg) => weightKg * 18m;
}


// add new one without editing
public class BostaCarrier : Icarrier
{
    public decimal CalculateCost(decimal weightKg) => weightKg * 22m;
}



public class ShippingCostCalculator
{

    private readonly Icarrier _carrier;

    public ShippingCostCalculator(Icarrier carrier)
    {
        _carrier = carrier;
    }

    public decimal Calculate( decimal weightKg)
    {
       return _carrier.CalculateCost(weightKg);
    }
}
