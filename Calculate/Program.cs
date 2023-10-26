using System;
using System.ComponentModel.Design;

namespace Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();

        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Escolha a operação desejada: ");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");


            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1:
                    Soma();
                    break;

                case 2:
                    Subtracao();
                    break;

                case 3:
                    Multiplicacao();
                    break;

                case 4:
                    Divisao();
                    break;

                case 5:
                 Environment.Exit(0);
                    break;

                default:
                    Menu();
                    break;

            }
        }


        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Digita o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            float resultado = valor1 + valor2;

            Console.WriteLine("O resultado da soma é: " + resultado);
            Console.ReadKey();

            Menu();
        }
        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            float resultado = valor1 - valor2;
            Console.WriteLine("O resultado da subtração é: " + resultado);
            Console.ReadKey();

            Menu();
        }
        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            float resultado = valor1 * valor2;
            Console.WriteLine("O resultado da multiplicação é: " + resultado);
            Console.ReadKey();

            Menu();
        }
        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            float resultado = valor1 / valor2;
            Console.WriteLine("O resultado da divisão é: " + resultado);
            Console.ReadKey();

            Menu();
        }

    }
}