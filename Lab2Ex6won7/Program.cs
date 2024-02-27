/*Ex 6: Scrieti un program care va determina daca un numar este sau nu
palindrom.*/


Console.WriteLine("Introduceti un numar: ");
int num = Convert.ToInt32(Console.ReadLine());

int r;
int sum = 0;
int temp = num;

while (num > 0)
{
    r = num % 10;
    sum = (sum * 10) + r;
    num /=  10;
}
if(temp == sum)
{
    Console.WriteLine("Numarul este palindrom.");
}
else
{
    Console.WriteLine("Numarul nu este palindrom.");
}

Console.ReadLine();