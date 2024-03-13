using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ganhoTotal, apostaPrimeiro, apostaSegundo, apostaTerceiro, apostaTotal, ganhoPrimeiro, ganhoSegundo, ganhoTerceiro;

            Console.WriteLine("Insira o valor total do prêmio (R$): ");
            ganhoTotal = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor da primeira aposta (R$): ");
            apostaPrimeiro = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor da segunda aposta (R$): ");
            apostaSegundo = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor da terceira aposta (R$): ");
            apostaTerceiro = double.Parse(Console.ReadLine());
            apostaTotal = apostaPrimeiro + apostaSegundo + apostaTerceiro;

            ganhoPrimeiro = (apostaPrimeiro / apostaTotal) * ganhoTotal;
            ganhoSegundo = (apostaSegundo / apostaTotal) * ganhoTotal;
            ganhoTerceiro = (apostaTerceiro / apostaTotal) * ganhoTotal;

            Console.WriteLine($"O valor do prêmio é: {ganhoTotal}");
            Console.WriteLine($"O valor apostado pelo primeiro apostador é: {apostaPrimeiro} R$ e portanto o valor do prêmio para ele é: {ganhoPrimeiro} R$");
            Console.WriteLine($"O valor apostado pelo segundo apostador é: {apostaSegundo} R$ e portanto o valor do prêmio para ele é: {ganhoSegundo} R$");
            Console.WriteLine($"O valor apostado pelo terceiro apostador é: {apostaTerceiro} R$ e portanto o valor do prêmio para ele é: {ganhoTerceiro} R$");
            Console.ReadLine();
        }
    }
}
