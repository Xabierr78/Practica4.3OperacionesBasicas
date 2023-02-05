using System;

Console.WriteLine("Escribe el primer numero por favor:");

int a = int.Parse(Console.ReadLine());

Console.WriteLine("Escribe el segundo numero por favor:");
int b = int.Parse(Console.ReadLine());

int suma = a + b;
int resta = a - b;
int multiplicacion = a * b;
int division = a / b; 
int residuo = a% b;



Console.WriteLine("PRIMER NUMERO: " + a + "\n" + "SEGUNDO NUMERO: " + b + "\n" + "La suma es: " + suma + "\n" + "La resta es: " + resta + "\n" + "La multiplicacion es: " + multiplicacion
    + "\n" + "La division es: " + division + "\n" + "La division es: " + division + "\n" + "El residuo es: " + residuo); 


