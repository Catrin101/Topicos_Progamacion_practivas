using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3{
    internal class Ejercicio_2{
        static void Main(string[] args) {
            int num1,num2,opc, res;
            Console.WriteLine("Ingrese el pirmer numero:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundon numero:");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("####################");
            Console.WriteLine("# 1.Suma           #");
            Console.WriteLine("# 2.Resta          #");
            Console.WriteLine("# 3.Multiplicacion #");
            Console.WriteLine("# 4.Divicion       #");
            Console.WriteLine("####################");
            Console.WriteLine("Elige una opcion:");
            opc = int.Parse(Console.ReadLine());
            switch (opc){
                case 1: res = num1 + num2;
                        Console.WriteLine("La suma de "+num1+" y de "+num2+" da como resultado "+res);
                    break;
                case 2: res = num1 - num2;
                        Console.WriteLine("La resta de " + num1 + " y de " + num2 + " da como resultado " + res);
                    break;
                case 3: res = num1 * num2;
                        Console.WriteLine("La multiplicasion de " + num1 + " y de " + num2 + " da como resultado " + res);
                    break;
                case 4: res = num1 / num2;
                        Console.WriteLine("La divicion de " + num1 + " y de " + num2 + " da como resultado " + res);
                    break;
                default: Console.WriteLine("Opcion no valida");
                    break;
            }
            Console.ReadLine();
        }
    }
}