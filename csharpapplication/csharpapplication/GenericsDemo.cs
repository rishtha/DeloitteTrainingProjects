using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpapplication
{
    internal class GenericsDemo
    {
        //public void ShowAgeReport(int age) 
        //{ 
        //    Console.WriteLine(age);
        //}

        //public void ShowGenderReport(string gender)
        //{
        //    Console.WriteLine(gender);
        //}

        //public void ShowSalaryReport(double salary) 
        //{
        //    Console.WriteLine(salary);
        //}



        //public static void Data()
        //{
        //    ArrayList arrayList = new ArrayList();
        //    arrayList.Add(10);

        //    //Generic
        //    List<int> list = new List<int>();
        //    list.Add(10);




        //    //Stack LIFO
        //    Stack stack = new Stack();
        //    stack.Push(10);
        //    stack.Push("name");
        //    stack.Push("5000");

        //    Console.WriteLine(stack.Pop());
        //    Console.WriteLine(stack.Pop());
        //    Console.WriteLine(stack.Pop());


        //    //Queue FIFO
        //    Queue queue = new Queue();
        //    queue.Enqueue(10);
        //    queue.Enqueue("name");

        //    Console.WriteLine(queue.Dequeue());


        public static void Generic() 
        { 
            Dictionary<int, string> student = new Dictionary<int, string>();
            student[101] = "passed";
            student[102] = "Passed";
            student[103] = "failed";
            student[104] = "failed";

            foreach (var item in student) 
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);

                //get value by passing key
                Console.WriteLine(student[item.Key]);



                Console.WriteLine("Enter your roll no.");
                int key = Convert.ToInt32(Console.ReadLine());

            }


            Hashtable hashtable = new Hashtable();
            hashtable[101] = "Passed";
            hashtable[102] = "Failed";
            hashtable[103] = "Failed";
        }

    }

}
