// Array de strings
string[] cars = { "Kia", "Mercedes", "Nissan", "Renault" };

// Array de enteros
int[] numeros = { 13, 2, 32, 4, 533 };


// Acceder a los elementos
Console.WriteLine(cars[0]);

// cambiar un elemento

Console.WriteLine("Antes: " + cars[1]);
cars[1] = "Ferrari";
Console.WriteLine("Nuevo: " + cars[1]);

// Longitud
Console.WriteLine(cars.Length);

// Recorer arrays
for (int i = 0; i < cars.Length; i++)
{
    Console.WriteLine( i+1 + " " + cars[i]);
}

foreach(string y in cars)
{
    Console.WriteLine(y);
}

// Ordenar

Array.Sort(numeros);

foreach (int x in numeros)
{
    Console.WriteLine(x);
}

// Tambien se pueden obtener los max, min y la suma

Console.WriteLine("Maximo " + numeros.Max());
Console.WriteLine("Minimo " + numeros.Min());
Console.WriteLine("Suma " + numeros.Sum());


// Arrays multidimencionales

int[,] num = { {1,2,3} , {1,2,3} };

Console.WriteLine("\nArrays multidimencionales");
Console.WriteLine(num[0, 2]);

// Ciclo foreach

foreach(int t in num)
{
    Console.Write(t);
}

// for , se necesita uno para cada dimension
for(int g = 0; g< num.GetLength(0); g++) {  // getleng(dimension de la que se quiere) 
    for (int a = 0; a < num.GetLength(1); a++)
    {
        Console.Write(num[g, a]+ " ");
    }
}

