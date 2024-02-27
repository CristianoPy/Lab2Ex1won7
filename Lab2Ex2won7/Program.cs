/*Ex 2: Scrieti un program care va determina daca un numar negativ citit de
la tastatura este divizibil cu 2 si nu este divizibil cu 6*/

Console.WriteLine("Introduceti un numar: ");
int num = Convert.ToInt32(Console.ReadLine());

while (num % 2 == 0 && num % 6 != 0)
{
    Console.WriteLine("Numarul negativ este divizibil cu 2 si nu este divizibil cu 6.");
    break;
}

Console.ReadLine();