using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foo
{
    class Program
    {
        static void Main(string[] args)
        {
            PasswordGenerator.RandomPasswordGenerator rpg = new PasswordGenerator.RandomPasswordGenerator();
       string pss=   rpg.GeneratePassword(true, true, true, true, 10);
            Console.WriteLine("Your PassWord Here : " + pss);
            Console.ReadKey();
        }
    }
}
//I 've previously talked about hashing a password for IdentitySever4 in C#. This works well when you want to store your password with added salt to a database or similar store that could be read.

//In this previous article I talked about how this could be added to code that was bulk transferring users from one, older, user table to the new AspNetUsers in IdentityServer4.I also mentioned that when doing this you could also create a Random Password Generator to create initial passwords for those users.

//In this article I am going to list a code example that does just this. It allows you to specify inputs to increase the character set to choose from. It also allows you to specify a size you would like that password to be (I would suggest at least 10 characters for security).

//There are improvements you could make to this code: for example adding spaces, and making sure there are no more than 1 or 2 character that are consecutive(although in my tests is mostly random for each character in password).You could also add some validation to the password - something I may add examples for.

//The random password generator C# code example
//Let us start with the C# code example

//First, lets define the random password generation code 

//using System;

namespace PasswordGenerator
{
     class RandomPasswordGenerator
    {

        const string LOWER_CASE = "abcdefghijklmnopqursuvwxyz";
        const string UPPER_CAES = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string NUMBERS = "123456789";
        const string SPECIALS = @"!@£$%^&*()#€";


        public string GeneratePassword(bool useLowercase, bool useUppercase, bool useNumbers, bool useSpecial,
            int passwordSize)
        {
            char[] _password = new char[passwordSize];
            string charSet = ""; // Initialise to blank
            System.Random _random = new Random();
            int counter;

            // Build up the character set to choose from
            if (useLowercase) charSet += LOWER_CASE;

            if (useUppercase) charSet += UPPER_CAES;

            if (useNumbers) charSet += NUMBERS;

            if (useSpecial) charSet += SPECIALS;

            for (counter = 0; counter < passwordSize; counter++)
            {
                _password[counter] = charSet[_random.Next(charSet.Length - 1)];
            }

            return String.Join(null, _password);
        }
    }
}