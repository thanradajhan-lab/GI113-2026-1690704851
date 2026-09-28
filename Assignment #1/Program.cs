/*
 * Student ID :1690704851
 * Name       :Lab
 * Section    :129D
 * No.        :32
 * Course     : GI113 Computer Programming (GI)
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const String GameTitle = "welcome to hell"; 

            var characterName = "Wooi";
            var characterRank = 'S';

            int characterLevel = 67;
            float attackPower = 245.9f;
            int healthPoint = 850;
            bool isAlive = true;
          
            Console.WriteLine($"-------{GameTitle}---------");
            Console.WriteLine($"Character Name: {characterName}");
            Console.WriteLine($"Character Rank: {characterRank}");
            Console.WriteLine($"Character Level: {characterLevel}");
            Console.WriteLine($"Character Attack Power: {attackPower}");
            Console.WriteLine($"Character Health Point: {healthPoint}");
            Console.WriteLine($"Character is Alive: {isAlive}");
            Console.WriteLine();

            double levelAsDouble = characterLevel;

            Console.WriteLine("-------Type Casting---------");
            Console.WriteLine($"Character Level as Double: {levelAsDouble}");

            int attackAsInt = (int)attackPower;
            int attackRounded = Convert.ToInt32(attackPower);

            Console.WriteLine($"Attack Power as Int: {attackAsInt}");
            Console.WriteLine($"Attack Power Convert: {attackRounded}");

        







        }
    }
}
