using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practica_3{
    internal class Ejercicio_3{
        static void Main(string[] args){
            int num,res;
            Console.WriteLine("ingrese un numero:");
            num = int.Parse(Console.ReadLine());
            if (num < 50) {
                res = 1;
            }else{
                if (num == 50){
                    res = 2;
                }else {
                    res = 3;
                }
            }
            switch (res){
                case 1: Console.WriteLine("El numero "+num+" es menor que 50");
                    break;
                case 2: Console.WriteLine("El numero "+num+" claramente es igual que 50");
                    break;
                case 3: Console.WriteLine("El numero "+num+" es mayor que 50");
                    break;
                default: Console.WriteLine("el numero no es valido");
                    break;
            }
            Console.ReadLine();
        }
    }
}