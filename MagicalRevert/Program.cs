using System;
using MyClasses;//StringSpecialReverseClass;

class Program
{
    static void Main()
    {
        Console.WriteLine("Даний рядок буде розбито на слова, розділені пробілами, і в кожному слові порядок літер буде зміннено на зворотній. Символи ігноруються." +
"Введіть рядок:");
        string input = Console.ReadLine();
        string reversedString = MyClasses.StringSpecialReverse.Reverse(input);
        Console.WriteLine("Змінений мною рядок: " + reversedString);

    }


}
