DateTime starttime = new DateTime(2019, 08, 31, 08, 59, 13);
DateTime endtime = new DateTime(2019, 08, 31, 09, 00, 39);
DateTime PeakHourStarttime = new DateTime(2019, 08, 31, 09, 00, 00);
DateTime PeakHourEndtime = new DateTime(2019, 08, 31, 23, 00, 00);

double TotalCost = 0;

while (starttime <= endtime)

{

    if ((starttime <= PeakHourStarttime) && (starttime <= endtime) && (starttime.AddSeconds(20) < PeakHourStarttime))
    {
        TotalCost += 20;

    }
    else
    {
        TotalCost += 30;

    }
    starttime = starttime.AddSeconds(20);



}


Console.WriteLine(TotalCost);
Console.ReadLine();
