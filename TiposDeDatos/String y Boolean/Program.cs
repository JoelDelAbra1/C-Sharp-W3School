// See https://aka.ms/new-console-template for more information
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;

string txt = "123456";

Console.WriteLine("La longitud de: " + txt + " es: " + txt.Length);

string txt2 = "Hola como estan JAJAJA";
Console.WriteLine(txt2.ToUpper());
Console.WriteLine(txt2.ToLower());

// Concatenar

string name = "Joel ";
string lastName = "Del Abra";
string fullName = name + lastName;

Console.WriteLine("Tu nombre es: " + fullName);

// Metodo concat

string fullName2 = String.Concat(name, lastName);
Console.WriteLine("Usando metodo concat: " + fullName2);

// Interpolacion

string nameInter = $"Este es usando interpolacion {name} {lastName}";

Console.WriteLine(nameInter);

Console.WriteLine("\n\n");

// String access
Console.WriteLine("String Access");

string palabra = "Hello";
Console.WriteLine(palabra[0]);

Console.WriteLine(palabra.IndexOf('e'));

// substring , crea un nuevo string
int indexLast = fullName.IndexOf("D");
string apellido = fullName.Substring(indexLast);
Console.WriteLine("Apellido: " + apellido);