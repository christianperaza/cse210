public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    private double _subTotal;
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
        Console.WriteLine("ORDER\n");

        for (int i = 0; i < _products.Count; i++)
        {
            string nameProduct = _products[i].GetNameProduct();
            int idProduct = _products[i].GetIDProduct();
            
            double priceProduct = _products[i].GetPriceProduct();
            int quantityProduct = _products[i].GetQuantityProduct();

            Console.WriteLine($"({idProduct}) {nameProduct} ${priceProduct} x {quantityProduct}");
        }
    }

    public void DisplayShippingLabel()
    {
        string nameCustomer = _customer.GetNameCustomer();
        Console.WriteLine($"\nCustomer: {nameCustomer}");

        string addressCustomer = _customer.GetAddress();  
        Console.WriteLine($"{addressCustomer}"); 
    }

    public void CalculateTotalPrice()
    {
        for (int i = 0; i < _products.Count; i++)
        {
            double price = _products[i].CalculateRealPrice();
            _subTotal += price;
        }

        if (_customer.GetLivingInUSA() == true)
        {
            _totalPrice = _subTotal + _USAShippingCost;
        }
        else
        {
            _totalPrice = _subTotal + _outShippingCost;
        }

        Console.WriteLine($"Sub-Total: {_subTotal}");

        Console.WriteLine($"Total: {_totalPrice}");
    }

    public void DisplayOrder()
    {
        DisplayPackingLabel();
        DisplayShippingLabel();
        CalculateTotalPrice();
    }
}