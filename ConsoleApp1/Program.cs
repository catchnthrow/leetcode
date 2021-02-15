using System;
using leetcode.Problems;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //RobotBoundedInCircle.Start();
            //SumOfOddLengthSubArray.Start();
            PhoneNumberContacts obj = new PhoneNumberContacts();
            string[] A = {"zzzas", "tasdf", "tas", "adam", "eva", "leo"};
            string[] B = {"56545","12345678", "123456789", "123", "1234", "123456"};
            Console.WriteLine(obj.solution("12345678"));
        }
    }
}
