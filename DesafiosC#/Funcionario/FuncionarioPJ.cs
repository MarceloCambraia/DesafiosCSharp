using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosCSharp.Models
{
    public class FuncionarioPJ : Funcionario
    {
        public int HorasTrabalhadas { get; set; }
        public double ValorHora { get; set; }

        public FuncionarioPJ(string nome, int idade, int horasTrabalhadas, double valorHora)
            : base(nome, idade, 0) 
        {
            HorasTrabalhadas = horasTrabalhadas;
            ValorHora = valorHora;
            CalcularSalario(); 
        }

        public override void CalcularSalario()
        {
            Salario = HorasTrabalhadas * ValorHora;
        }
    }
}