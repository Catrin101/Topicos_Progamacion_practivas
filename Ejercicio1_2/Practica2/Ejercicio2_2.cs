using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2{
    internal class Ejercicio2_2{
        static void Main(string[] args){
            int edad;
            string Edad,genero;
            Console.WriteLine("Cual es su edad?:");
            Edad = Console.ReadLine();
            edad = int.Parse(Edad);
            Console.WriteLine("Cual es su genero?:");
            genero = Console.ReadLine();
            if (genero == "hombre" || genero == "Hombre"){
                if (edad <= 18){
                    Console.WriteLine("Heres menor de edad");
                }
                else {
                    Console.WriteLine("Heres mayor de edad");
                }
            }
            else {
                Console.WriteLine("Heres mujer");
            }
            Console.ReadLine();
        }
    }
}