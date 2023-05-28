using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reiz_tech
{
    class clock_Angle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the time in 12 hour format like hours:minute (07:54) \n");
            string time;
            time=Console.ReadLine();
            //now we have time in time string
            //i wil seperate the hour and minute in different strings

            string hour=time.Substring(0,2);
            string minute = time.Substring(time.Length - 2) ;



         //   Console.WriteLine("hour is "+ hour+" minute is "+ minute);

            //convert the two string to integer 
            int hrs = int.Parse(hour);
            int mint = int.Parse(minute);


         //   Console.WriteLine("integer hour is " + hrs+ " minute is " + mint);
            //each minute is of 6 degree 
            //each hour is of 30 degree 
            //whoel clock is of 360 degree 

            //calculating the smallest angel 
            int angel1 = hrs * 30;
            int angel2 = mint * 6;
            int result=0;

            if (angel1 > angel2)
            {
                result = angel1 - angel2;


            }
            else
            {
                result = angel2 - angel1;
            }
            Console.WriteLine("the smallest angel between "+hour+" hours and "+minute+" is "+result+" degree \n");

            Console.WriteLine("press any key to exit the program.....");



            Console.ReadLine();
        }
    }
}
