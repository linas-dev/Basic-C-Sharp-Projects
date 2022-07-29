using System;
using System.Xml;

namespace dailyReport
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Pitman Training");
            Console.WriteLine("");
            
            Console.WriteLine("Questions: ");
            Console.WriteLine("");
            
            Console.WriteLine("Question 1: \n What course are you in?");
            string course = Console.ReadLine();
            
            
            Console.WriteLine("Question2: \n What page number?");
            string pageNumber = Console.ReadLine();
            byte convertedPageNumber = Convert.ToByte(pageNumber);
            
            
            Console.WriteLine("Question 3: \n Do you need any help with anything? Please answer “true” or “false”");
            string answer = Console.ReadLine();
            bool answerConvertedToBool = Convert.ToBoolean(answer);

            Console.WriteLine("Question 4: \n Were there any positive experiences you’d like to share?  Please provide specifics.");
            string experiences = Console.ReadLine();

            
            Console.WriteLine("Question 5: \n Is there any other feedback you’d like to provide?  Please be specific.");
            string  feedback = Console.ReadLine();

            
            Console.WriteLine("Question 6: \n How many hours did you study today?");
            string hoursSpentStudyingToday = Console.ReadLine();
            decimal convertedHours = Convert.ToDecimal(hoursSpentStudyingToday);
            
            Console.WriteLine("Answers: ");
            Console.WriteLine("");
            
            Console.WriteLine("Answer 1: \n I am in " + course + " course");
            Console.WriteLine("Answer 2: \n Page number is " + convertedPageNumber);
            Console.WriteLine("Answer 3: \n " + answerConvertedToBool);
            Console.WriteLine("Answer 4: \n " + experiences);
            Console.WriteLine("Answer 5: \n " + feedback);
            Console.WriteLine("Answer 6: \n I have spent " + hoursSpentStudyingToday + " hours studying today.");

            Console.WriteLine();
            Console.WriteLine("Thank you for your responses.  An Instructor will respond shortly.  Have a great day!");
        }
    }
}