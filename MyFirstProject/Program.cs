using MyFirstProject.Probelms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


namespace MyFirstProject
{
    internal class Program
    {
        static ReverseSentense _ReverseSentense;
        static void Main(string[] args)
        {
            _ReverseSentense = new ReverseSentense();
            string reversedSentence = _ReverseSentense.SentenseReverse("he is a good boy");
            Console.WriteLine(reversedSentence);
            Console.ReadKey();
            ////_PrintOddWords(); // odd or even
            ////_PracticeConditions();


            //Environment.Exit(0);

            //Console.Write("Enter your Name: ");
            //string message = Console.ReadLine();

            //Console.Write("Enter your age: ");
            //int age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Your Info: " + message + " " + age);

            //string text_message = "checking";

            //Console.WriteLine(text_message);

            //Console.ReadLine();
        }


        static void _PrintOddWords()
        {
            string text = "This is Even number";

            // split string 
            string[] result = text.Split(' ');

            for (int i = 0; i < result.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(result[i]);
                }
            }
            Console.ReadLine();

        }

        static void _PracticeConditions()
        {
            //Console.WriteLine("Enter a Value: ");
            //int number = int.Parse(Console.ReadLine());
            //int i = 0;

            //while (i < number)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //Console.ReadKey();

            //Console.WriteLine("Choose the action you want to do:");
            //Console.WriteLine("1. Add Employee");
            //Console.WriteLine("2. Update Employee");
            //Console.WriteLine("3. Delete Employee");
            //Console.WriteLine("99. Exit application");
            
            //String selectedAction = Console.ReadLine();

            //while(selectedAction != "99")
            //{

            //switch(selectedAction)
            //{
            //    case "1":
            //        Console.WriteLine("Adding new Employee");
            //        break;
            //    case "2":
            //        Console.WriteLine("Updating Employee");
            //        break;
            //    case "3": 
            //        Console.WriteLine("Deleting Employee"); 
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Input");
            //            break;
            //}
            //    Console.WriteLine("Choose the action you want to do:");
            //    Console.WriteLine("1. Add Employee");
            //    Console.WriteLine("2. Update Employee");
            //    Console.WriteLine("3. Delete Employee");
            //    Console.WriteLine("99. Exit application");

            //     selectedAction = Console.ReadLine();

            //}
            //Console.ReadKey();

            int i = 0;
            int j = 0;

            while(i < 10)
            {
                while (j < 10)
                {
                    Console.WriteLine("i: " + i + "  j" + j);
                    j++;
                }
                j = 0;
                i++;
            }
            Console.ReadKey();
        }

    }
}
