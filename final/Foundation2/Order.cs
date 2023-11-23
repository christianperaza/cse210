public class Order
{
    private double _totalPrice;
    private List<Product> _products = new List<Product>();
    private List<Customer> _customer = new List<Customer>();

    public void SetProductInList(Product product)
    {
        _products.Add(product);
    }

    public void SetCustomerInList(Customer customer)
    {
        _customer.Add(customer);
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
        for (int i = 0; i < _customer.Count; i++)
        {
            string nameCustomer = _customer[i].GetNameCustomer();
            Console.WriteLine($"Customer: {nameCustomer}");
        }
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