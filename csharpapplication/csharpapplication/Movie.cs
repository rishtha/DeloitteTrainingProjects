using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //file handling

namespace csharpapplication
{
    internal class Movie
    {
        public void CreateMovie(String mid, String mname, String mdesc, String mlang)
        {
            //how to create file
            FileStream fileStreamObj = new FileStream(
                @"C:\11personal use\visual studio\movie.txt", FileMode.Create, FileAccess.Write
                );

            // how to write a file
            StreamWriter streamWriter = new StreamWriter(fileStreamObj);
            streamWriter.WriteLine("Movie Id : " + mid +
                "\nMovie Name : " + mname + 
                "\nMovie Desc : " + mdesc +
                "\nMovie Language : " +mlang);
            streamWriter.Close();//close writing operation
            fileStreamObj.Close(); //close file operation
            Console.WriteLine("File operation complete");

        }

        public void SelectMovies() {
            FileStream fileStream = new FileStream(
                @"C:\11personal use\visual studio\movie.txt", FileMode.Open, FileAccess.Read
                );
            StreamReader streamReaderObj = new StreamReader(fileStream);

            while (streamReaderObj.Peek() > 0)
            {

                //Console.WriteLine(streamReaderObj.ReadLine());
                //Console.WriteLine(streamReaderObj.ReadLine());
                //Console.WriteLine(streamReaderObj.ReadLine());
                //Console.WriteLine(streamReaderObj.ReadLine());



                //arrays and how to declare it. fixed and dynamic array

                string[] myValues = new string[5];
                myValues[0] = "A";
                myValues[0] = "B";
                myValues[0] = "C";
                myValues[0] = "D";
                myValues[0] = "E";

                while (streamReaderObj.Peek() > 0)
                {
                    string line = (streamReaderObj.ReadLine());
                    string[] myStrs = line.Split(':');
                    Console.WriteLine(myStrs[1]);
                }
            }
            fileStream.Close();
        }
    }
}
