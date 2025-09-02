namespace PrinterCartridgeService;

public class PrinterCartridgeDiscount
{
    public double CalculateDiscount(int cartridgeCount)
    {
        if (cartridgeCount < 5)
        {
            throw new ArgumentException("The minimum order quantity is 5.");
        }
        else if (cartridgeCount >= 100)
        {
            return 0.2;
        }
        return 0;
    }
}
