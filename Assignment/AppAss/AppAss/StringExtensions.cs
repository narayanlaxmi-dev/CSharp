using System.Linq;

namespace CSharpMiniProjects
{
    public static class StringExtensions
    {
        public static int CountVowels(this string str)
        {
            return str.Count(c => "aeiouAEIOU".Contains(c));
        }

        public static string AddSuffix(this string str, string suffix)
        {
            return str + suffix;
        }
    }
}