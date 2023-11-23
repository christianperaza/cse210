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
            _listOfProducts[i].GetNameProduct();
            _listOfProducts[i].GetIDProduct();
        }
    }
}