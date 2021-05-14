using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp1
{
    [Serializable]
    class Student
    {
        public string Surname { get; private set; }

        public int Course { get; private set; }

        public Student(string surname, int course)
        {
            Surname = surname;
            Course = course;
        }
    }

    [Serializable]
    class Group
    {
        public string GroupNumber { get; private set; }

        public List<Student> students;

        public Group(string groupNumber, Student[] students)
        {
            this.students = new List<Student>(students);

            GroupNumber = groupNumber;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Group[] groups = new Group[2];

            for (int idx = 0; idx < groups.Length; idx++)
            {
                string groupNumber = ((char)new Random().Next('A', 'Z')).ToString() + new Random().Next(1, 10);

                Student[] students = new Student[Convert.ToInt32(Console.ReadLine())];

                for (int index = 0; index < students.Length; index++)
                {
                    string surname = new string((char)new Random().Next('A', 'Z'), new Random().Next(1, 10));
                    int course = new Random().Next(1, 5);

                    students[index] = new Student(surname, course);
                }

                groups[idx] = new Group(groupNumber, students);
            }

            BinaryFormatter formatter = new BinaryFormatter();
            using (var stream = new FileStream("data.bin", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(stream, groups);
            }

            using (Stream stream = new FileStream("data.bin", FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                Group[] groupsFromFile = formatter.Deserialize(stream) as Group[];

                Array.ForEach(groupsFromFile, group => Array.ForEach(group.students.ToArray(), student =>
                    Console.WriteLine($"{group.GroupNumber}: {student.Surname}, {student.Course}")));
            }
        }
    }
}
