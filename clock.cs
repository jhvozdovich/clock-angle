using System;

class Clock
{
  static void Main()
  {
    Console.WriteLine("Enter the time (hh:mm)");
    string time = Console.ReadLine();
    string[] timeSeparated = time.Split(":");
    double hour = double.Parse(timeSeparated[0]);
    double minute = double.Parse(timeSeparated[1]);

    double totalMinutes = hour * 60 + minute;
    double minuteDegrees = minute * 6;
    double hourDegrees = (hour * 30) + (minute * 0.5);
    double angleDifference = Math.Abs(hourDegrees - minuteDegrees);

    if (angleDifference > 180)
    {
      Console.WriteLine((360 - angleDifference) + " degrees");
    }
    else
    {
      Console.WriteLine(angleDifference + " degrees");
    }
  }
}
