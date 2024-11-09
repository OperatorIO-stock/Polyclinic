using System;

namespace Polyclinic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Укажите количество человек в очереди");
        int peopleQuery = int.Parse(Console.ReadLine());
        int waitInMinutes = 10;

        int hourInMinutes = 60;

        int resultHours = (peopleQuery * waitInMinutes) / hourInMinutes;
        int resultMinutes = (peopleQuery * waitInMinutes) % hourInMinutes;

        Console.WriteLine("Вам предстоит отстоять в очереди: " +
                        $"{resultHours}h {resultMinutes}m");
    }
}
