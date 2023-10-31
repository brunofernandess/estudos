using System;

string[] valores = Console.ReadLine().Split(' ');
int valor1 = int.Parse(valores[0]);
int valor2 = int.Parse(valores[1]);
int valor3 = int.Parse(valores[2]);

int maiorValor = Math.Max(valor1, Math.Max(valor2, valor3));

Console.WriteLine(maiorValor + " eh o maior");