using System;

namespace CSharpMiniProjects
{
    public static class GreetingHelper
    {
        public static string GetGreeting()
        {
            return DateTime.Now.Hour < 18 ? "Good morning" : "Good evening"; // 18:00 after goodevening this in 24 format
        }
    }
}