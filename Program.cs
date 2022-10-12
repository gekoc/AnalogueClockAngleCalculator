internal class Program
{
    public static void Main(string[] args)
    {
        var hours = GetHoursInput();
        var minutes = GetMinutesInput();
        var angle = GetAngleBetweenArrows(hours, minutes);

        Console.WriteLine($"Angle between arrows of the clock will be {angle} degrees at {hours}:{minutes}");

    }

    public static double GetHoursInput()
    {
        Console.WriteLine("Please enter the hour in 12h format (1-12)");
        var input = Console.ReadLine();
        var hours = 0;

        while(!int.TryParse(input, out hours) || !(hours >= 1 && hours <= 12)){
            Console.WriteLine("Please enter a value between 1 and 12");
            input = Console.ReadLine();
        }

        return (double)hours;
    }

    public static double GetMinutesInput()
    {
        Console.WriteLine("Please enter the minutes (0-59)");
        var input = Console.ReadLine();
        var minutes = 0;

        while (!int.TryParse(input, out minutes) || !(minutes >= 0 && minutes <= 59)){
            Console.WriteLine("Please enter a value between 1 and 12");
            input = Console.ReadLine();
        }

        return (double)minutes;
    }

    public static double GetAngleBetweenArrows(double hours, double minutes)
    {
        var angle = (hours * 30) - (minutes * 5.5);
        
        if (angle > 180)
        {
            angle = 360 - angle;
        }

        return angle;
    }
}