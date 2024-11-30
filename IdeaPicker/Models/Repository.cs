using SQLite;
namespace IdeaPicker.Models;

public class Repository
{
    private readonly SQLiteConnection _database;

    public Repository()
    {
        var dbPath = Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.LocalApplicationData), "restaurants.db");

        _database = new SQLiteConnection(dbPath);
        _database.CreateTable<Restaurant>();
    }

    public List<Restaurant> GetRestaurants()
    {
        return _database.Table<Restaurant>().ToList();
    }

    //single restaurant method from DB
  

    public void SaveRestaurant(Restaurant restaurant)
    {
        _database.Insert((restaurant));
    }
}