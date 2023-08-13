// See https://aka.ms/new-console-template for more information


/* Tipos de variable:
 * Int
 * Double
 * char  (Solo uno) ""
 * string ""
 * bool
 

 * Declarar variables
 * type  nameVariable = value; */

string name = "Joel";
Console.WriteLine("Hello" + name);

int myNum = 25;
Console.WriteLine(myNum);

const double Pi = 3.14;
Console.WriteLine( "Soy una constante: " + Pi);

int x = 10,y = 20,z = 30 ;
Console.WriteLine(x+y+z);

// Type Casting 

/* automatico: char -> int -> long -> float -> double
   manual: double -> float -> long -> int -> char */

int myInt = 9;
double myDouble = myInt;

Console.WriteLine(myInt);
Console.WriteLine(myDouble);

// Manual

double myDouble2 = 9.564;
int myint2 = (int) myDouble;
Console.WriteLine(myDouble2);
Console.WriteLine(myint2);

