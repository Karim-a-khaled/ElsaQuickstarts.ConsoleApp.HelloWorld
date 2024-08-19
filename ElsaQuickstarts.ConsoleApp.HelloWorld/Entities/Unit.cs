namespace ElsaQuickstarts.ConsoleApp.HelloWorld.Entities;

public class Unit
{
    public int Id { get; set; }

    public string Name { get; set; }

    public ICollection<Employee> Employees { get; set; }
}
