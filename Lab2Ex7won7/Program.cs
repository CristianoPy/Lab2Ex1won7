﻿/*Ex 7 (pentru cei care nu l-au rezolvat cu “if”): Se citesc trei numere de la
tastatura, x,y,z. Scrieti un program care va afisa cele trei valori in ordine
descrescatoare.
• Exemplu: citim 3 9 0 Afisam : 9 3 0*/


Console.WriteLine("Introduceti primul numar: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduceti al doilea numar: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduceti al treilea numar: ");
int z = Convert.ToInt32(Console.ReadLine());

if (x < y)
{
    if (y < z)
    {
        Console.WriteLine($"{z}, {y},{x}");
    }
    else if (x < z)
    {
        Console.WriteLine($"{y}, {z},{x}");
    }
    else
    {
        Console.WriteLine($"{y}, {x}, {z}");
    }
}
else if (y < z)
{
    if (z < x) 
    {
        Console.WriteLine($"{z}, {x}, {y}");
    }
    else
    {
        Console.WriteLine($"{x}, {z}, {y}");
    }
}
else
{
    Console.WriteLine($"{x}, {y}, {z}");
}
Console.ReadKey();