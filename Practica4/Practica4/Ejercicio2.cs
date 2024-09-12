using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4{
    internal class Ejercicio2{
        static void Main(string[] args){
            List<int> numero = new List<int>();
            for (int i = 0; i < 2; i++){
                Console.WriteLine("Ingrese un numero:");
                numero.Add(int.Parse(Console.ReadLine()));
            }
            int numeroMenor = numero.Min();
            int numeroMayor = numero.Max();
            int cont = numeroMenor;
            for (int i = numeroMenor; i < numeroMayor+1; i++) {
                if (EsPrimo(i)) {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
        static bool EsPrimo(int numero)
        {
            if (numero <= 1)
                return false;

            for (int i = 2; i * i <= numero; i++)
            {
                if (numero % i == 0)
                    return false;
            }

            return true;
        }
    }
}