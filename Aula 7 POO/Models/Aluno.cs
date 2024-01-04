using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_7_POO.Models
{
    public class Aluno : Pessoa
    {
        public Aluno(string nome) :base(nome)
        {

        }

        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Ola meu nome é {Nome}, tenho {Idade} anos, e sou aluno nota {Nota}");
        }
    }
}