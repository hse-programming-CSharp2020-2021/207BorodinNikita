using System;
using System.Globalization;

namespace Task_1
{
    class Birthday
    {
        string name;
        int day, month, year;

        public Birthday(string name)
        {
            this.name = name;

            day = 01;
            month = 01;
            year = 1970;
        }

        public Birthday(string name, int day, int month, int year)
        {
            this.name = name;

            this.day = day;
            this.month = month;
            this.year = year;
        }

        DateTime Date
        {
            get
            {
                return new DateTime(year, month, day);
            }
        }

        public string Info
        {
            get
            {
                return $"{name}, дата рождения - {Date.Day}:{Date.Month}:{Date.Year}";
            }
        }

        public string InfoFormat1
        {
            get
            {
                return $"{name}, дата рождения - {Date.Day}-{Date.Month}-{Date.Year % 100}";
            }
        }

        public string InfoFormat2
        {
            get
            {
                string month = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(Date.Month);

                return $"{name}, дата рождения - {Date.Day} {month} {Date.Year}";
            }
        }

        public int HowManyDays
        {
            get
            {
                int today = DateTime.Now.DayOfYear;
                int birthday = Date.DayOfYear;

                return today <= birthday ? birthday - today : 365 + birthday - today;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Birthday date = new Birthday("Владимир Ильич Ленин", 22, 04, 1870);

            Console.WriteLine(date.Info);

            Console.WriteLine(date.InfoFormat1);

            Console.WriteLine(date.InfoFormat2);

            Console.WriteLine($"Будь он жив, его день рождения наступил бы через {date.HowManyDays} дней");
        }
    }
}
