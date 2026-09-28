using System;
using System.ComponentModel.Design;
using System.Reflection.PortableExecutable;

namespace Lab06
{/*
* Student ID :1690704851
* Name       :Lab06
* Section    :129D
* No.        :32
* Course     : GI113 Computer Programming (GI)
*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int liver = 1;

            if (liver == 0)
            {
                //ในปีกกาเป็นโค้ดการทำงาน เมื่อรันได้ true
                Console.WriteLine("Game over");

                Console.WriteLine("Game is Playing");

                //โค้ดบันทัดต่อไปจะทำงาน จะรันได้เมื่อ true 
                Console.WriteLine("Continue Code");


                int level = 7;
                if (level >= 5)
                {
                    Console.WriteLine("The door open");
                }
                else
                {
                    Console.WriteLine("The door stays shut");
                }
                else if (level >= 10)
                {
                    Console.WriteLine("Boos floor unlocked");
                }
                else
                {
                    Console.WriteLine("the door stay shut");
                }
                bool isPoisoned = true;

                if (isPoisoned == true)
                {
                    Console.WriteLine("you died");
                }
                else if (isPoisoned == false)
                {
                    Console.WriteLine("you liver");
                }
                Console.WriteLine("Your level (1-99):");
                bool ok = int.TryParse(Console.ReadLine(), out level);

                if (!ok || level < 1 || level > 99) ;
                {
                    Console.WriteLine("Invalid level.");
                }
                else if (level >= 10)
                {
                    Console.WriteLine("Boos floor unlocked");
                }
                else if (level >= 5)
                {
                    Console.WriteLine("the door open");
                }
                else
                {
                    Console.WriteLine("The door stays shut");
                }
            }






        }
    }
}