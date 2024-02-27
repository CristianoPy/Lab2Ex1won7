/*Ex 3: Scrieti un program care va afisa suma cifrelor unui numar n, n fiind
citit de la tastatura.*/


Console.WriteLine("Introduceti un numar: ");
int num = Convert.ToInt32(Console.ReadLine());

int sum = 0;

for (int i = num;  i > 0; i = i / 10)
{
    sum += i % 10;
}
Console.WriteLine("Suma cifrelor este: " + sum);
Console.ReadLine();