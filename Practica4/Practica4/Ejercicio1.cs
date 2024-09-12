using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4{
    internal class Ejercicio1{
        static void Main(string[] args){
            List<int> edad = new List<int>();
            int opc=0;
            while (opc != 2){
                Console.WriteLine("####################");
                Console.WriteLine("#       Menu       #");
                Console.WriteLine("# 1.Ingresar edad. #");
                Console.WriteLine("# 2.Calcular.      #");
                Console.WriteLine("####################");
                Console.WriteLine("Elige una opcion:");
                opc = int.Parse(Console.ReadLine());
                if (opc == 1){
                    Console.WriteLine("Escribe una edad:");
                    edad.Add(int.Parse(Console.ReadLine()));
                }
            }
            int numeroMenor = edad.Min();
            int numeroMayor = edad.Max();
            Console.WriteLine("La edad minima es "+numeroMenor+" y la edad maxima es "+numeroMayor);
            Console.ReadLine();
        }
    }
}