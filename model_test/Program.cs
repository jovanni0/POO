using pregatire_test_1___1.Exceptions;

namespace pregatire_test_1___1;

class Program
{
    static void Main(string[] args)
    {
        var localFlight = new LocalFlight("20341", new DateOnly(2024, 12, 25), "Timisoara", "Iasi");
        var transatlanticFlight = new TransatlanticFlight("64983", new DateOnly(2024, 11, 21), "Paris", "New York");
        FlightCompany company = new FlightCompany(localFlight, transatlanticFlight);
        
        List<Reservation> locals = new List<Reservation>()
        {
            new Reservation("Ioan Cucea", "cucea.ioan@gamil.com", 5, 4, "local"),
            new Reservation("Jimmy To", "jimmyto@gamil.com", 10, 4, "local"),
        };
        List<Reservation> transatlantics = new List<Reservation>()
        {
            new Reservation("Elon Musk", "elonmus@gamil.com", 1, 20, "transatlantic"),
            new Reservation("Gordea George", "geogeo@gmail.com", 21, 21, "transatlantic"),
            new Reservation("John Doe", "johndoe@gmail.com", 19, 1, "transatlantic"),
        };
        foreach (var item in locals)
        {
            company.AddLocalFlightReservation(item);
        }
        foreach (var item in transatlantics)
        {
            company.AddTransatlanticFlightReservation(item);
        }
        
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("reservarile pentru zborul local sunt:");
        company.PrintLocalFlightReservations();
        Console.WriteLine("reservarile pentru zborul transatlantic sunt:");
        company.PrintTransatlanticFlightReservations();
        
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine($"nr de locuri rezervate pentur zborul local: {company.GetNumberOfLocalPassengers()}");
        Console.WriteLine($"nr de locuri rezervate pentur zborul transatlantic: {company.GetNumberOfTransatlanticPassengers()}");

        
        List<string> flightsToCheck = new List<string>()
        {
            "12345", "20341", "64983", "64983", "25343", "20341"
        };

        Console.WriteLine("---------------------------------------------------");
        foreach (var item in flightsToCheck)
        {
            try
            {
                var response = company.HasAvailableSeats(item, 2);
                if (response)
                    Console.WriteLine($"flight {item} has enough available places");
                else
                    Console.WriteLine($"flight {item} does not have enough available places");
            }
            catch (UnavailableFlightException e)
            {
                Console.WriteLine($"caught UnavailableFlightException: {e.Message}");
            }
            catch (ServiceOfflineException e)
            {
                Console.WriteLine($"caught UnavailableFlightException: {e.Message}");
            }
        }
    }
}