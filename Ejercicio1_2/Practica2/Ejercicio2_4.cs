using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2{
    internal class Ejercicio2_4{
        static void Main(string[] args){
            int num1,num2,num3, menor, mayor;
            string Num1,Num2,Num3;
            Console.WriteLine("Ingresa el primer numero:");
            Num1 = Console.ReadLine();
            num1 = int.Parse(Num1);
            Console.WriteLine("Ingresa el segundo numero:");
            Num2 = Console.ReadLine();
            num2 = int.Parse(Num2);
            Console.WriteLine("Ingresa el tercer numero:");
            Num3 = Console.ReadLine();
            num3 = int.Parse(Num3);
            if (num1 <= num2 && num1 <= num3){
                menor = num1;
            }else{
                if (num2 <= num1 && num2 <= num3){
                    menor = num2;
                }else{
                    menor = num3;
                }
            }

            if (num1 >= num2 && num1 >= num3){
                mayor = num1;
            }else{
                if (num2 >= num1 && num2 >= num3){
                    mayor = num2;
                }else{
                    mayor = num3;
                }
            }

            Console.WriteLine("El menor:" + menor+". El mayor:"+mayor);
            Console.ReadLine();
        }
    }
}