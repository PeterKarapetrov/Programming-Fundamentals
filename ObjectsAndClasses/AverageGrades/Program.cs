using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define a class Student, which holds the following information about students: name, 
            //list of grades and average grade(calculated property, read-only). A single grade will be in range[2…6], e.g. 3.25 or 5.50.
            //Read a list of students and print the students that have average grade ≥ 5.00 ordered by name(ascending), 
            //then by average grade(descending). Print the student name and the calculated average grade.
            // Diana -> 5.75

            int studentsNum = int.Parse(Console.ReadLine());
            List<Student> studentsClass = new List<Student>();

            for (int num = 0; num < studentsNum; num++)
            {
                List<string> inputLine = Console.ReadLine().Split().ToList();
                Student student = new Student();
                student.Name = inputLine[0];
                inputLine.RemoveAt(0);
                student.Grades = inputLine.Select(double.Parse).ToList();
                studentsClass.Add(student);
            }

            foreach (var exellentStudent in studentsClass.Where(x => x.AverageGrade >= 5.00).OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade))
            {
                Console.WriteLine($"{exellentStudent.Name} -> {exellentStudent.AverageGrade:f2}");
            }

        }
    }

    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade { get { return Grades.Average(); } }
    }
}
