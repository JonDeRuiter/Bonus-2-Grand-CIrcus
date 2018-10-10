using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_2_Grand_Circus
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            DateTime birthday, today, newBirthday, daysYear;
            int ageYears, ageDays, x;
            double totDays;

            TimeSpan time, time2;

            Console.WriteLine("Hi! What's your birthday? mm/dd/yyyy");
            input = Console.ReadLine();
            birthday = Convert.ToDateTime(input);
            today = System.DateTime.Today;
            totDays = (today - birthday).TotalDays;

                       
            //Gets the users coming birthday
            input = Convert.ToString(today.Year + "/" + birthday.Month + "/" + birthday.Day);
            newBirthday = Convert.ToDateTime(input);
            
            //Uses that brithday to find the difference in years and days
            ageYears = newBirthday.Year - birthday.Year;
            time = (newBirthday - today);
            time2 = newBirthday - newBirthday;

            input = Convert.ToString(time);
            Console.WriteLine(input);

            TimeSpan.Compare(time, time2);

            if ()
            {

            }

            /*x = int.Parse(input);
            if (x > 0)
            {
                ageYears--;
            }*/
            daysYear = Convert.ToDateTime(input = (today.Day + "/" + today.Month + "/" + (today.Year - 1)));
            

            Console.WriteLine(time + " " + ageYears);

            /*
            if (ageDays > 1)
            {
                Console.WriteLine("You are {0} years and {1} days old.", ageYears, ageDays);
            }
            else if (ageDays == 1)
            {
                Console.WriteLine("You are {0} years and {1} day old.", ageYears, ageDays);
            }
            else
            {
                Console.WriteLine("Happy Birthday!");
                Console.WriteLine("You are {0} years old.", ageYears, ageDays);
            }
            */
            Console.ReadLine();
        }
    }
}
