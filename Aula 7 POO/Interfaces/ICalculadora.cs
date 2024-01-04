using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_7_POO.Interfaces
{
    public class ICalculadora
    {
        int Somar(int num1, int num2);
        int Subtrair(int num1 , int num2);
        int Multiplicar(int num1 , int num2);
        int Dividir(int num1 , int num2);
    }
}