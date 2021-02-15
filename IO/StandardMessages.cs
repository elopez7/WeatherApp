using System;

namespace WeatherApp.IO
{
    public static class StandardMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Console Weather Application!\n" +
                              "Initializing. Please wait\n");
        }

        public static void InitializationCompletedMessage()
        {
            Console.WriteLine("Initialization Completed!\n");
        }

        public static void CityNamePromptMessage()
        {
            Console.WriteLine("Enter the name of your city: ");
        }
        
        public static void CountryNamePromptMessage()
        {
            Console.WriteLine("Enter the name of your country: ");
        }

        public static void EndApplication()
        {
            Console.WriteLine("End of Application. Press enter key to exit\n");
            Console.ReadLine();
        }

        public static void DisplayValidationErrorMessage(string field)
        {
            Console.WriteLine($"{field} is invalid");
        }
    }
}