using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4{
    internal class Ejercicio4{
        static void Main(string[] args) {
            int cuenta=0,cantidad;
            string opc="";
            while (opc != "c") {
                Console.WriteLine("###################");
                Console.WriteLine("# Cuenta Bancaria #");
                Console.WriteLine("# A.Deposito.     #");
                Console.WriteLine("# B.Retiro.       #");
                Console.WriteLine("# C.Salir         #");
                Console.WriteLine("###################");
                Console.WriteLine("# Tu dinero:"+cuenta);
                Console.WriteLine("###################");
                Console.WriteLine("Elige una Opcion:");
                opc = Console.ReadLine();
                switch (opc) {
                    case "a":
                        Console.WriteLine("Coanto quiere Depositar?:");
                        cantidad = int.Parse(Console.ReadLine());
                        cuenta = cuenta + cantidad;
                        break;
                    case "b":
                        Console.WriteLine("Coanto quiere Depositar?:");
                        cantidad = int.Parse(Console.ReadLine());
                        cuenta = cuenta - cantidad;
                        break;
                    case "c":
                        Console.WriteLine("Adios :)");
                        break;
                    default:
                        Console.WriteLine("Error opcion incorrecta o letra mayuscula");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}