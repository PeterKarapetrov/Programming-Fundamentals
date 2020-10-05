using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace MentorGroupIII
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentsList = new List<Student>();
            string inputLine = Console.ReadLine();

            while (inputLine != "end of dates")
            {
                string[] userAndDates = inputLine.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string user = userAndDates[0];
                if (studentsList.Any(x => x.Name == user) == false)
                {
                    Student newStudent = new Student();
                    newStudent.Name = user;
                    newStudent.AtendaceList = new List<DateTime>();
                    for (int index = 1; index < userAndDates.Length; index++)
                    {
                        newStudent.AtendaceList.Add(DateTime.ParseExact(userAndDates[index], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                    }
                    studentsList.Add(newStudent);
                }
                else
                {
                    for (int index = 1; index < userAndDates.Length; index++)
                    {
                        foreach (var student in studentsList.Where(x => x.Name == user))
                        {
                            student.AtendaceList.Add(DateTime.ParseExact(userAndDates[index], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                        }
                    }
                }

                inputLine = Console.ReadLine();
            }

            inputLine = Console.ReadLine();
            while (inputLine != "end of comments")
            {
                string[] userWithComment = inputLine.Split('-').ToArray();
                string user = userWithComment[0];
                string comment = userWithComment[1];
                if (studentsList.Any(x => x.Name == user) == false)
                {
                    inputLine = Console.ReadLine();
                    continue;
                }
                else
                {
                    foreach (var student in studentsList.Where(x => x.Name == user))
                    {
                        if (student.CommentsList.Count == 0)
                        {
                            student.CommentsList = new List<string>();
                            student.CommentsList.Add(comment);
                        }
                        else
                        {
                            student.CommentsList.Add(comment);
                        }                        
                    }
                }

                inputLine = Console.ReadLine();
            }

            foreach (var student in studentsList.OrderBy(x => x.Name))
            {
                Console.WriteLine(student.Name);
                Console.WriteLine("Comments:");
                foreach (var comment in student.CommentsList)
                {
                    Console.WriteLine($"- {comment}");
                }
                Console.WriteLine("Dates attended:");
                foreach (var date in student.AtendaceList.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {date:dd/MM/yyy}");
                }
            }

        }
    }

    class Student
    {
        public string Name {get; set; }
        public List<DateTime> AtendaceList { get; set; }
        public List<string> CommentsList = new List<string>();
    }
}
