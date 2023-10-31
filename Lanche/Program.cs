using System;

string[] valores = Console.ReadLine().Split(' ');
int codigoItem = int.Parse(valores[0]);
int quantidadeItem = int.Parse(valores[1]);
double totalPagar = 0;

switch (codigoItem)
{
    case 1:
        totalPagar = 4.00 * quantidadeItem;
        Console.WriteLine("Total: R$ " + totalPagar.ToString("F2"));
        break;

    case 2:
        totalPagar = 4.50 * quantidadeItem;
        Console.WriteLine("Total: R$ " + totalPagar.ToString("F2"));
        break;

    case 3:
        totalPagar = 5.00 * quantidadeItem;
        Console.WriteLine("Total: R$ " + totalPagar.ToString("F2"));
        break;

    case 4:
        totalPagar = 2.00 * quantidadeItem;
        Console.WriteLine("Total: R$ " + totalPagar.ToString("F2"));
        break;

    case 5:
        totalPagar = 1.50 * quantidadeItem;
        Console.WriteLine("Total: R$ " + totalPagar.ToString("F2"));
        break;

    default:
        return;
}