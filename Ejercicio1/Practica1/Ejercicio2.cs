using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1{
    internal class Ejercicio2{
        static void Main(string[] args){
            string nombre, profecion, Edad, genero;
            int edad;
            Console.WriteLine("Ingrese su Nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su Profecion:");
            profecion = Console.ReadLine();
            Console.WriteLine("Ingrese su Edad:");
            Edad = Console.ReadLine();
            edad = int.Parse(Edad);
            Console.WriteLine("Ingrese su Genero:");
            genero = Console.ReadLine();
            Console.WriteLine("Usted es " + nombre + " tiene " + edad + " es " + genero + " y trabaja de " + profecion);
            Console.ReadLine();
        }
    }
}