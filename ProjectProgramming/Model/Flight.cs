
using ProjectProgramming.Model;

class Flight
{
    private string _departurePoint;
    private string _arrivalPoint;
    private int _flightTime;

    public string DeparturePoint { get { return _departurePoint; } set { _departurePoint = value; } }
    public string ArrivalPoint { get { return _arrivalPoint; } set { _arrivalPoint = value; } }

    public int FlightTime
    {
        set
        {
            Validator.AssertOnPositiveValue(value,nameof(FlightTime));
            _flightTime = value;
        }
        get
        {
            return _flightTime;
        }
    }

    public Flight(string departurePoint, string arrivalPoint, int flightTime)
    {
        DeparturePoint = departurePoint;
        ArrivalPoint = arrivalPoint;
        FlightTime = flightTime;
    }

    public Flight()
    {
        DeparturePoint = "";
        ArrivalPoint = "";
        FlightTime = 1;
    }
}