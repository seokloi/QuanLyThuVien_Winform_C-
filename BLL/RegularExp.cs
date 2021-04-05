using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{
    public class RegularExp
    {
        public bool Is_WhiteSpaceAndLetters_Only(string input)
        {
            Regex reg = new Regex(@"^[a - zA - Z0 - 9_.-] *$");

            return reg.IsMatch(input);
        }

        public bool Is_Numbers_Only(string input)
        {
            Regex reg = new Regex(@"^[0-9]+$");

            return reg.IsMatch(input);
        }

        public bool Is_UsernameOrPassword_Valid(string input)
        {
            Regex reg = new Regex(@"^(?=[a - zA - Z0 - 9._]{ 1,20}$)(? !.*[_.]{ 2})[^_.].*[^_.]$");

            return reg.IsMatch(input);
        }

        public bool Is_Email_Valid(string input)
        {

            Regex reg = new Regex(@"^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$");

            return reg.IsMatch(input);
        }

        public bool Is_Address_Valid(string input)
        {
            Regex reg = new Regex(@"(.*?)\s * (\d + (?:[/ -]\d +)?)?$");

            return reg.IsMatch(input);
        }

        public bool Is_NumberAndLetter_Only(string input)
        {
            Regex reg = new Regex(@"^[a-zA-Z0-9]+$");

            return reg.IsMatch(input);
        }

  
             
    }
}
