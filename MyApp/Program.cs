using System;

namespace MyApp{
    internal class program{
        static void Main(string[] args){
            var LeapYearFunc = new LeapYear();
            var StringConverter = new StringToIntConverter();

            var LeapYearString = Console.ReadLine();

            int LeapYear = StringConverter.Convert(LeapYearString);

            if(LeapYear == -1) {Console.WriteLine("Cannot parse input"); return;}

            if(LeapYearFunc.IsLeapYear(LeapYear)){
                Console.WriteLine("yay");
            } else
            {
                Console.WriteLine("nay");
            }
        }
    }
    public class StringToIntConverter{
        public int Convert(string? intString){
            int result;
            bool isConverted = Int32.TryParse(intString,out result);
            if(!isConverted) return -1;
            return result;
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