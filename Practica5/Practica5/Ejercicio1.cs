using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5{
    internal class Ejercicio1{
        static void Main(string[] args){
            string mensajeLargo = "";
            Console.WriteLine("Escriva un mensaje largo:");
            mensajeLargo = Console.ReadLine();
            Console.WriteLine("Mensaje original:");
            Console.WriteLine(mensajeLargo);
            string mensajeSinEspacios = mensajeLargo.Replace(" ", "");
            Console.WriteLine("\nMensaje sin espacios:");
            Console.WriteLine(mensajeSinEspacios);
            char[] caracteresReverso = mensajeSinEspacios.ToCharArray();
            Array.Reverse(caracteresReverso);
            string mensajeAlReves = new string(caracteresReverso);
            Console.WriteLine("\nMensaje al revés:");
            Console.WriteLine(mensajeAlReves);
            Console.ReadLine();
        }
    }
}