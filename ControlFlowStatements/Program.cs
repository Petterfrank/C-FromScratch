namespace ControlFlowStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IfStatement();
            SwitchStatement();

        }
        private static void IfStatement()
        {
            int number = 10;
            if (number > 5)
                Console.WriteLine("The number is grater than 5.");
            else
                Console.WriteLine("The number is 5 or less.");
        }

        private static void IfElseExample()
        {
            int number = 10;
            if (number > 5)
            {
                Console.WriteLine("The number is grater than 5.");
                Console.WriteLine("This is another line inside the if block.");
            }
            else
            {
                Console.WriteLine("The number is 5 or less.");
                Console.WriteLine("This is another line inside the else block.");
            }
        }

        private static void SwitchStatement()
        {
            int day = 3;
            string dayName;
            switch (day)
            {
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                case 7:
                    dayName = "Sunday";
                    break;
                default:
                    dayName = "Invalid day";
                    break;
            }
            Console.WriteLine($"The day is: {dayName}");
        }
    }
}
