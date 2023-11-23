using System;

class Program
{
    static void Main(string[] args)
    {
        

        string nameProduct1 = "Shampoo Sweet";
        int idProduct1 = 56841236;
        Product product1 = new Product(nameProduct1, idProduct1);

        Order order1 = new Order(product1);

        order1.DisplayPackingLabel();
        
    }
}