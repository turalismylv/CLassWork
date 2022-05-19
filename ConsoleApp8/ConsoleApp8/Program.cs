using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student
            {
                FinalGrade = 80,
                MidtermGrade =60
            

            };
            Student stud2 = new Student
            {
                FinalGrade = 100,
                MidtermGrade = 0


            };
            stud.IsCoursePassed(80);
            stud2.IsCoursePassed(80);
            
        }
    }
    class Student {
        public int MidtermGrade;
        public int FinalGrade;

        public void IsCoursePassed(int passedPoint)
        {
            int umumiBal = (MidtermGrade * 40 / 100) + (FinalGrade * 60 / 10);
            if (umumiBal>=passedPoint)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
          }
    }
}
