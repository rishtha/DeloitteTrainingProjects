using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

using System.Text.Json;


namespace csharpapplication
{
    //public class Employee {
    //    public int Id = 1;
    //    public string name = "John Smith";
    //    public string subject = "Physics";
    //}

    //public class WeatherForecastNew {
    //    public DateTimeOffset Date { get; set; }
    //    public int TemperatureCelsius { get; set; }
    //    public string Summary { get; set; }
    //}


    public class Person {
        public string name { get; set; }
        public int age { get; set; }
        public string city { get; set; }
    
    }
    internal class serializationex
    {
        //public void JsonSerialize() {
        //    var WeatherForecastNew = new WeatherForecastNew
        //    {
        //        Date = DateTime.Parse("2019-08-01"),
        //        TemperatureCelsius = 25,
        //        Summary = "Hot"
        //    };
        //    //serialize from object to json
        //    string jsonString = System.Text.Json.JsonSerializer.Serialize(WeatherForecastNew);

        //    //Deserialize from Json to object
        //    var obj = System.Text.Json.JsonSerializer.Deserialize <WeatherForecastNew>(jsonString);
        //    Console.WriteLine(obj.Date);
        //    Console.WriteLine(obj.TemperatureCelsius);  
        //    Console.WriteLine(obj.Summary);


        //}

        //public void XmlSerialize() {
        //    Employee bs = new Employee();
        //    XmlSerializer xs = new XmlSerializer(typeof(Employee));
        //    TextWriter txtWriter = new StreamWriter(@"C:\11personal use\visual studio\serialization.xml");
        //    xs.Serialize(txtWriter, bs);
        //    txtWriter.Close();
        //}

        //public void XmlDeserialize() {
        //    Employee bs = new Employee();
        //    XmlSerializer xs = new XmlSerializer(typeof(Employee));
        //    StreamReader reader = new StreamReader(@"C:\11personal use\visual studio\serialization.xml");
        //    bs = (Employee)xs.Deserialize(reader);
        //    Console.WriteLine("Employee Details");
        //    Console.WriteLine("Id: " + bs.Id);
        //    Console.WriteLine("Name: " + bs.name);
        //    Console.WriteLine("Subject: "+ bs.subject);

        //}














        //XML SERIALIZATION AND DESERIALIZATION
        //public void XmlSerialize() 
        //{
        //    Person personobj = new Person
        //    {


        //    name = Console.ReadLine(),

        //    age = Convert.ToInt32(Console.ReadLine()),

        //    city = Console.ReadLine()
        //};
        //    XmlSerializer xs = new XmlSerializer(typeof(Person));

        //    TextWriter txtwriter = new StreamWriter(@"C:\11personal use\visual studio\serializationnew.xml");
        //    xs.Serialize(txtwriter,personobj);
        //    txtwriter.Close();  
        //}


        //public void XmlDeserialize()
        //{
        //    Person Personobjdeserialize = new Person();
        //    XmlSerializer xs = new XmlSerializer(typeof(Person));
        //    StreamReader reader = new StreamReader(@"c:\11personal use\visual studio\serializationnew.xml");
        //    Personobjdeserialize = (Person)xs.Deserialize(reader);
        //    Console.WriteLine("person details");
        //    Console.WriteLine("name: " + Personobjdeserialize.name);
        //    Console.WriteLine("age: " + Personobjdeserialize.age);
        //    Console.WriteLine("subject: " + Personobjdeserialize.city);

        //}













        //JSON SERIALIZATION AND DESERIALIZATION

        public void JsonSerialize() 
        {
            var personobjjson = new Person 
            { 
                name =  Console.ReadLine(),
                age =  Convert.ToInt32(Console.ReadLine()),
                city = Console.ReadLine(),
            };


            string jsonString = System.Text.Json.JsonSerializer.Serialize(personobjjson);
            var objectjson = System.Text.Json.JsonSerializer.Deserialize<Person>(jsonString);
            Console.WriteLine(objectjson.name);
            Console.WriteLine(objectjson.age);
            Console.WriteLine(objectjson.city);

        }

    }
}
