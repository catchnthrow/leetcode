using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace leetcode.Problems
{
    public class PhoneNumberContacts
    {
        public string solution1(string[] A, string[] B, string P)
        {
            var contacts = new List<string>();
            for (var i = 0; i < B.Length; i++)
            {
                if (B[i].Contains(P))
                {
                    contacts.Add(A[i]);
                }
            }

            if (contacts.Count <= 0) 
                return "NO CONTACT";

            contacts.Sort();
            return contacts[0];

        }

        public string solution2(string S)
        {
            var temp = new StringBuilder(string.Empty);
            
            foreach (var c in S)
            {
                if (!c.Equals(' ') && !c.Equals('-'))
                {
                    temp.Append(c);
                }
            }

            if (temp.Length < 4)
            {
                return temp.ToString();
            }

            if (temp.Length == 4)
            {
                return string.Format("{0}{1}-{2}{3}", temp[0], temp[1], temp[2], temp[3]);
            }

            var lastCharLen = 0;
            if (temp.Length % 3 == 1)
            {
                lastCharLen = 4;
            }

            if (temp.Length % 3 == 2)
            {
                lastCharLen = 2;
            }

            
            var output = new StringBuilder(string.Empty);
            output.Append(temp[0]).Append(temp[1]).Append(temp[2]);

            for (var i = 3; i < temp.Length - lastCharLen; i++)
            {
                if (i % 3 == 0)
                {
                    output.Append('-');
                }
                output.Append(temp[i]);
            }
            output.Append('-');

            if (lastCharLen == 4)
            {
                output.Append(temp[temp.Length - 4])
                    .Append(temp[temp.Length - 3])
                    .Append('-')
                    .Append(temp[temp.Length - 2])
                    .Append(temp[temp.Length - 1]);

            }
            else if (lastCharLen == 2)
            {
                output.Append(temp[temp.Length - 2])
                    .Append(temp[temp.Length - 1]);
            }

            return output.ToString().TrimEnd('-');
        }

        public int solution(int Y, string A, string B, string W)
        {

            var isLeapYear = Y % 4 == 0;
            string[] day = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
            var month = new Dictionary<string, int>();
            month.Add("January",   0);
            month.Add("February",  31);
            month.Add("March",     31 + (isLeapYear ? 29 : 28));
            month.Add("April",     31 + (isLeapYear ? 29 : 28) + 31);
            month.Add("May",       31 + (isLeapYear ? 29 : 28) + 31 + 30);
            month.Add("June",      31 + (isLeapYear ? 29 : 28) + 31 + 30 + 31);
            month.Add("July",      31 + (isLeapYear ? 29 : 28) + 31 + 30 + 31 + 30);
            month.Add("August",    31 + (isLeapYear ? 29 : 28) + 31 + 30 + 31 + 30 + 31);
            month.Add("September", 31 + (isLeapYear ? 29 : 28) + 31 + 30 + 31 + 30 + 31 + 31);
            month.Add("October",   31 + (isLeapYear ? 29 : 28) + 31 + 30 + 31 + 30 + 31 + 31 + 30);
            month.Add("November",  31 + (isLeapYear ? 29 : 28) + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31);
            month.Add("December",  31 + (isLeapYear ? 29 : 28) + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31 + 30);

            //The idea is to find total number of days for the start of the month, and then perform a modulo operation by 7
            // to find the day of the week it is and then find the next nearest Sunday
            //Same way do it for the Vacation end month and get the last Sunday of the month.
            
            // Now you have starting day and end day , divide by seven and find the number of weeks.

            return 0;
        }

    }
}
