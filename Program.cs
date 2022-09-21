using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Obj
{
    class Program
    {


        static StudInfo ReadInfo()
        {
            StudInfo studentInfo = new StudInfo();

            Console.Write("Please enter your name: ");
            studentInfo.name = Console.ReadLine();

            Console.Write("Please enter your ID:  ");
            studentInfo.id = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter your faculty:  ");
            studentInfo.faculty = Console.ReadLine();

            Console.Write("Please enter your department:  ");
            studentInfo.department = Console.ReadLine();

            Console.Write("Please enter your advisor:  ");
            studentInfo.advisor = Console.ReadLine();

            return studentInfo;
        }
        
        

       static void ShowInfo(StudInfo studentInfo)
        {
            Console.WriteLine("{0,3}  ||    {1,-10}  ||     {2,2}    ||  {3,-9}   ||   {4,1}",studentInfo.name, studentInfo.id, studentInfo.faculty
             , studentInfo.department, studentInfo.advisor);


        }
        static void Main()
        {
            Console.WriteLine("How many students do you have? ");
            int n =int.Parse(Console.ReadLine());
            StudInfo[] students = new StudInfo[n];

            for (int i = 0; i < n; i++)
                students[i] = ReadInfo();

            for (int i = 0; i < n; i++)
                ShowInfo(students[i]);
        }
        

        
    }
}