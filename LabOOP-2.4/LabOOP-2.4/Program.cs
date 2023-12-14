using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Fares fares = new Fares();

        fares.AddAuto("Міша Лебіга", DateTime.Today.Date.AddHours(9).AddMinutes(5).AddSeconds(31).ToString(), 72345, Parking.Cars);
        fares.AddAuto("Лебігович", DateTime.Today.Date.AddHours(23).AddMinutes(8).AddSeconds(12).ToString(), 74321, Parking.FreightCars);
        fares.AddAuto("Швартс Наггетс", DateTime.Today.Date.AddHours(7).AddMinutes(7).AddSeconds(41).ToString(), 77890, Parking.Buses);

        foreach (Auto car in fares)
        {
            Console.WriteLine(car);
        }

        Fares copyFares = (Fares)fares.DeepCopy();

        Console.WriteLine("\nКопія списку автомобілів:");
        foreach (Auto car in copyFares)
        {
            Console.WriteLine(car);
        }
    }
}
