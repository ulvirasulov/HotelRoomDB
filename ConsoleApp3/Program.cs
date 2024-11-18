using ConsoleApp3.DAL;
using ConsoleApp3.Models;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDbContext db = new AppDbContext();
            Hotels hotel1 = new Hotels()
            {
                Name = "Hotel1",
                Rating = 8
            };
            Hotels hotel2 = new Hotels()
            {
                Name = "Hotel2",
                Rating = 4
            };
            Hotels hotel3 = new Hotels()
            {
                Name = "Hotel1",
                Rating = 7
            };
            Hotels hotel4 = new Hotels()
            {
                Name = "Hotel1",
                Rating = 9
            };

            Rooms room1 = new Rooms()
            {
                Name = "otaq 1",
                Price = 30,
                Hotels = hotel1
            };
            Rooms room2 = new Rooms()
            {
                Name = "otaq 2",
                Price = 30,
                Hotels = hotel2
            };
            Rooms room3 = new Rooms()
            {
                Name = "otaq 3",
                Price = 30,
                Hotels = hotel3
            };
            Rooms room4 = new Rooms()
            {
                Name = "otaq 4",
                Price = 30,
                Hotels = hotel4
            };

            //db.Hotels.Add(hotel1);
            //db.Hotels.Add(hotel2);
            //db.Hotels.Add(hotel3);
            //db.Hotels.Add(hotel4);
            db.Rooms.Add(room1);
            db.Rooms.Add(room2);
            db.Rooms.Add(room3);
            db.Rooms.Add(room4);
            db.SaveChanges();

        }
    }
}
