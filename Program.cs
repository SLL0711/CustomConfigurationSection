using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using CustomConfigurationSection.CustomConfigSection;

namespace CustomConfigurationSection
{
    class Program
    {
        static void Main(string[] args)
        {
            var section = (UrlSection)ConfigurationManager.GetSection("Url");

            Console.WriteLine("sectionName:" + section.Name);
            Console.WriteLine(section.Simple.Name);

            foreach (var url in section.urls)
            {
                var obj = (UrlElement)url;
                Console.WriteLine("urlName:" + obj.Name);
                Console.WriteLine("baseUrl:" + obj.BaseUrl);
                Console.WriteLine("Port:" + obj.Port);
                Console.WriteLine("Query:" + obj.Query);
            }

            Console.Read();
        }
    }
}
