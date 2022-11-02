using System;

namespace WhileExcercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchBook = Console.ReadLine();
            int booksCnt = 0;
            bool isFound = false;

            string bookName;
            while((bookName=Console.ReadLine()) !="No More Books")
            {
                
                if(bookName == searchBook)
                {
                    isFound = true;
                    break;
                }
                booksCnt++;
            }
            if(isFound)
            {
                Console.WriteLine($"You checked {booksCnt} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {booksCnt} books.");

            }

        }
    }
}

