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

        int waitingHour = (peopleInLine * visitMinutes) / minutesInHour;
        int waitingMinute = (peopleInLine * visitMinutes) % minutesInHour;

        Console.WriteLine("Вам предстоит отстоять в очереди: " +
                        $"{waitingHour}h {waitingMinute}m");
    }
}
