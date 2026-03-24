using System;
class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Podaj licze a:");
        float a = float.Parse(Console.ReadLine());

        Console.WriteLine("Podaj licze b:");
        float b = float.Parse(Console.ReadLine());

        Console.WriteLine("Podaj operacje:");
        Console.WriteLine("1 dla dodawania");
        Console.WriteLine("2 dla odejmowania");
        Console.WriteLine("3 dla mnożenia");
        Console.WriteLine("4 dla dzielenia");

        string operation = Console.ReadLine();
        if (operation == "1")
        {
            Console.WriteLine("Wynik:");
            Console.WriteLine(a+b);
        }

        else if (operation == "2")
        {
            Console.WriteLine("Wynik:");
            Console.WriteLine(a - b);
        }

        else if (operation == "3")
        {
            Console.WriteLine("Wynik:");
            Console.WriteLine(a * b);
        }

        else if (operation == "4")
        {
            if(b!=0)
            {
                Console.WriteLine("Wynik:");
                Console.WriteLine(a / b);
            }
            else
            { Console.WriteLine("Nie dziel przez 0"); }    
            
        }

    }
}