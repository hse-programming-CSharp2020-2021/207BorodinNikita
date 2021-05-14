using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace ConsoleApp2
{
    [Serializable]
    public class Human
    {
        public string Name { get; set; }
        public Human() { }
        public Human(string name)
        {
            this.Name = name;
        }
    }

    [Serializable]
    public class Professor : Human
    {
        public Professor(string name) : base(name) { }

        public Professor() { }
    }

    [Serializable]
    public class Dept
    {
        public string DeptName { get; set; }

        List<Human> staff;
        public List<Human> Staff { get { return staff; } set { staff = value; } }

        public Dept() { }

        public Dept(string name, Human[] staffList)
        {
            this.DeptName = name;
            staff = new List<Human>(staffList);
        }
    }

    [Serializable]
    public class University
    {
        public string UniversityName { get; set; }

        public List<Dept> Departments { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Professor[] professorsA = { new Professor("Michael M."), new Professor("Alexander B.") };
            Professor[] professorsB = { new Professor("Evgeniy D."), new Professor("Lev H.") };

            Dept[] depts = { new Dept("Department A", professorsA), new Dept("Department B", professorsB) };

            University university = new University()
            {
                UniversityName = "DGU",
                Departments = new List<Dept>(depts)
            };

            XmlSerializer formatter = new XmlSerializer(typeof(University), 
                new Type[] { typeof(Dept), typeof(Professor), typeof(Human), });

            using (var stream = new FileStream("data.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(stream, university);
            }

            using (var stream = new FileStream("data.xml", FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                University universityFromFile = formatter.Deserialize(stream) as University;
            }
        }
    }
}


