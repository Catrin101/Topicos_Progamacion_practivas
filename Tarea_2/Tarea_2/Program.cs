using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2{
    internal class Program{
        static void Main(string[] args){
            Console.Write("Ingrese su calificasion:");
            int valor = int.Parse(Console.ReadLine());
            switch (valor){
                case 10:
                    Console.Write("Excelente");
                    break;
                case 9:
                    Console.Write("Muy Bien");
                    break;
                case 8:
                    Console.Write("Bien");
                    break;
                case 7:
                    Console.Write("Regular");
                    break;
                case 6:
                    Console.Write("Suficiente");
                    break;
                default:
                    Console.Write("Insuficiente");

                    break;

            }
            Console.ReadKey();
        }
    }
}