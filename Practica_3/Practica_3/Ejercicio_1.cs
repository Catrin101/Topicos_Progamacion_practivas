using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3{
    internal class Ejercicio_1{
        static void Main(string[] args){
            int num, res;
            Console.WriteLine("ingrese un numero del 1 al 8:");
            num = int.Parse(Console.ReadLine());
            switch(num){
                case 1: res = num * num;
                     Console.WriteLine("=" + res);
                    break;
                case 2: res = num * num;
                     Console.WriteLine("=" + res);
                    break;
                case 3: res = num * num;
                    Console.WriteLine("=" + res);
                    break;
                case 4: res = num * num;
                    Console.WriteLine("=" + res);
                    break;
                case 5: res = num * num;
                     Console.WriteLine("=" + res);
                    break;
                case 6: res = num * num;
                    Console.WriteLine("=" + res);
                    break;
                case 7: res = num * num;
                    Console.WriteLine("=" + res);
                    break;
                case 8: res = num * num;
                    Console.WriteLine("=" + res);
                    break;
                default: Console.WriteLine("el numero no es valido");
                    break;
            }
            Console.ReadLine();
        }
    }
}