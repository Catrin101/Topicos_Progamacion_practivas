using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2{
    internal class Ejercicio1{
        static void Main(string[] args){
            int edad;
            string Edad;
            Console.WriteLine("Cual es su edad?:");
            Edad = Console.ReadLine();
            edad = int.Parse(Edad);
            if (edad <= 0){
                Console.WriteLine("Volor invalido");
            }
            else {
                if (edad >= 18){
                    Console.WriteLine("Heres mayor de edad");
                }
                else {
                    Console.WriteLine("Heres menor de edad");
                }
            }
            Console.ReadLine();
        }
    }
}