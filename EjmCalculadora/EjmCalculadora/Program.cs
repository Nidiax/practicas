// See https://aka.ms/new-console-template for more information
Console.WriteLine("Calculadora");

int valor1;
int valor2;
int suma;
int resta;
int multiplacacion;
int division;

Console.WriteLine("Ingrese un número");
valor1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese un número");
valor2 = Convert.ToInt32(Console.ReadLine());

suma = valor1 + valor2;
resta = valor1 - valor2;
multiplacacion = valor1 * valor2;
division = valor1 / valor2;

Console.WriteLine("El resultado de la suma es " + suma);
Console.WriteLine("El restado de la resta es " + resta);
Console.WriteLine("El resultado de la multiplicación es " + multiplacacion);
Console.WriteLine("El resultado de la división es " + division);


