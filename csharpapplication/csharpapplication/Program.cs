using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;


//Return Type methods - in, string, float, decimal, object
//No return type method - Void

namespace csharpapplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //console.writeline("enter value a :");
            //int a = convert.toint32(console.readline());
            //console.writeline("enter value b :");
            //int b = convert.toint32(console.readline());
            //int c = a + b;
            //c printf statement equivalent
            //console.write("output c : ");
            //console.writeline(c);
            //c scanf statement equivalent

            //Event eventObj = new Event(); //object creation
            //eventObj.CreateEvent();
            //eventObj.selectEvent();
            //Console.Read();


            //for (int i = 0; i < 5; i++) { 
            //    Console.WriteLine(i);
            //}


            ////Read movie details from user
            //Console.Write("Enter the movie id :");
            //String movieId = Console.ReadLine();

            //Console.Write("Enter the movie name :");
            //String moviename = Console.ReadLine();

            //Console.Write("Enter the movie description :");
            //String moviedesc = Console.ReadLine();

            //Console.Write("Enter the movie Language :");
            //String movieLang = Console.ReadLine();


            //Movie MovieObj = new Movie();
            //MovieObj.CreateMovie(movieId, moviename, moviedesc, movieLang);

            //Movie MovieSelect = new Movie();
            //MovieSelect.SelectMovies();


            //serializationex serialize = new serializationex();
            //serialize.XmlSerialize();
            //serialize.XmlDeserialize();

            //serialize.JsonSerialize();



            //GenericsDemo genericsDemo = new GenericsDemo();
            //genericsDemo.ShowSalaryReport(400.20);
            //genericsDemo.ShowAgeReport(30);
            //genericsDemo.ShowGenderReport("Male");






            // XML SERIALIZATION AND DESERIALIZATION

            //serializationex serialize = new serializationex();
            //serialize.XmlSerialize();
            //serialize.XmlDeserialize();


            //serializationex serialize = new serializationex();
            //serialize.XmlSerialize();
            //serialize.XmlDeserialize();

            
            
            //JSON SERIALIZATION AND DESERIALIZATION
            serializationex jsonzserialization = new serializationex();
            jsonzserialization.JsonSerialize();
           




        }
    }
}
