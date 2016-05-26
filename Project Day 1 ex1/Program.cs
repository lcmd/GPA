using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Day_1_ex1
{
    class Program
    {
        static void Main(string[] args)
        {




            //Console.WriteLine("English grade :");
            //char Englishgrade = char.Parse(Console.ReadLine());

            //Console.WriteLine("Math grade :");
            //char Mathgrade = char.Parse(Console.ReadLine());

            //Console.WriteLine("Science grade :");
            //char Sciencegrade = char.Parse(Console.ReadLine());

            //Console.WriteLine("History grade :");
            //char Historygrade = char.Parse(Console.ReadLine());

            //Console.WriteLine("Business grade :");
            //char Businessgrade = char.Parse(Console.ReadLine());

            //Bonus
            
            double currentPoints = 0;
            double totalPoints = 0;

            Console.WriteLine("Student Name: ");
            string studentName = Console.ReadLine();
            Console.WriteLine("Number of classes: ");
            int numberOfClasses = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numberOfClasses; i++) 
            { 
            Console.WriteLine("Enter Grade: ");
            string grade = Console.ReadLine();
                grade = grade.ToUpper();

                switch (grade)
                {
                    case "A":
                        currentPoints = 4.0;
                        totalPoints += currentPoints;

                        break;
                    case "B":
                        currentPoints = 3.0;
                        totalPoints += currentPoints;

                        break;
                    case "C":
                        currentPoints = 2.0;
                        totalPoints += currentPoints;
                        break;
                    case "D":
                        currentPoints = 1.0;
                        totalPoints += currentPoints;
                        break;
                    case "F":
                        currentPoints = 0.0;
                        totalPoints += currentPoints;

                        break;
                }
               // Console.WriteLine(totalPoints);
            }
            Console.WriteLine("Student Name is " + studentName);
            //Console.WriteLine(totalPoints);
           // Console.WriteLine(numberOfClasses);
            double finalGrade = (totalPoints / numberOfClasses);
           Console.WriteLine("GPA: {0} ", finalGrade);


        }
    }
}
