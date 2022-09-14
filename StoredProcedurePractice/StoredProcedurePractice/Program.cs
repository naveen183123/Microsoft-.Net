using StoredProcedurePractice.DAL;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
namespace StoredProcedurePractice
{
    class Program
    {
        private static IConfiguration? _iconfiguration;
        static void Main(string[] args)
        {
            GetAppSettingsFile();
            PrintCountries();
        }   
        static void GetAppSettingsFile()
        {
            var builder = new ConfigurationBuilder()
                                 .SetBasePath(Directory.GetCurrentDirectory())
                                 .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            _iconfiguration = builder.Build();
        }
        static void PrintCountries()
        {
#pragma warning disable CS8604 // Possible null reference argument.
            var countryDAL = new CountryDAL(_iconfiguration);
#pragma warning restore CS8604 // Possible null reference argument.
            var listCountryModel = countryDAL.GetList();
            listCountryModel.ForEach(item =>
            {
                Console.WriteLine(item.Country);
            });
            Console.WriteLine("Press any key to stop.");
            Console.ReadKey();
        }
    }
}