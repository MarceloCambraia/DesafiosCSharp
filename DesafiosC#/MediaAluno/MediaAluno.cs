using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace DesafiosCSharp
{
    public static class MediaAluno
    {
        public static void Executar()
        {
            Console.Write("\nDigite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            double nota3 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine($"Média: {media:F2}");

            if (media >= 6.0)
                Console.WriteLine("Aprovado!");
            else
                Console.WriteLine("Reprovado!");
        }
    }
}
