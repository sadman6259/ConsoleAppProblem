bool peakhour = false;
DateTime starttime = new DateTime(2019, 08, 31, 08, 59, 13);
DateTime endtime = new DateTime(2019, 08, 31, 09, 00, 39);
DateTime PeakHourStarttime = new DateTime(2019, 08, 31, 09, 00, 00);
DateTime PeakHourEndtime = new DateTime(2019, 08, 31, 23, 00, 00);

var diffInSeconds = (endtime - starttime).TotalSeconds;
double TotalCost = 0;


double startTimeInseconds = starttime.Subtract(DateTime.MinValue).TotalSeconds;
double endTimeInseconds = endtime.Subtract(DateTime.MinValue).TotalSeconds;
double PeakHourStarttimeInseconds = PeakHourStarttime.Subtract(DateTime.MinValue).TotalSeconds;
double PeakHourEndtimeInseconds = PeakHourEndtime.Subtract(DateTime.MinValue).TotalSeconds;



while (startTimeInseconds <= endTimeInseconds)
{
    startTimeInseconds += 20;
    if(startTimeInseconds >= PeakHourStarttimeInseconds && startTimeInseconds <= PeakHourEndtimeInseconds)
    {
        TotalCost += 30;
    }
    TotalCost += 20;

}


Console.WriteLine(TotalCost);
Console.ReadLine();
