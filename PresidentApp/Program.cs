namespace PresidentApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Console.WriteLine("Are you a natural born citizen. Type Yes or No");
            bool found_answer = true;
            do
            {
                string natural_born_citizen = Console.ReadLine();
                if (natural_born_citizen != "Yes" || natural_born_citizen != "No")
                {
                    Console.WriteLine("Wrong input. Please enter the corrent input either yes or no");
                    found_answer = false;
                }
            } while (!found_answer);
            Console.WriteLine("Please enter your birthday: ");
            string birthday = Console.ReadLine();
            Console.WriteLine("Enter in the number of years you have resided in the United States");
            string yearResidedInUs = Console.ReadLine();
            Console.WriteLine("How many Prior Terms have You served");
            int priorTermsServed = int.Parse(Console.ReadLine());
        }
    }
}