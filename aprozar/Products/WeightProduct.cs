namespace aprozar.Products;

public class WeightProduct : Product
{
    /// <summary>
    /// the unit by which the weight is measured
    /// </summary>
    public string MeasurementUnit { get; init; }
    
    public WeightProduct(string name, double unitPrice, string measurementUnit, double stock)
        : base(name, unitPrice, stock)
    {
        MeasurementUnit = measurementUnit;
    }
}