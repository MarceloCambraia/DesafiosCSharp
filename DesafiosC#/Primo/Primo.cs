using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace DesafiosCSharp
{
    public static class Primo
    {
        public static bool EhPrimo(int n)
        {
            if (n <= 1)
                return false;

            if (n == 2)
                return true;

            if (n % 2 == 0)
                return false;

            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        public static void Executar()
        {
            Console.Write("\nDigite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"É primo? {EhPrimo(numero)}");
        }
    }
}