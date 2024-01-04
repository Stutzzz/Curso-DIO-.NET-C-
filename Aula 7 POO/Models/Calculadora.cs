using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_7_POO.Interfaces;

namespace Aula_7_POO.Models
{
    public class Calculadora : ICalculadora
    {
        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Somar(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

    }
}