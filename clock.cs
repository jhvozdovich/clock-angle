using System;

class Clock
{
  static void Main()
  {
    Console.WriteLine("Enter the current hour:");
    double hour = double.Parse(Console.ReadLine());
    Console.WriteLine("Enter the current minute:");
    double minute = double.Parse(Console.ReadLine());
    // 3:00 = 90
    // m = 0 H = 90
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

/*

10:15

h = 307.5
m = 90

7:36

h = 210 + 18 = 228
m = 216
*/

// 3:30
// Hour = 360 /12 = 30 + (MINUTES * 0.5)
// 180
// 105  
