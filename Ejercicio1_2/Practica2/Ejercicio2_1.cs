using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2{
    internal class Ejercicio2_1{
        static void Main(string[] args){
            double cal1,cal2,cal3,cal4,cal5,promedio;
            string Cal1,Cal2,Cal3,Cal4,Cal5;
            Console.WriteLine("Ingrese la primera calificacion:");
            Cal1 = Console.ReadLine();
            cal1 = double.Parse(Cal1);
            Console.WriteLine("Ingrese la segunda calificacion:");
            Cal2 = Console.ReadLine();
            cal2 = double.Parse(Cal2);
            Console.WriteLine("Ingrese la tercera calificacion:");
            Cal3 = Console.ReadLine();
            cal3 = double.Parse(Cal3);
            Console.WriteLine("Ingrese la cuarta calificacion:");
            Cal4 = Console.ReadLine();
            cal4 = double.Parse(Cal4);
            Console.WriteLine("Ingrese la quinta calificacion:");
            Cal5 = Console.ReadLine();
            cal5 = double.Parse(Cal5);
            promedio = (cal1 + cal2 + cal3 + cal3 + cal4 + cal5) / 5;
            if (promedio >= 60){
                Console.WriteLine("su promedio es de " + promedio + " Aprobo");
            }
            else {
                Console.WriteLine("su promedio es de " + promedio + " reprobo");
            }
            Console.ReadLine();
        }
    }
}