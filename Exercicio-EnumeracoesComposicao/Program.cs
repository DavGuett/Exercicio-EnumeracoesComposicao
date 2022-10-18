using Exercicio_EnumeracoesComposicao.Entities;
using Exercicio_EnumeracoesComposicao.Entities.Enums;

Console.WriteLine("Enter client's data: ");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Email: ");
string email = Console.ReadLine();
Console.Write("Birth date (DD/MM/YYYY): ");
DateTime birthDate = DateTime.Parse(Console.ReadLine());

Client client = new Client(name, email, birthDate);

Console.WriteLine("Enter order data: ");
Console.Write("Status: ");
string status = Console.ReadLine();
OrderStatus OrderStatus = OrderStatus.PENDING_PAYMENT;
if (status == "Processing")
{
    OrderStatus = OrderStatus.PROCESSING;
} else if (status == "Pending payment")
{
    OrderStatus = OrderStatus.PENDING_PAYMENT; 
} else if (status == "Shipped")
{
    OrderStatus = OrderStatus.SHIPPED;
} else if (status == "Delivered")
{
    OrderStatus = OrderStatus.DELIVERED;
} else
{
    Console.WriteLine("Invalid Status");
}

Order order = new Order(DateTime.Now, OrderStatus);

Console.Write("How many items to this order? ");
int numberOfItems = int.Parse(Console.ReadLine());

for (int i = 1; i <= numberOfItems; i++)
{
    Console.WriteLine($"Enter #{i} item data: ");
    Console.Write("Product name: ");
    string productName = Console.ReadLine();
    Console.Write("Product price: ");
    double productPrice = double.Parse(Console.ReadLine());
    Console.Write("Quantity: ");
    int productQuantity = int.Parse(Console.ReadLine());
    Product product = new Product(productName, productPrice);
    Console.WriteLine(product.Name);
}
Console.WriteLine();
Console.WriteLine("ORDER SUMMARY: ");
Console.Write("Order moment: ");
Console.WriteLine(order.moment);
Console.Write("Order status: ");
Console.WriteLine(order.status);
Console.Write("Client: ");
Console.WriteLine(client);
