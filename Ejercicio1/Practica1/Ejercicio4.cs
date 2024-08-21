using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1{
    internal class Ejercicio4{
        static void Main(string[] args){
            int numero, n1, n2, n3, aux;
            string linea;
            Console.WriteLine("Ingrese un numero de 3 cifras.");
            linea = Console.ReadLine();
            numero = int.Parse(linea);
            n1 = numero / 100;
            numero = numero % 100;
            n2 = numero / 10;
            n3 = numero % 10;
            aux = (n3 * 100) + (n2 * 10) + n1;
            Console.WriteLine("El nuevo numero es: " + aux);
            Console.ReadLine();
        }
    }
}