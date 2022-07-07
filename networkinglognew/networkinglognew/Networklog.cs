using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace networkinglognew
{
    internal class Networklog
    {
        public void Networklogging()
        {
            FileStream fileStream = new FileStream(
                @"C:\11personal use\visual studio\networklog.txt", FileMode.Open, FileAccess.Read
                );
            StreamReader streamReaderObj = new StreamReader(fileStream);

            //Console.WriteLine(streamReaderObj.ReadToEnd());
            Console.WriteLine("Id\t" + "Source\t" + "Destination\t" + "Date\t" + "Time\t" + "Status\t" + "Network\t");



            while (streamReaderObj.Peek() > 0)
            {
                int i = 0;
                while (i < 6)
                {
                    string line = (streamReaderObj.ReadLine());
                    if (line != null)
                    {
                        if (line.StartsWith("Date"))
                        {
                            string[] myStrs = line.Split(' ');
                            string[] string2 = myStrs[0].Split(':');

                            Console.Write(string2[1] + "\t" + myStrs[1]);
                        }

                        else
                        {
                            if (line != "")
                            {
                                string[] myStrs = line.Split(':');
                                Console.Write(myStrs[1] + "\t");
                            }
                        }
                    }
                    i++;
                }
            }
            //while (streamReaderObj.Peek() > 0) { 
            //    Console.WriteLine(streamReaderObj.ReadLine());
            //    string line = (streamReaderObj.ReadLine());
            //    string[] myStrs = line.Split(':');
            //    Console.WriteLine(myStrs[1]);

            //    //while (streamReaderObj.Peek() > 0)
            //    //{
            //    //    string line = (streamReaderObj.ReadLine());
            //    //    string[] myStrs = line.Split(':');


            //    //    Console.WriteLine(myStrs[1]);
            //    //}
            //}
            fileStream.Close();
        }
    }
}
