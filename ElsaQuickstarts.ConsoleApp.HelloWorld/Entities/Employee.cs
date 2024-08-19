namespace ElsaQuickstarts.ConsoleApp.HelloWorld.Entities;

public class Employee
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int UnitId { get; set; }
    public Unit Unit { get; set; }
}
