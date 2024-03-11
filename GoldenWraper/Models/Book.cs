namespace GoldenWraper.Models;

public class Book
{
    public string Title { get; set; }
    public string ISBN { get; set; }
    public Publisher Publisher { get; set; }
    public Author Author { get; set; }
    public double Price { get; set; }
    public double Cost { get; set; }
    public int Pages { get; set; }
}