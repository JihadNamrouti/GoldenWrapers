namespace GoldenWraper.Models;

public class Employee
{
    public string Name { get; set; }
    public string NationalID { get; set; }
    public long Number { get; set; }
    public double Salary { get; set; }
    public string Address { get; set; }
    public Boolean IsManager { get; set; } = false;
}