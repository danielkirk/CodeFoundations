var customer = new NewCustomer(1);
var order = new NewOrder();
customer.Orders.Add(order);
customer.Orders.Add(order);
customer.Orders.Add(order);


customer.Promote();


static void UsePoints()
{
    try
    {
        var point = new Point(10, 20);
        point.Move(new Point(40, 60));
        Console.WriteLine("Point is at({0}, {1})", point.x, point.y);

        point.Move(5000, 1000);
        Console.WriteLine("Point is at({0}, {1})", point.x, point.y);

    }
    catch (Exception)
    {
        Console.WriteLine("An unexpected error occured");
    }
}



static void UseParams()
{
    var calculator = new Calculator();

    calculator.Add(1, 7, 35, 45);
    Console.WriteLine(calculator);
}

