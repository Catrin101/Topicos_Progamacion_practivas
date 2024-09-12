using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4{
    internal class Ejercicio3{
        static void Main(string[] args){
            List<int> numero = new List<int>();
            int res=0;
            for (int i = 0; i < 2; i++){
                Console.WriteLine("Ingrese un numero:");
                numero.Add(int.Parse(Console.ReadLine()));
            }
            int numeroMenor = numero.Min();
            int numeroMayor = numero.Max();
            int cont = numeroMenor;
            for (int i = numeroMenor; i < numeroMayor+1; i++){
                if (i % 2 == 0) {
                    Console.WriteLine(i);
                    res = res + i;
                }
            }
            Console.WriteLine("La suma de todos los numeros es:"+res);
            Console.ReadLine();
        }
    }
}