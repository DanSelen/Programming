
class Flight
{
    private string _departurePoint;
    private string _arrivalPoint;
    private int _flightTime;

    public string DeparturePoint { get { return _departurePoint; } set { _departurePoint = value; } }
    public string ArrivalPoint { get { return _arrivalPoint; } set { _arrivalPoint = value; } }

    public int FlightTime { get { return _flightTime; } set { _flightTime = value; } }

    public Flight(string departurePoint, string arrivalPoint, int flightTime)
    {
        DeparturePoint = departurePoint;
        ArrivalPoint = arrivalPoint;
        FlightTime = flightTime;
    }
}