public class Product
{
    // attributes...
    private string _nameProduct;
    private int _idProduct;
    private float _priceProduct;
    private int _quantityProduct;

    // constructor to set product name, id, price, and quantity...
    public Product(string name, int id, float price, int quantity)
    {
        _nameProduct = name;
        _idProduct = id;
        _priceProduct = price;
        _quantityProduct = quantity;
    }

    // methods...

    // get name
    public string GetNameProduct()
    {
        return _nameProduct;
    }

    // get id
    public int GetIDProduct()
    {
        return _idProduct;
    }

    // get price
    public float GetPriceProduct()
    {
        return _priceProduct;
    }

    // get quantity
    public int GetQuantityProduct()
    {
        return _quantityProduct;
    }

    // calculate real price (price of product + quantity)
    public float CalculateRealPrice()
    {
        return _priceProduct * _quantityProduct;
    }
}