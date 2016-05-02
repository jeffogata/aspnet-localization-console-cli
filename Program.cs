namespace LocalizationConsole
{
    using System;
    using System.IO;
    using System.Globalization;
        
    public static class Program
    {
        private static readonly DateTime _date = new DateTime(2016, 5, 1);
        private static readonly decimal _number = 1234567.89m;
        private static readonly int _currency = 42;
        
        public static void Main(string[] args)
        {
            WriteDivider();
            WriteFormattedValues("en-US");
            WriteFormattedValues("de-DE");
            WriteFormattedValues("de-CH");
            WriteFormattedValues("fr-FR");
            WriteFormattedValues("fr-CH");
            WriteFormattedValues("ko-KR");
        }
        
        private static void WriteFormattedValues(string cultureName)
        {
            var culture = new CultureInfo(cultureName);
            
            Console.WriteLine($"\tCulture:  {culture.EnglishName}");
            Console.WriteLine($"\tDate:     {_date.ToString("d", culture)}");
            Console.WriteLine($"\tNumber:   {_number.ToString("n", culture)}");
            Console.WriteLine($"\tCurrency: {_currency.ToString("c", culture)}");
            WriteDivider();
        }
        
        private static void WriteDivider()
        {
            Console.WriteLine(new String('-', 50));
        }
    }
}