using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace DesafiosCSharp
{
    public static class JogoAdivinhacao
    {
        public static void Executar()
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);
            int tentativas = 0;
            int palpite;

            Console.WriteLine("Adivinhe o número entre 1 e 100!");

            do
            {
                Console.Write("Digite seu palpite: ");
                palpite = int.Parse(Console.ReadLine());
                tentativas++;

                if (palpite < numeroSecreto)
                    Console.WriteLine("Muito baixo!");
                else if (palpite > numeroSecreto)
                    Console.WriteLine("Muito alto!");
                else
                    Console.WriteLine($"Parabéns, você acertou em {tentativas} tentativas!");
            } while (palpite != numeroSecreto);
        }
    }
}