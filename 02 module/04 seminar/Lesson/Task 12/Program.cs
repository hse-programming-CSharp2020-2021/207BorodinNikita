using System;

class Person
{
    public string FullName { get; set; }
    public DateTime BirthDate { get; set; }
    public bool IsMale { get; set; }
    public Person(string fullname, DateTime bitrhdate, bool ismale)
    {
        FullName = fullname;
        BirthDate = bitrhdate;
        IsMale = ismale;
    }
    public virtual void ShowInfo()
    {
        Console.WriteLine($"Full name: {FullName}\nBirth date: {BirthDate}\nGender: {(IsMale ? "Male" : "Female")}");
    }
}

class Student : Person
{
    string Institute { get; set; }
    string Speciality { get; set; }
    public Student(string fullname, DateTime bitrhdate, bool ismale, string inst, string spec)
        : base(fullname, bitrhdate, ismale)
    {
        Institute = inst;
        Speciality = spec;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"\tFull name: {FullName}\nBirth date: {BirthDate}\nGender: {(IsMale ? "Male" : "Female")}\nInstitute: { Institute}\nSpeciality: {Speciality}\n");
    }
}

class Employee : Person
{
        string CompanyName { get; set; }
        string Post { get; set; }
        string Schedule { get; set; }
        decimal Salary { get; set; }

    public Employee(string fullname, DateTime bitrhdate, bool ismale, string company, string post, string shedule, decimal salary)
        : base(fullname, bitrhdate, ismale)
    {
        CompanyName = company;
        Post = post;
        Schedule = shedule;
        Salary = salary;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"\tFull name: {FullName}\nBirth date: {BirthDate}\nGender: {(IsMale ? "Male" : "Female")}" +
            $"\nCompany name: {CompanyName}\nPost: {Post}\nShedule: {Schedule}\nSalary: {Salary}$");
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person("Alex", new DateTime(1993, 05, 13), true);
        person.ShowInfo();

        Student student = new Student("Sara", new DateTime(2001, 01, 16), false, "University of Cambridge", "Britain scientist");
        student.ShowInfo();

        Employee employee = new Employee("Victor", new DateTime(1974, 01, 16), true, "Gruzovichkoff", "Loader", "6/1", 470);
        employee.ShowInfo();

        Person[] arr = { person, student, employee };

        foreach (var human in arr)
        {
            human.ShowInfo();
        }
    }
}