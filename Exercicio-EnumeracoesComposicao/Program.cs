using Exercicio_EnumeracoesComposicao.Entities;
using Exercicio_EnumeracoesComposicao.Entities.Enums;

Console.WriteLine("Enter client's data: ");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Email: ");
string email = Console.ReadLine();
Console.Write("Birth date (DD/MM/YYYY): ");
DateTime birthDate = DateTime.Parse(Console.ReadLine());

Client cliente = new Client(name, email, birthDate);

Console.WriteLine("Enter order data: ");
Console.WriteLine("Status: ");
string status = Console.ReadLine();
OrderStatus OrderStatus = OrderStatus.PENDING_PAYMENT;
if (status == "Processing")
{
    OrderStatus = OrderStatus.PROCESSING;
}

Order order = new Order(DateTime.Now, OrderStatus);

Console.Write("How many items to this order?");
int numberOfItems = int.Parse(Console.ReadLine());

for (int i = 1; i <= numberOfItems; i++)
{
    Console.Write("Product name: ");
    string productName = Console.ReadLine();
    Console.Write("Product price: ");
    double productPrice = double.Parse(Console.ReadLine());
    int productQuantity = int.Parse(Console.ReadLine());
}