using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5{
    internal class Ejercicio2{
        static void Main(string[] args){
            string nombre = "";
            Console.Write("Ingresa un nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Longitud del nombre:"+ nombre.Length);
            
            bool tieneElementos = !string.IsNullOrEmpty(nombre);
            Console.WriteLine("¿El nombre tiene elementos?"+tieneElementos);
            
            string nombreMayusculas = nombre.ToUpper();
            string nombreMinusculas = nombre.ToLower();
            Console.WriteLine("Nombre en mayúsculas:"+nombreMayusculas);
            Console.WriteLine("Nombre en minúsculas:"+nombreMinusculas);
            
            Console.Write("Ingresa una letra para remover del nombre: ");
            char letraARemover = Console.ReadKey().KeyChar;
            string nombreSinLetra = nombre.Replace(letraARemover.ToString(), "");
            Console.WriteLine("\nNombre sin la letra "+letraARemover+":"+nombreSinLetra);
            
            Console.Write("Ingresa un índice inicial: ");
            int indiceInicial = int.Parse(Console.ReadLine());
            Console.Write("Ingresa la cantidad de caracteres a extraer: ");
            int cantidadCaracteres = int.Parse(Console.ReadLine());
            string subcadena = nombre.Substring(indiceInicial, cantidadCaracteres);
            Console.WriteLine("Subcadena extraída:"+subcadena);
            
            Console.WriteLine("Elementos de izquierda a derecha:");
            for (int i = 0; i < nombre.Length; i++)
            {
                Console.Write(nombre[i] + " ");
            }
            Console.WriteLine("\nElementos de derecha a izquierda:");
            for (int i = nombre.Length - 1; i >= 0; i--)
            {
                Console.Write(nombre[i] + " ");
            }
            Console.ReadLine();
        }
    }
}