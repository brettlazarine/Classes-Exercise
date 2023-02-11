using Microsoft.VisualBasic;
using System.Xml.Schema;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var f150 = new Car()
            {
                Make = "Ford",
                Model = "F150",
                Year = 2015
            };
            Console.WriteLine($"Make: {f150.Make}\n" +
                $"Model: {f150.Model}\n" +
                $"Year: {f150.Year}");
        }
    }
}
