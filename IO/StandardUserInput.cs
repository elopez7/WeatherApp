using System;

namespace WeatherApp.IO
{
    public class StandardUserInput : IUserInput
    {
        public string GetInput()
        {
            return Console.ReadLine()?.Trim();
        }
    }
}