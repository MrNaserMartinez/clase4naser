﻿using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Hola, este es mi programa");

Console.WriteLine("ENUNCIADO #1 /n");
Console.WriteLine("primeros numeros pares hasta el 10 /n");
int x = 2;
while (x <= 10)
{
    Console.WriteLine(x);
    x+=2;
}

Console.WriteLine("suma de los primeros numeros naturales /n");
int resultado = 0; 
for (int i = 1; i <= 10; i++) 
{
    resultado += i;
}
Console.WriteLine($"La suma es: {resultado}");

Console.WriteLine("ENUNCIADO #2 /n");
Console.WriteLine("HASTA ENCONTRAR EL NEGATIVO Y SU SUMA/n");
int suma = 0; int numero;
do
{
    Console.Write("Ingrese un número: "); numero = Convert.ToInt32(Console.ReadLine());
    if (numero >= 0)
    {
        suma += numero;
    }
} while (numero >= 0);
Console.WriteLine($"La suma de los números ingresados es: {suma}");


int n = 1;
while (true)
{
    if (n % 7 == 0 && n % 11 == 0)
    {
        Console.WriteLine($"El primer número entero positivo divisible entre 7 y 11 es: {n}");
        break;
    }
    n++;
}

Console.WriteLine("ENUNCIADO #3 /n");
Console.WriteLine("En busca de la contrasenia");
string contra = "jutiapa";
string ingresoUsuario;

do
{
    Console.WriteLine("Ingrese la contra");
    ingresoUsuario = Console.ReadLine();
}while(ingresoUsuario != contra );
Console.WriteLine("CONTRA CORRECTA");

Console.WriteLine("EL RANDOM");
Random rnd = new Random();
int numeroAleatorio = rnd.Next(1, 101);
int intento;

Console.WriteLine("¡Adivina el número entre 1 y 100!");

do
{
    Console.Write("Introduce tu intento: ");
    intento = int.Parse(Console.ReadLine());

    if (intento < numeroAleatorio)
    {
        Console.WriteLine("El número es mayor.");
    }
    else if (intento > numeroAleatorio)
    {
        Console.WriteLine("El número es menor.");
    }
} while (intento != numeroAleatorio);

Console.WriteLine("¡Felicidades! ¡Has adivinado el número " + numeroAleatorio + "!"); //Este es el 2do del tercer enunciado
