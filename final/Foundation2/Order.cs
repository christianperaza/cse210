public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    private double _totalPrice;
    private int _USAShippingCost;
    private int _outShippingCost;

    public Order(string nameCustomer, string street, string city, string state, string country)
    {
        _customer = new Customer(nameCustomer, street, city, state, country);

        _USAShippingCost = 5;
        _outShippingCost = 35;
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

        string addressCustomer = _customer.GetAddress();  
        Console.WriteLine($"{addressCustomer}"); 
    }

    public void CalculateTotalPrice()
    {
        for (int i = 0; i < _products.Count; i++)
        {
            double price = _products[i].CalculateRealPrice();
            _totalPrice += price;
        }

        if (_customer.GetLivingInUSA() == true)
        {
            _totalPrice += _USAShippingCost;
        }
        else
        {
            _totalPrice += _outShippingCost;
        }

        Console.WriteLine($"Total: {_totalPrice}");
    }

    public void DisplayOrder()
    {
        DisplayPackingLabel();
        DisplayShippingLabel();
        CalculateTotalPrice();
    }
}