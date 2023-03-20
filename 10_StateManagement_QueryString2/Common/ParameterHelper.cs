using System.Text.RegularExpressions;

namespace _10_StateManagement_QueryString2.Common
{
    public static class ParameterHelper
    {
        // extension metot yazalım...
        public static string UrlRegex(this string input) // this string input parametresinde this bulunduğu insance anlamına gelir...
        {
            Regex reg = new Regex("[*'\",_&#^@/ ]");
            input = reg.Replace(input, string.Empty);
            return input;
        }
    }
}
