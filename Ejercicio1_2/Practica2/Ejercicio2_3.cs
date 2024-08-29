using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2{
    internal class Ejercicio2_3{
        static void Main(string[] args){
            int numero, res;
            string Numero;
            Console.WriteLine("Ingrese un numero:");
            Numero = Console.ReadLine();
            numero = int.Parse(Numero);
            res = numero % 2;
            if (res == 1){
                Console.WriteLine(numero + " es impar");
            }
            else {
                if (res == 0){
                    Console.WriteLine(numero + " es par");
                }
                else {
                    Console.WriteLine("numero invalido");
                }
            }
            Console.ReadLine();
        }
    }
}