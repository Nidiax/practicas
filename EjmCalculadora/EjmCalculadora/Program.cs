// See https://aka.ms/new-console-template for more information
Console.WriteLine("Calculadora");

double valor1;
double valor2;
double suma;
double resta;
double multiplacacion;
double division;
double potencia;
double potenciaraiz;

Console.WriteLine("Ingrese un número");
valor1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese un número");
valor2 = Convert.ToDouble(Console.ReadLine());

suma = valor1 + valor2;
resta = valor1 - valor2;
multiplacacion = valor1 * valor2;
division = valor1 / valor2;
//math.pow sirve para elevar un numero
potencia = Math.Pow(valor1, valor2);
potenciaraiz = Math.Pow(valor1, (double) 1 /valor2);

Console.WriteLine("El resultado de la suma es " + suma);
Console.WriteLine("El restado de la resta es " + resta);
Console.WriteLine("El resultado de la multiplicación es " + multiplacacion);
Console.WriteLine("El resultado de la división es " + division);
//Console.WriteLine("El resultado de la potencia es " + potencia);
Console.WriteLine("La potencia {0} elevado a {1} es {2} " , valor1, valor2, potencia);
Console.WriteLine("La raiz de {0} es {1} " , valor1, potenciaraiz);


