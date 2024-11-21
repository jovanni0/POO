namespace parcare.LocuriParcare;

public abstract class LocParcare
{
    private int _nrLoc;
    private bool _isUsed;
    protected int ReservationSpan;

    public LocParcare(int nrLoc, bool isUsed, int reservationSpan)
    {
        _nrLoc = nrLoc;
        _isUsed = isUsed;
        ReservationSpan = reservationSpan;
    }
    
    public override string ToString() => $"{_nrLoc}, ocupat: {_isUsed}";
    
    public int GetReservationSpan() => ReservationSpan;
}