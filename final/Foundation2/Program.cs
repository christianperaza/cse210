using System;

class Program
{
    static void Main(string[] args)
    {

        // ----------- 1° ORDER ----------- //

        // product 1...
        string nameProduct1 = "Shampoo Sweet";
        int idProduct1 = 56841236;
        float priceProduct1 = 5.3f;
        int quantityProduct1 = 2;
        Product product1 = new Product(nameProduct1, idProduct1, priceProduct1, quantityProduct1);

        // product 2...
        string nameProduct2 = "Ruby Soap";
        int idProduct2 = 45789122;
        float priceProduct2 = 3f;
        int quantityProduct2 = 5;
        Product product2 = new Product(nameProduct2, idProduct2, priceProduct2, quantityProduct2);

        // customer 1...
        string nameCustomer1 = "Pablo Perez";
        // address 1...
        string street1 = "Uripata St.";
        string city1 = "Guayana 8051";
        string state1 = "Bolivar";
        string country1 = "Venezuela";

        // order 1...
        Order order1 = new Order(nameCustomer1, street1, city1, state1, country1);
        order1.SetProductInList(product1);
        order1.SetProductInList(product2);



        // ----------- 2° ORDER ----------- //

        // product 1 of order 2...
        string nameProduct1Order2 = "Sunrise Wheat Flour";
        int idProduct1Order2 = 12485556;
        float priceProduct1Order2 = 4.2f;
        int quantityProduct1Order2 = 4;
        Product product1Order2 = new Product(nameProduct1Order2, idProduct1Order2, priceProduct1Order2, quantityProduct1Order2);

        // product 2 of order 2...
        string nameProduct2Order2 = "Carton of Eggs";
        int idProduct2Order2 = 22589431;
        float priceProduct2Order2 = 8.5f;
        int quantityProduct2Order2 = 1;
        Product product2Order2 = new Product(nameProduct2Order2, idProduct2Order2, priceProduct2Order2, quantityProduct2Order2);

        // product 3 of order 2...
        string nameProduct3Order2 = "Liter of Milk";
        int idProduct3Order2 = 11147852;
        float priceProduct3Order2 = 6f;
        int quantityProduct3Order2 = 2;
        Product product3Order2 = new Product(nameProduct3Order2, idProduct3Order2, priceProduct3Order2, quantityProduct3Order2);

        // customer 2...
        string nameCustomer2 = "Pablo Perez";
        // address 2...
        string street2 = "Uripata St.";
        string city2 = "Guayana 8051";
        string state2 = "Bolivar";
        string country2 = "Venezuela";

        // order 2...
        Order order2 = new Order(nameCustomer2, street2, city2, state2, country2);
        order2.SetProductInList(product1Order2);
        order2.SetProductInList(product2Order2);
        order2.SetProductInList(product3Order2);

        

        // ----------- DISPLAY ORDERS ----------- //
        order1.DisplayOrder();
        order2.DisplayOrder();
        

        
        
    }
}