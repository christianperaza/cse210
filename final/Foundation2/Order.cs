public class Order
{
    private double _totalPrice;
    private List<Product> _listOfProducts = new List<Product>();

    public void SetProductInList(Product product)
    {
        _listOfProducts.Add(product);
    }

    public void DisplayPackingLabel()
    {
        for (int i = 0; i < _listOfProducts.Count; i++)
        {
            string name = _listOfProducts[i].GetNameProduct();
            int id = _listOfProducts[i].GetIDProduct();
            Console.WriteLine($"Name: {name}, ID: {id}");
        }
    }

    public void CalculateTotalPrice()
    {
        for (int i = 0; i < _listOfProducts.Count; i++)
        {
            double price = _listOfProducts[i].CalculateRealPrice();
            _totalPrice += price;
        }

        Console.WriteLine($"Total: {_totalPrice}");
    }
}