// See https://aka.ms/new-console-template for more information

using System.Diagnostics.Tracing;
using System.Xml.Linq;

int x = 200, y = 200;

if(x > y)
{
    Console.WriteLine(x + " es mas grande que " + y);
}
else if(x == y ){
    Console.WriteLine(x + " es igual que " + y);
}
else
{
    Console.WriteLine(y + " es mas grande que " + x);
}

Console.WriteLine(" \nMini if");

string miniif = (10 > 12) ? "Hola" : "Adios";

Console.WriteLine(miniif);


Console.WriteLine("\nSwitch case");

Console.WriteLine("Ingrese un numero de dia");

string dia = "1"; //Console.ReadLine();

switch (dia)
{
    case ("1"):
        Console.WriteLine("Lunes");
        break;
    default :
        Console.WriteLine("Au no estoy paara eso");
        break;
}


Console.WriteLine("\nWhile Loop");

int i = 0;
while(i <= 10)
{
    Console.WriteLine("5 * " + i + " = " + i * 5);
    i++;
}

Console.WriteLine("\nDo While Loop (Lo hace una vez sin verificar si es verdad)");

int f = 5;

do
{
    Console.WriteLine(f);
    f--;
} while (f>=0);


Console.WriteLine("\n For Loop");

for (int h = 0; h<=10; h++) {
    Console.WriteLine(h);
}

