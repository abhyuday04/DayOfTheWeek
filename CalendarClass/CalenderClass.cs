namespace CalenderLibrary1

{
     public class CalenderClass
    {
        public static void Main()
        {
            CalenderClass cc = new();
            Console.WriteLine(" Input the Date: ");
            DateTime inputDate = DateTime.Parse(Console.ReadLine());
            int day = inputDate.Day;
            int m = inputDate.Month;
            int y = inputDate.Year;
            int d = CalenderFunction.dayOfDate(day, m, y);
            Console.WriteLine("The day on this date is: " + Day(d));
            Console.ReadLine();

        }
        public static string Day(int d)
        {
            return d switch
            {
                0 => "Sunday",
                1 => "Monday",
                2 => "Tuesday",
                3 => "Wednesday",
                4 => "Thursday",
                5 => "Friday",
                6 => "Saturday",
                _ => "Incorrect"
            };
        }



    }



}