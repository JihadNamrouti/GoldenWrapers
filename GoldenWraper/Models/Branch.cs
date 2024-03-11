namespace GoldenWraper.Models;

public class Branch
{
   public string Location { get; set; }
   public List<Employee> Employees { get; set; }
   public List<Book> Inventory { get; set; }
}