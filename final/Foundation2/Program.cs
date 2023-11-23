using System;

class Program
{
    static void Main(string[] args)
    {

        // ----------- 1° ORDER ----------- //

        // product 1...
        string nameProduct1 = "Shampoo Sweet";
        int idProduct1 = 56841236;
        double priceProduct1 = 5.3;
        int quantityProduct1 = 2;
        Product product1 = new Product(nameProduct1, idProduct1, priceProduct1, quantityProduct1);

        // product 2...
        string nameProduct2 = "Ruby Soap";
        int idProduct2 = 45789122;
        double priceProduct2 = 3;
        int quantityProduct2 = 5;
        Product product2 = new Product(nameProduct2, idProduct2, priceProduct2, quantityProduct2);

        string nameCustomer1 = "Pablo Perez";
        Customer customer1 = new Customer(nameCustomer1);

        Order order1 = new Order();
        order1.SetProductInList(product1);
        order1.SetProductInList(product2);
        order1.SetCustomerInList(customer1);


        
        order1.DisplayPackingLabel();
        order1.CalculateTotalPrice();
        

        
        
    }
}