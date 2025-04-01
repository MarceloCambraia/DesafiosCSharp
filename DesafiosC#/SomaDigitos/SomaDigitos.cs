using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace DesafiosCSharp
{
    public static class SomaDigitos
    {
        public static int SomaDigitosRecursiva(int n)
        {
            if (n < 10)
                return n;

            return (n % 10) + SomaDigitosRecursiva(n / 10);
        }

        public static void Executar()
        {
            Console.Write("\nDigite um número inteiro positivo: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"A soma dos dígitos é: {SomaDigitosRecursiva(numero)}");
        }
    }
}