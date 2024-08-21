using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1{
    internal class Ejercicio3{
        static void Main(string[] args){
            double horas, res, horasX;
            string Horas;
            Console.WriteLine("Ingrese cuantas horas trabaja:");
            Horas = Console.ReadLine();
            horas = double.Parse(Horas);
            if (horas <= 40){
                res = 50 * horas;
                Console.WriteLine("Su sueldo es de: " + res);
                Console.ReadLine();
            }
            else{
                if (horas > 40){
                    horasX = horas - 40;
                    res = (50 * 40) + (100 * horasX);
                    Console.WriteLine("Su sueldo es de: " + res);
                    Console.ReadLine();
                }
            }
            
        }
    }
}