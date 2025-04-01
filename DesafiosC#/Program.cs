using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace DesafiosCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nEscolha um desafio para executar:");
                Console.WriteLine("1 - Soma de dígitos recursiva");
                Console.WriteLine("2 - Verificador de palíndromo");
                Console.WriteLine("3 - Verificador de número primo");
                Console.WriteLine("4 - Calculadora de média");
                Console.WriteLine("5 - Jogo de adivinhação");
                Console.WriteLine("6 - Sistema de funcionários");
                Console.WriteLine("0 - Sair");
                Console.Write("Opção: ");

                if (!int.TryParse(Console.ReadLine(), out int opcao))
                {
                    Console.WriteLine("Opção inválida!");
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        SomaDigitos.Executar();
                        break;
                    case 2:
                        Palindromo.Executar();
                        break;
                    case 3:
                        Primo.Executar();
                        break;
                    case 4:
                        MediaAluno.Executar();
                        break;
                    case 5:
                        JogoAdivinhacao.Executar();
                        break;
                    case 6:
                        ProgramaFuncionarios.Executar();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
    }
}
