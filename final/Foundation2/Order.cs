public class Order
{
    private List<Product> _listOfProducts = new List<Product>();

    public Order(Product product)
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
}