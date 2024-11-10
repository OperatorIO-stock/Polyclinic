using System;

namespace Polyclinic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Укажите количество человек в очереди");
        int peopleInLine = int.Parse(Console.ReadLine());
        int visitMinutes = 10;

        int minutesInHour = 60;

        int waitingHours = (peopleInLine * visitMinutes) / minutesInHour;
        int waitingMinutes = (peopleInLine * visitMinutes) % minutesInHour;

        Console.WriteLine("Вам предстоит отстоять в очереди: " +
                        $"{waitingHours}h {waitingMinutes}m");
    }
}
