public class NewCustomer
{
    public NewCustomer(int id)
    {
        this.Id = id;
    }

    public NewCustomer(int id, string name) : this(id)
    {
        this.Name = name;
    }
    public int Id { get; set; }

    public string Name { get; set; }

    public List<NewOrder> Orders = new List<NewOrder>();

    public void Promote()
    {
        Console.WriteLine("You have been promoted due to having {0} orders", Orders.Count);
    }
}