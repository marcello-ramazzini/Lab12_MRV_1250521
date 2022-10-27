// See https://aka.ms/new-console-template for more information

using System.Reflection;

int[] nota = new int[15];
int suma = 0;
int media = 0;

Console.WriteLine("LABORATORIO 12_ 1250521");

Console.WriteLine("Por favor, ingrese 15 notas pare realizar una media");
for (int i=0; i<15; i++)
{
    Console.WriteLine();
    Console.WriteLine("Por favor, ingresa una nota");
    nota[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < 15; i++)
{
    suma = suma + nota[i];
    media = suma / 15;
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("la media de las 15 notas es de: " + media);

