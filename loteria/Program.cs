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
            Console.WriteLine("----Bem-Vindo ao programa Loteria Premiada---");
            Console.WriteLine("--------------------------------------------");
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

            Console.WriteLine($"O valor do prêmio é de: {ganhoTotal} R$");
            Console.WriteLine("Após o resultado, a divisão dos valores entre os amigos se deu da seguinte maneira: ");
            Console.WriteLine($"O valor apostado pelo primeiro apostador é: {apostaPrimeiro} R$ e portanto o valor do prêmio para ele é: {ganhoPrimeiro:0.00} R$");
            Console.WriteLine($"O valor apostado pelo segundo apostador é: {apostaSegundo} R$ e portanto o valor do prêmio para ele é: {ganhoSegundo:0.00} R$");
            Console.WriteLine($"O valor apostado pelo terceiro apostador é: {apostaTerceiro} R$ e portanto o valor do prêmio para ele é: {ganhoTerceiro:0.00} R$");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Tecle ENTER para encerrar o programa");
            Console.ReadLine();
        }
    }
}
