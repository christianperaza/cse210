public class Product
{
    private string _nameProduct;
    private int _idProduct;
    private double _priceProduct;
    private int _quantityProduct;

    public double CalculateRealPrice()
    {
        return _priceProduct * _quantityProduct;
    }
}