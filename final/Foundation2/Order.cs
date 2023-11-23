public class Order
{
    private double _totalPrice;
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(string nameCustomer)
    {
        _customer = new Customer(nameCustomer);
    }

    public void SetProductInList(Product product)
    {
        _products.Add(product);
    }

    public void DisplayPackingLabel()
    {
        for (int i = 0; i < _products.Count; i++)
        {
            string nameProduct = _products[i].GetNameProduct();
            int idProduct = _products[i].GetIDProduct();
            Console.WriteLine($"Name: {nameProduct}, ID: {idProduct}");
        }
    }

    public void DisplayShippingLabel()
    {
        string nameCustomer = _customer.GetNameCustomer();
        Console.WriteLine($"Customer: {nameCustomer}");
        
    }

    public void CalculateTotalPrice()
    {
        for (int i = 0; i < _products.Count; i++)
        {
            double price = _products[i].CalculateRealPrice();
            _totalPrice += price;
        }

        Console.WriteLine($"Total: {_totalPrice}");
    }
}