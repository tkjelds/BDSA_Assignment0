using System;

namespace MyApp{
    internal class program{
        static void Main(string[] args){
            var LeapYearFunc = new LeapYear();
            var LeapYearString = Console.ReadLine();
            int LeapYear = Int32.Parse(LeapYearString);
            if(LeapYearFunc.IsLeapYear(LeapYear)){
                Console.WriteLine("yay");
            } else
            {
                Console.WriteLine("nay");
            }
        }
    }
    public class LeapYear{
        public bool IsLeapYear(int year){
            if(year % 4 != 0) return false;
            if(year % 100 == 0 && year % 400 != 0) return false; 
            return true;
        }
    }
}