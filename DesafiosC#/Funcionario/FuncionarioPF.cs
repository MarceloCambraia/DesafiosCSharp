using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosCSharp.Models
{
    public class FuncionarioPF : Funcionario
    {
        public FuncionarioPF(string nome, int idade, double salarioFixo)
            : base(nome, idade, salarioFixo)
        {

        }

        public override void CalcularSalario()
        {

        }
    }
}