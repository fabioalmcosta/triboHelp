using System;
using System.Collections.Generic;
using System.Linq;

namespace triboHelp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao programa de loja feito para ajudar a Tribo Gaules.");
            Console.WriteLine("----------------------------------------------------------------------------------");

            Console.Write("Digite o nome do liente: ");
            string name = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Digite o CPF do cliente: ");
            string doc = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos dessa compra: ");
            int index = int.Parse(Console.ReadLine());

            List<double> prices = new List<double>();
            Console.WriteLine();

            for (int i = 1; i <= index; i++)
            {
                Console.Write($"Digite o preço para o {i}° produto: R$");
                prices.Add(double.Parse(Console.ReadLine()));
            }

            double total = prices.Sum();

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("Resumo parcial da compra:");
            Console.WriteLine($"Preço total: R${total}");

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("Modalidades de pagamento:");
            Console.WriteLine("1. a vista");
            Console.WriteLine("2. de 2 a 5");
            Console.WriteLine("3. de 6 a 10");
            Console.WriteLine("4. de 11 a 15");

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.Write("Digite o número de parcelas: ");
            int installments = int.Parse(Console.ReadLine());


            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("Resumo da compra: ");
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine($"Cliente: {name} - CPF: {doc}");
            Console.WriteLine($"Preço de tabela: R${total}");
            Console.WriteLine($"Parcelas: {installments}");

            switch (installments)
            {
                case 1:
                    Console.WriteLine("Preço a vista com desconto: R${0:0.00}", total - (total * 0.02));
                    break;
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Preço de tabela: R${0:0.00}", total);
                    break;
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    Console.WriteLine("Preço com 6% de juros: R${0:0.00}", total * 1.06);
                    break;
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                    Console.WriteLine("Preço com 13% de juros: R${0:0.00}", total * 1.13);
                    break;
                default:
                    Console.WriteLine("Número de parcelas inválido!");
                    break;
            }







        }
    }
}
