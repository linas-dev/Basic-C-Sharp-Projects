using System;
using System.Net.Mime;

namespace priceQuoteApplicationAssignment
{
    internal class Program
    {
        public static void Main(string[] args)
        {
           Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
           Console.WriteLine("");

           Console.WriteLine("Please enter Package Weight? ");
           string packageWeight = Console.ReadLine();
           int convPackageWeight = Convert.ToInt16(packageWeight);
           
           if (convPackageWeight > 50)
           {
               Console.WriteLine("Your package weight is: " + convPackageWeight + " kg");
               Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
               System.Environment.Exit(1);
           }

           Console.WriteLine("Please enter the package width:");
           string packageWidth = Console.ReadLine();
           int convPackageWidth = Convert.ToInt16(packageWidth);
           
           Console.WriteLine("Please enter the package height:");
           string packageHeight = Console.ReadLine();
           int convPackageHeight = Convert.ToInt16(packageHeight);
           
           Console.WriteLine("Please enter the package length:");
           string packageLenght = Console.ReadLine();
           int convPackageLenght = Convert.ToInt16(packageLenght);
           

           int totalPackageDimensions = convPackageWidth + convPackageHeight + convPackageLenght;

           if (totalPackageDimensions > 50)
           {
               Console.WriteLine("Your package dimensions are: " + totalPackageDimensions);
               Console.WriteLine("Package too big to be shipped via Package Express");
               System.Environment.Exit(1);
           }
           
           int productByTheWeight = convPackageWeight;

           int multipliedDimensions = (convPackageHeight * convPackageWidth * convPackageLenght) * productByTheWeight;

           int estimatedPrice = (int)multipliedDimensions / 100;

           Console.WriteLine("Your estimated total for shipping this package is: " + "£" + String.Format("{0:0.00}", estimatedPrice));
           Console.WriteLine("Thank you.");
        }
    }
}