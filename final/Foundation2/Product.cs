public class Product
{
    private string _nameProduct;
    private int _idProduct;
    private double _priceProduct;
    private int _quantityProduct;

    public Product(string name, int id)
    {
        _nameProduct = name;
        _idProduct = id;
    }

    public string GetNameProduct()
    {
        return _nameProduct;
    }

    public int GetIDProduct()
    {
        return _idProduct;
    }

    // public double CalculateRealPrice()
    // {
    //     return _priceProduct * _quantityProduct;
    // }
}