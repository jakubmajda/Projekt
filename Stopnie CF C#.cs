using System;
class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbe stopni:");
        float degrees = float.Parse(Console.ReadLine());

        Console.WriteLine("Wybierz skale w ktorej sa twoje stopnie:");
        Console.WriteLine("1 - Stopnie C");
        Console.WriteLine("2 - Stopnie F");
        int action = int.Parse(Console.ReadLine());
        if (action==1)
        {
            Console.WriteLine("Wartosc po konwersji na F:");
            Console.WriteLine(degrees * 1.8 + 32); 
        }
        else if (action==2)
        {
            Console.WriteLine("Wartosc po konwersji na C:");
            Console.WriteLine((degrees - 32) / 1.8);
        }


    }
}
