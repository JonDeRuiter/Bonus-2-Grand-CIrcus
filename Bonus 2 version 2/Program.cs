using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_2_version_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime birthday, today, daySBirthday;
            int years;
            TimeSpan days;

            //Getting the dates
            Console.WriteLine("Hi, What's your Birthday?");
            birthday = Convert.ToDateTime(Console.ReadLine());
            today = DateTime.Now;

            //Getting the interveigning years
            if (today.Month - birthday.Month <= -1)
            {
                years = (today.Year - birthday.Year) - 1;
            }
            else
            {
                years = today.Year - birthday.Year;
            }

            //Getting the days since users last birthday
            daySBirthday = Convert.ToDateTime("" + birthday.Month + "/" + birthday.Day + "/" + (today.Year -1));
            days = today.Subtract(daySBirthday);

            //Final message
            Console.WriteLine("You are {0} years and {1} days old.", years, days.TotalDays);
            if (today.Month == birthday.Month && today.Day == birthday.Day)
            {
                Console.WriteLine("Happy Birthday!");
            }
            Console.ReadLine();

        }
    }
}
