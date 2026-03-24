using System;
class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbe ocen:");
        float grades = float.Parse(Console.ReadLine());
        float avg=0;

        for (int i = 0; i < grades; i++)
        {
            Console.WriteLine("Podaj ocene:");
            avg = avg + float.Parse(Console.ReadLine());
        }

        avg = avg / grades;
        Console.WriteLine("Srednia ocen:");
        Console.WriteLine(avg);
        if(avg<3)
        {
            Console.WriteLine("Nie zdales");
        }
        else if (avg>3)
        {
            Console.WriteLine("Zdales");
        }    

    }
}