using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///PARTE 3 Danilo Lora
            ///
            // Para digitar todo en un menu puedes escribir el metodo Menu();
            //pero tambien puedes escribir el metodo de cada ejercicio ejemplo : Parte3_Ejercicio1();


            Menu();
            

        }
        static void Parte3_Ejercicio1()
        {
            /* 1. Realizar un programa que nos pida un número n, y nos diga cuantos
        números hay entre 1 y n que son primos.*/
            Boolean esPrimo;
            int j;
            int contador_numeros_primos = 0;
            Console.WriteLine("Digite un numero");
            int numero = int.Parse(Console.ReadLine());
            for (int i = 0; i < numero; i++)
            {
                esPrimo = true;
                j = 2;
                while (j <= i - 1 && esPrimo == true)
                {
                    if (i % j == 0)
                        esPrimo = false;
                    j++;
                }
                if (esPrimo == true)
                {
                    contador_numeros_primos++;
                    Console.WriteLine(i + " Es primo");
                }
            }
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Entre el 1 y el " + numero + " solo hay " + contador_numeros_primos + " numeros primos");
        }
        static void Parte3_Ejercicio2()
        {
            //Pedir un número N, introducir N sueldos, y mostrar el sueldo máximo.
            float sueldo = 0;
            float maximo = 0;
            Console.WriteLine("Digite el numero de sueldos: : ");
            int numero = int.Parse(Console.ReadLine());
            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine("Digite el valor del sueldo " + (i + 1) + ":");
                sueldo = float.Parse(Console.ReadLine());
                if (sueldo > maximo)
                {
                    maximo = sueldo;
                }
            }
            Console.WriteLine("el sueldo maximo es: " + maximo);


        }

        static void Parte3_Ejercicio3()
        {
            /* Pedir un número de 0 a 99 y mostrarlo escrito. Por ejemplo, para 56
            mostrar: cincuenta y seis. Pista: separar las unidades y las decenas.
            (unidades = num % 10; decenas = num / 10). */
            Console.WriteLine("Digite un numero del 0 al 99");
            int numero = int.Parse(Console.ReadLine());
            int unidades, decenas;
            string unidadesl = "", decenasl = "", especialesl = "";
            unidades = numero % 10;
            decenas = numero / 10;
            if (unidades == 1)
            {
                unidadesl = "uno";
            }
            else if (unidades == 2)
            {
                unidadesl = "dos";
            }
            else if (unidades == 3)
            {
                unidadesl = "tres";
            }
            else if (unidades == 4)
            {
                unidadesl = "cuadro";
            }
            else if (unidades == 5)
            {
                unidadesl = "cinco";
            }
            else if (unidades == 6)
            {
                unidadesl = "seis";
            }
            else if (unidades == 7)
            {
                unidadesl = "siete";
            }
            else if (unidades == 8)
            {
                unidadesl = "ocho";
            }
            else if (unidades == 9)
            {
                unidadesl = "nueve";
            }
            //---------------- numeros especiales-----
            if (decenas == 1 && unidades == 0)
            {
                especialesl = "diez";
            }
            else if (decenas == 1 && unidades == 1)
            {
                especialesl = "once";
            }
            else if (decenas == 1 && unidades == 2)
            {
                especialesl = "doce";
            }
            else if (decenas == 1 && unidades == 3)
            {
                especialesl = "trece";
            }
            else if (decenas == 1 && unidades == 4)
            {
                especialesl = "catorce";
            }
            else if (decenas == 1 && unidades == 5)
            {
                especialesl = "quince";
            }
            else if (decenas == 1 && unidades == 6)
            {
                especialesl = "dieciseis ";
            }
            else if (decenas == 1 && unidades == 7)
            {
                especialesl = "diecisiete";
            }
            else if (decenas == 1 && unidades == 8)
            {
                especialesl = "dieciocho";
            }
            else if (decenas == 1 && unidades == 9)
            {
                especialesl = "diecinueve";
            }
            //----------decenas-----
            if (decenas == 2)
            {
                decenasl = "veinte";
            }
            else if (decenas == 3)
            {
                decenasl = "treinta";
            }
            else if (decenas == 4)
            {
                decenasl = "cuarenta";
            }
            else if (decenas == 5)
            {
                decenasl = "cincuenta";
            }
            else if (decenas == 6)
            {
                decenasl = "sesenta";
            }
            else if (decenas == 7)
            {
                decenasl = "setenta";
            }
            else if (decenas == 8)
            {
                decenasl = "ochenta";
            }
            else if (decenas == 9)
            {
                decenasl = "noventa";
            }
            //---------------------

            if (numero < 10)
            {
                Console.WriteLine("Su numero es el " + unidadesl);
            }
            else if (numero < 20)
            {
                Console.WriteLine("Su numero es el: " + especialesl);
            }
            else if (numero < 100)
            {
                if (numero % 10 == 0)
                {
                    Console.WriteLine("Su numero es el: " + decenasl);
                }
                else
                {
                    Console.WriteLine("Su numero es el: " + decenasl + unidadesl);
                }
            }

        }
        static void Parte3_Ejercicio4()
        {
            /* Pedir al usuario que ingrese una letra cualquiera del abecedario y mostrar
           por consola si se trata de un vocal o una consonante. */
            Console.WriteLine("Digite cualquier letra del abecedario : ");
            string letra = Console.ReadLine();
            if (letra == "a" | letra == "e" | letra == "i" | letra == "o" | letra == "u")
            {
                Console.WriteLine(" la letra " + letra + " es una vocal");
            }
            else
            {
                Console.WriteLine("La letra " + letra + " es una consonante");

            }

            
        }
        static void Menu()
        {

            
                Console.WriteLine("--------------------Parte 3-----------------------");
                Console.WriteLine("Digite un numero segun lo que quiere: ");
                Console.WriteLine("1. Ejercicio 1");
                Console.WriteLine("2. Ejercicio 2");
                Console.WriteLine("3. Ejercicio 3");
                Console.WriteLine("4. Ejercicio 4");
                 int menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Parte3_Ejercicio1();

                        break;
                    case 2:
                        Parte3_Ejercicio2();

                        break;
                    case 3:
                        Parte3_Ejercicio3();

                        break;
                    case 4:
                        Parte3_Ejercicio4();

                        break;

                    default:
                        Console.WriteLine("Digite una opcion correcta");
                        break;

                        
                }

            
            



        }
    }
}
