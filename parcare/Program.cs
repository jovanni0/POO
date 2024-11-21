using System.Runtime.InteropServices.JavaScript;
using parcare.LocuriParcare;

namespace parcare;

class Program
{
    static void Main(string[] args)
    {
        Parcare parcare = new Parcare();
        
        List<LocParcare> locuriParcare = new List<LocParcare>()
        {
            new LocOra(983, 2, true),
            new LocInchiriat(324, true, "HD17TRE", new DateOnly(2024, 11, 21), 5),
            new LocOra(123, 2.41, false),
            new LocInchiriat(221, true, "TM10RVN", new DateOnly(2024, 11, 10), 110),
            new LocInchiriat(331, true, "CS00PPR", new DateOnly(2025, 01, 01), 2)
        };

        foreach (var loc in locuriParcare)
        {
            try
            {
                parcare.AddLocParcare(loc);
            }
            catch (TooManyReservedSpotsException e)
            {
                Console.WriteLine(e);
            }
        }
        
        Console.WriteLine("---------------------------- locurile de parcare:");
        parcare.PrintLocuriParcare();
        
        Console.WriteLine("----------------------------- locurile inchiriate peste 60 zile:");
        parcare.PrintOver60Days();
    }
}