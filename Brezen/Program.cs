Console.WriteLine("Zdejte 1. číslo");
int cislo1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Zadejte 2. číslo");
int cislo2 = Convert.ToInt32(Console.ReadLine());
if (cislo1 == cislo2)
{
    Console.WriteLine("Čísla se rovnají");
}
else if (cislo1 > cislo2)
{
    Console.WriteLine(cislo1);
    Console.WriteLine(cislo2);
}
else if (cislo1 < cislo2)
{
    Console.WriteLine(cislo2);
    Console.WriteLine(cislo1);
}
//supr kool !