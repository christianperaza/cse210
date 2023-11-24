public class Order
{
    // attributes (all are private)...
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    private float _subTotal; // store the price without the shipping cost
    private float _totalPrice; // store the total price (subTotal + shipping cost)
    private int _USAShippingCost; // $35
    private int _outShippingCost; // $5

    // constructor to set customer name to Customer constructor.
    // Also, with this constructor sets customer street, city, state, and country to Customer constructor,
    // Then Customer constructor sets them to address constructor...
    public Order(string nameCustomer, string street, string city, string state, string country)
    {
        _customer = new Customer(nameCustomer, street, city, state, country); // instance a new Customer object to get certain Customer attributes and methods

        _USAShippingCost = 5;
        _outShippingCost = 35;
    }

    // methods...

    // set products in list method to add each product created in Main class
    public void SetProductInList(Product product)
    {
        _products.Add(product);
    }

    // packing label
    public void DisplayPackingLabel()
    {
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("ORDER\n");

        for (int i = 0; i < _products.Count; i++)
        {
            // get product name, id, price, and quantity from each product object
            string _nameProduct = _products[i].GetNameProduct();
            int _idProduct = _products[i].GetIDProduct();
            
            float _priceProduct = _products[i].GetPriceProduct();
            int _quantityProduct = _products[i].GetQuantityProduct();

            Console.WriteLine($"({_idProduct}) {_nameProduct} ${_priceProduct} x {_quantityProduct}");
        }
        Console.WriteLine("---------------------------------------");
    }

    // shipping label
    public void DisplayShippingLabel()
    {
        string _nameCustomer = _customer.GetNameCustomer(); // get name of customer from customer object created
        Console.WriteLine($"Customer: {_nameCustomer}\n"); 

        Console.WriteLine("Address:");
        string _addressCustomer = _customer.GetAddress(); // get address of customer from customer object created
        Console.WriteLine($"{_addressCustomer}"); 
    }

    // total price
    public void CalculateTotalPrice()
    {
        // first, calculate subtotal...
        for (int i = 0; i < _products.Count; i++)
        {
            float _price = _products[i].CalculateRealPrice();
            _subTotal += _price;
        }

        Console.WriteLine("---------------------------------------");
        Console.WriteLine($"Sub-Total: ${_subTotal}");

        // adding shipping cost to subtotal depending whether customer lives in the USA or not...
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

        // display total price...
        Console.WriteLine("---------------------------------------");
        Console.WriteLine($"Total: ${_totalPrice}");
        Console.WriteLine("---------------------------------------");
    }

    // display order
    public void DisplayOrder()
    {
        Console.WriteLine("");

        // call the methods to get the packing label, the shipping label, and the total price...
        DisplayPackingLabel();
        DisplayShippingLabel();
        CalculateTotalPrice();

        Console.WriteLine("");
    }
}