using System.Numerics;
using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace firstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question 1
            //Create a Book class with a Title (string) and Pages (int).
            //Create a Book object and store it in a variable of type object.
            //Print it.

            object book = new Book { Title =".Net" , Pages =100 };

            Console.WriteLine(book);
            #endregion

            #region question 2
            //Using the Book class above, print the result of calling ToString(),
            //Equals() (compare book with itself), GetHashCode(), and GetType() on book.



            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.GetType());
            #endregion

            #region question 3
            //Look at the line below.
            //Is it a compile-time error,
            //a runtime error, or a logical error? Fix it.
            //int pages = "464";
            //Compile - time error —
            //you can't put text (string) into an int variable.
            //int pages = 464;
            #endregion

            #region question 4
            //Write code that divides 10 by 0 inside a try block,
            //catches the exception, prints "Cannot divide by zero",
            //and then prints "Done" in a finally block.
            try
            {
                int x = 10;
                int y = 0;
                int z = x / y;
                Console.WriteLine(z);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Done");
            }
            #endregion

            #region question 5
            //Declare an int pages = 300;
            //then store it in a double variable without using a cast.
            int pages = 300;
            double PagesInDouble = pages;
            Console.WriteLine(PagesInDouble);
            #endregion

            #region question 6
            //Declare a double price = 49.99;
            //then convert it into an int using a cast.
            double price = 49.99;
            int priceInInt = (int)price;
            Console.WriteLine(priceInInt);

            #endregion

            #region question 7
            //Given string pagesText = "464";,
            //convert it into an int using the Convert class.

            string pagesText = "464";
            int pagesInInt =Convert.ToInt32(pagesText);
            Console.WriteLine(pagesInInt);
            #endregion

            #region question 8
            //Given string yearText = "2023";
            //, convert it using int.Parse().
            //Then given string badText = "abc";
            //, use int.TryParse() to safely try converting it,
            //and print "Invalid number" if it fails.
            string yearText = "2023";
            int yearInInt = int.Parse(yearText);
            Console.WriteLine(yearInInt);

            string badText = "abc";
            bool result = int.TryParse(badText, out int number);
            if (result)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("invalid number");
            }
            #endregion

            #region question 9
            //Given int pages = 464;,
            //convert it into a string using ToString()
            //and print its type using GetType()
            //to prove it's now a string.

            int Pages = 464;
            string pagesInString = Pages.ToString();
            Console.WriteLine(pagesInString.GetType());
            #endregion

            #region question 10
            //Declare int copies = 100;.
            //Box it into an object variable,
            //then unbox it back into a new int variable,
            //and print both.

            int copies = 100;
            object obj = copies;
            int copiesInInt = (int)obj;
            Console.WriteLine(copies);
            Console.WriteLine(copiesInInt);
            #endregion


        }
    }
}
