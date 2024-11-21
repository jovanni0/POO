namespace parcare.LocuriParcare;

public class LocInchiriat : LocParcare
{
    private string _nrMasina;
    private DateOnly _startDate;

    
    public LocInchiriat(int nrLoc, bool isUsed, string nrMasina, DateOnly startDate, int reservationSpan) 
        : base(nrLoc, isUsed, reservationSpan)
    {
        _nrMasina = nrMasina;
        _startDate = startDate;
    }

    /// <summary>
    /// get the proce of the reservation
    /// </summary>
    /// <returns></returns>
    public int GetPrice() => ReservationSpan * 20;
    
}