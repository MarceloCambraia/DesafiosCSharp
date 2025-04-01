using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

using System;
using DesafiosCSharp.Models;

namespace DesafiosCSharp
{
    public static class ProgramaFuncionarios
    {
        public static void Executar()
        {
            Random random = new Random();

            // Criando funcionário PJ
            var pj = new FuncionarioPJ(
                nome: "João Silva",
                idade: 30,
                horasTrabalhadas: random.Next(80, 181),
                valorHora: random.Next(50, 151)
            );

            // Criando funcionário PF
            var pf = new FuncionarioPF(
                nome: "Maria Souza",
                idade: 35,
                salarioFixo: random.Next(3000, 10001)
            );

            Console.WriteLine("\nFuncionário PJ");
            Console.WriteLine($"Nome: {pj.Nome}");
            Console.WriteLine($"Idade: {pj.Idade}");
            Console.WriteLine($"Salário: R${pj.Salario:F2}");

            Console.WriteLine("\nFuncionário PF");
            Console.WriteLine($"Nome: {pf.Nome}");
            Console.WriteLine($"Idade: {pf.Idade}");
            Console.WriteLine($"Salário: R${pf.Salario:F2}");
        }
    }
}