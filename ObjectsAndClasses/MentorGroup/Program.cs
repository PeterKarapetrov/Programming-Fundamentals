using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace MentorGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Student> mentorGroup = new Dictionary<string, Student>();
            string[] inputLine = Console.ReadLine().Split().ToArray();

            while (inputLine[0] != "end")
            {
                if (mentorGroup.ContainsKey(inputLine[0]) == false)
                {
                    Student student = new Student();
                    student.Name = inputLine[0];
                    student.AttendanceList = inputLine[1].Split(',').ToList();

                    mentorGroup.Add(inputLine[0], student);
                }
                else
                {
                    mentorGroup[inputLine[0]].AttendanceList.AddRange(inputLine[1].Split(','));
                }

                inputLine = Console.ReadLine().Split().ToArray();
            }

            inputLine = Console.ReadLine().Split('-').ToArray();
            while (inputLine[0] != "end of comments")
            {
                if (mentorGroup.ContainsKey(inputLine[0]) == true)
                {
                    if (mentorGroup[inputLine[0]].Comments == null)
                    {
                        mentorGroup[inputLine[0]].Comments = new List<string>() {inputLine[1]};
                    }
                    else
                    {
                        mentorGroup[inputLine[0]].Comments.Add(inputLine[1]);
                    }
                    
                }

                inputLine = Console.ReadLine().Split('-').ToArray();
            }

            foreach (var student in mentorGroup)
            {
                Console.WriteLine(student.Key);
                Console.WriteLine("Comments:");
                foreach (var comment in student.Value.Comments.Where(x => x != null))
                {
                        Console.WriteLine("- " + comment);
                }    
                Console.WriteLine("Dates attended:");
                foreach (var date in student.Value.AttendanceList.OrderBy(x => x))
                {
                    Console.WriteLine("-- " + date);
                }
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
        public List<string> AttendanceList = new List<string>();
        public List<string> Comments = new List<string>();
    }
}
