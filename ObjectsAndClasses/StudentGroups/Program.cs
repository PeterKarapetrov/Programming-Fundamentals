using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace StudentGroups
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            List<Town> towns = new List<Town>();
            List<Group> groups = new List<Group>();

            while (inputLine != "End" )
            {
                towns = ReadsTownAndStudents(inputLine, towns);
                inputLine = Console.ReadLine();
            }

            groups = DistributeStudentsIntoGroups(towns);

            Console.WriteLine($"Created {groups.Count} groups in {towns.Count} towns:");
            foreach (var group in groups.OrderBy(x => x.Town.Name))
            {
                Console.Write($"{group.Town.Name} => ");
                Console.WriteLine($"{string.Join(", ", group.Students.Select(x => x.Email))}");
            }

        }

        public static List<Town> ReadsTownAndStudents(string input, List<Town> towns)
        {

            if (input.Contains("=>") == true)
            {
                Town newTown = new Town();
                string[] townAndSeats = input.Split(new char[] { '=', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                newTown.Name = townAndSeats[0].Trim();
                string[] seats = townAndSeats[1].Split(new char [] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                newTown.SeatCount = int.Parse(seats[0].Trim());
                newTown.Students = new List<Student>();
                towns.Add(newTown);
            }
            else
            {
                Student newStudent = new Student();
                string[] studentRecord = input.Split(new char[] {'|'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                newStudent.Name = studentRecord[0].Trim();
                newStudent.Email = studentRecord[1].Trim();
                newStudent.RegistrationDate = DateTime.Parse(studentRecord[2].Trim());
                towns.Last().Students.Add(newStudent);
            }

        return towns;
        }

        public static List<Group> DistributeStudentsIntoGroups(List<Town> towns)
        {
            List<Group> groups = new List<Group>();

            foreach (var town in towns.OrderBy(x => x.Name))
            {
                IEnumerable<Student> students = town.Students.OrderBy(x => x.RegistrationDate).ThenBy(x => x.Name).ThenBy(x => x.Email);
                while (students.Any())
                {
                    var group = new Group();
                    group.Town = town;
                    group.Students = students.Take(group.Town.SeatCount).ToList();
                    students = students.Skip(group.Town.SeatCount);
                    groups.Add(group);
                }
            }
            return groups;
        }
    }


    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
    
    class Town
    {
        public string Name { get; set; }
        public int SeatCount { get; set; }
        public List<Student> Students { get; set; }
    }

    class Group
    {
        public Town Town { get; set; }
        public List<Student> Students { get; set; }
    }

}
