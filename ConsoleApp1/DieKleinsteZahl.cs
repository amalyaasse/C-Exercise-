// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;
// es sollen drei zahlen eingegeben werden
// daraus soll die kleinste Zahl ermittelt werden

int X = Convert.ToInt32(Console.ReadLine());
int Y = Convert.ToInt32(Console.ReadLine());
int Z = Convert.ToInt32(Console.ReadLine());

if (X < Y && X < Z)
    Console.WriteLine("Die kleinste zahl ist: " + X);
else if (Y < X && Y < Z)
    Console.WriteLine("Die kleinste zahl ist: " + Y);
else if (Z < X && Z < Y)
    Console.WriteLine("Die kleinste zahl ist: "+Z);

