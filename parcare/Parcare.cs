using parcare.LocuriParcare;

namespace parcare;

public class Parcare
{
    private List<LocParcare> _locuriParcare;

    public Parcare()
    {
        _locuriParcare = new List<LocParcare>();
    }

    /// <summary>
    /// reserve a parking spot
    /// </summary>
    public void AddLocParcare(LocParcare locParcare)
    {
        var locuriOra = 0;
        var locuriInchiriate = 0;

        foreach (var loc in _locuriParcare)
        {
            if (loc.GetType() == typeof(LocOra))
                locuriOra++;
            else
                locuriInchiriate++;
        }

        if (locParcare.GetType() == typeof(LocInchiriat) && locuriInchiriate + 1 > locuriOra)
            throw new TooManyReservedSpotsException("prea multe locuri de parcare sunt rezervate pe termen lung");
        
        _locuriParcare.Add(locParcare);
    }

    /// <summary>
    /// prints all parking spots
    /// </summary>
    public void PrintLocuriParcare()
    {
        Console.WriteLine(string.Join("\n", _locuriParcare.Select(loc => loc.ToString())));
    }

    /// <summary>
    /// prints all parking spots that are reserved over 60 days
    /// </summary>
    public void PrintOver60Days()
    {
        var over60 = new List<LocParcare>();
        foreach (var locParcare in _locuriParcare)
        {
            if (locParcare.GetType() == typeof(LocInchiriat) && locParcare.GetReservationSpan() > 60)
                over60.Add(locParcare);
        }
        Console.WriteLine(string.Join("\n", over60.Select(loc => loc.ToString())));
    }
}