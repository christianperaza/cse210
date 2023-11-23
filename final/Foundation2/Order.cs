public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    private float _subTotal;
    private float _totalPrice;
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
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("ORDER\n");

        for (int i = 0; i < _products.Count; i++)
        {
            string nameProduct = _products[i].GetNameProduct();
            int idProduct = _products[i].GetIDProduct();
            
            float priceProduct = _products[i].GetPriceProduct();
            int quantityProduct = _products[i].GetQuantityProduct();

            Console.WriteLine($"({idProduct}) {nameProduct} ${priceProduct} x {quantityProduct}");
        }
        Console.WriteLine("---------------------------------------");
    }

    public void DisplayShippingLabel()
    {
        string nameCustomer = _customer.GetNameCustomer();
        Console.WriteLine($"Customer: {nameCustomer}\n");

        Console.WriteLine("Address:");
        string addressCustomer = _customer.GetAddress();
        Console.WriteLine($"{addressCustomer}"); 
    }

    public void CalculateTotalPrice()
    {
        for (int i = 0; i < _products.Count; i++)
        {
            float price = _products[i].CalculateRealPrice();
            _subTotal += price;
        }

        Console.WriteLine("---------------------------------------");
        Console.WriteLine($"Sub-Total: ${_subTotal}");

        if (_customer.GetLivingInUSA() == true)
        {
            _totalPrice = _subTotal + _USAShippingCost;
            Console.WriteLine($"Shipping cost: ${_USAShippingCost}");
        }
        else
        {
            _totalPrice = _subTotal + _outShippingCost;
            Console.WriteLine($"Shipping cost: ${_outShippingCost}");
        }

        
        Console.WriteLine("---------------------------------------");
        Console.WriteLine($"Total: ${_totalPrice}");
        Console.WriteLine("---------------------------------------");
    }

    public void DisplayOrder()
    {
        Console.WriteLine("");

        DisplayPackingLabel();
        DisplayShippingLabel();
        CalculateTotalPrice();

        Console.WriteLine("");
    }
}