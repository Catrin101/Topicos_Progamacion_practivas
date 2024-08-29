using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2{
    internal class Ejercicio3{
        static void Main(string[] args){
            int opcion;
            double altura,basee,area;
            string Opcion,Altura,Base;
            Console.WriteLine("##################");
            Console.WriteLine("#      MENU      #");
            Console.WriteLine("# 1) Rectangulo. #");
            Console.WriteLine("# 2) Circulo.    #");
            Console.WriteLine("# 3) Triangulo.  #");
            Console.WriteLine("##################");
            Console.WriteLine("");
            Console.WriteLine("Escoje una opcion:");
            Opcion = Console.ReadLine();
            opcion = int.Parse(Opcion);
            if (opcion == 1){
                Console.WriteLine("Ingrese la Altura:");
                Altura = Console.ReadLine();
                altura = double.Parse(Altura);
                Console.WriteLine("Ingrese la Base:");
                Base = Console.ReadLine();
                basee = double.Parse(Base);
                area = basee * altura;
                Console.WriteLine("Area = "+area);
            }
            else {
                if (opcion == 2){
                    Console.WriteLine("Ingrese el Radio:");
                    Altura = Console.ReadLine();
                    altura = double.Parse(Altura);
                    area = 3.14 * (altura * altura);
                    Console.WriteLine("Area = " + area);
                }
                else {
                    if (opcion == 3){
                        Console.WriteLine("Ingrese la Altura:");
                        Altura = Console.ReadLine();
                        altura = double.Parse(Altura);
                        Console.WriteLine("Ingrese la Base:");
                        Base = Console.ReadLine();
                        basee = double.Parse(Base);
                        area = (basee * altura) / 2;
                        Console.WriteLine("Area = " + area);
                    }
                    else {
                        Console.WriteLine("Opcion no validad }:(");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}