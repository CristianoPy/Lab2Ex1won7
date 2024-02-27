/*Ex 4: Scrieti un program care va afisa factorialul unui numar n, n fiind citit
de la tastatura.*/


Console.WriteLine("Introduceti un numar: "); 
int num = Convert.ToInt32(Console.ReadLine());

int fac = 1;

for (int i = 1; i <= num; i++)
{
    fac *= i;
}

Console.WriteLine("Factorial de " + num + " este: " +  fac);
Console.ReadLine();
