using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2{
    internal class Ejercicio2_5{
        static void Main(string[] args){
            double numero, valorAbsoluto, potencia, raizCuadrada, seno, coseno, 
                redondeo, truncamiento;
            int opc;
            Console.WriteLine("######################");
            Console.WriteLine("#         MENU       #");
            Console.WriteLine("# 1) valor absoluto. #");
            Console.WriteLine("# 2) potencia.       #");
            Console.WriteLine("# 3) raiz cuadrada.  #");
            Console.WriteLine("# 4) seno.           #");
            Console.WriteLine("# 5) coseno.         #");
            Console.WriteLine("# 6) redondeo.       #");
            Console.WriteLine("# 7) truncamiento.   #");
            Console.WriteLine("######################");
            Console.WriteLine("");
            Console.WriteLine("Introduce un número:");
            opc = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce un número:");
            numero = double.Parse(Console.ReadLine());
            if (opc == 1) {
                valorAbsoluto = Math.Abs(numero);
                Console.WriteLine("Valor absoluto: " + valorAbsoluto);
            }else {
                if (opc == 2){
                    potencia = Math.Pow(numero, 2);
                    Console.WriteLine("Potencia (cuadrado): " + potencia);
                }else{
                    if (opc == 3){
                        raizCuadrada = Math.Sqrt(numero);
                        Console.WriteLine("Raíz cuadrada: " + raizCuadrada);
                    }else{
                        if (opc == 4){
                            seno = Math.Sin(numero);
                            Console.WriteLine("Seno: " + seno);
                        }else{
                            if (opc == 5){
                                coseno = Math.Cos(numero);
                                Console.WriteLine("Coseno: " + coseno);
                            }else{
                                if (opc == 6){
                                    redondeo = Math.Round(numero);
                                    Console.WriteLine("Redondeo: " + redondeo);
                                }else{
                                    truncamiento = Math.Truncate(numero);
                                    Console.WriteLine("Truncamiento: " + truncamiento);
                                }
                            }
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}