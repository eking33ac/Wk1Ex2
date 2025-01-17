using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk1Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INFORMATION INPUT");     // Output "INFORMATION INPUT" on it's own line
            Console.Write("What is your first name? ");     // Ask a question without automatically having an line break after the question
            string firstName = Console.ReadLine();      // Allow user to input answer to previous question. Keep their first name in a string variable. Insert linebreak after answer.
            Console.Write("What is your last name? ");       // Ask a question without automatically having an line break after the question
            string lastName = Console.ReadLine();       // Allow user to input answer to previous question. Keep their last name in a string variable. Insert linebreak after answer.
            Console.Write("What is your age? ");     // Ask a question without automatically having an line break after the question
            string age = Console.ReadLine();        // Allow user to input answer to previous question. Keep their age in a string variable. Insert linebreak after answer.
            Console.Write("What is your favorite color? ");      // Ask a question without automatically having an line break after the question
            string favoriteColor = Console.ReadLine();          // Allow user to input answer to previous question. Keep their ffavorite color in a string variable. Insert linebreak after answer.

            // Output a simple sentence from user input saved in variables concatenated to strings of text. There has got to be a more efficient way to do the spaces.
            Console.WriteLine("Hello, " + firstName + " " + lastName + "! You are " + age + " years old and your favorite color is " + favoriteColor + ".");
        }
    }
}
