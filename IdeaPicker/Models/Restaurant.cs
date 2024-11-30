using SQLite;
namespace IdeaPicker.Models;

public class Restaurant
{
    [PrimaryKey, AutoIncrement]
    public int ID { get; set; }
    public string Name { get; set; }
}