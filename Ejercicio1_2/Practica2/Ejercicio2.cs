using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2{
    internal class Ejercicio2{
        static void Main(string[] args){
            int anno,res;
            string Anno;
            Console.WriteLine("Ingrese un Año:");
            Anno = Console.ReadLine();
            anno = int.Parse(Anno);
            res = anno % 4;
            if (res == 0){
                Console.WriteLine(anno + " es bisiesto");
            }
            else {
                if (res == 1){
                    Console.WriteLine(anno + " no es bisiesto");
                }
                else {
                    Console.WriteLine("error");
                }
            }
            Console.ReadLine();
        }
    }
}