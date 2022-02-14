using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Para digitar todo en un menu puedes escribir el metodo Menu();
            //pero tambien puedes escribir el metodo de cada ejercicio ejemplo : Ejercicio1();


            Menu();
        }






//1. Leer el numero e imprimir en caso de que sea par
static void Ejercicio1()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Escriba un numero");
            long numero = Convert.ToInt64(Console.ReadLine());
            long sobrante = numero % 2;
            if (sobrante == 0)
            {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }
        }
        //2. Elabore un algoritmo que lea un número y si este es mayor o igual a 10 devuelva el triple de este.
        static void Ejercicio2()
        {
            Console.WriteLine("Escriba un numero");
            int numero = int.Parse(Console.ReadLine());
            if (numero >= 10)
            {
                double triple = numero * 3;
                Console.WriteLine("Su numero se ha triplicado a " + triple);
            }
            else
            {
                Console.WriteLine("Su numero no es mayor o igual a 10");
            }
        }
        static void Ejercicio3()
        {
            /* 3.Un proveedor de computadores ofrece descuento del 10%, si cuesta $1.000.000 o más. 
             * Determinar cuánto pagará, con IVA incluido (19%), un cliente si la compra cumple con esta condición. */
            Console.WriteLine("Escriba el valor de su computador");
            float valor = float.Parse(Console.ReadLine());
            if (valor >= 1000000)
            {
                Console.WriteLine("Se le ha descontado 10%");
                double descuento = valor * 0.10;
                double valor_iva = valor * 0.19;
                double valor_subtotal = valor - descuento;
                double valor_total = valor_subtotal - valor_iva;
                Console.WriteLine("Total a pagar con IVA y descuento: " + valor_total + "\nIVA: " + valor_iva);

            }
            else
            {
                Console.WriteLine("No se le realiza descuento");
                double valor_iva = valor * 0.19;
                double valor_total = valor - valor_iva;
                Console.WriteLine("Total a pagar con IVA: " + valor_total + "\nIVA: " + valor_iva);
            }

        }
        static void Ejercicio4()
        {
            /*4.Realizar un algoritmo que lea dos números e imprima la suma de los 2,
             * en caso que el primero sea mayor al segundo*/
            Console.WriteLine("Digite el PRIMER numero: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el SEGUNDO numero");
            int numero2 = int.Parse(Console.ReadLine());
            if (numero1 > numero2)
            {
                Console.WriteLine("Se han sumado los numeros\nEl resultado es: " + (numero1 + numero2));
            }
            else
            {
                Console.WriteLine("No se han sumado los numeros");
            }

        }
        static void Ejercicio5()
        {
            /* En un almacén se hace un 20% de descuento a los clientes cuya compra sea superior a $100.000. 
             * ¿Cuánto deberá pagar cada cliente?
            */
            Console.WriteLine("Digite su nombre");
            String nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre + " Digite el valor de su compra: ");
            float compra = float.Parse(Console.ReadLine());
            if (compra >= 100000)
            {
                Console.WriteLine("Tienes un descuento de 20%");
                double descuento = compra * 0.2;
                Console.WriteLine(nombre + " El valor total de la compra es: " + (compra - descuento));
                Console.WriteLine("Se le descontó: " + descuento);
            }
            else
            {
                Console.WriteLine("No tienes descuento");
                Console.WriteLine("Valor a pagar: " + compra);
            }
        }
        static void Ejercicio6()
        {
            /* Calcular el salario de un empleado, teniendo en cuenta que si el salario bruto es superior
             * a $2.000.000, debe hacerse una retención del 10%.
         */
            Console.WriteLine("Digite su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("¡Hola! " + nombre + ", Por Favor Ingrese su salario bruto");
            float salario = float.Parse(Console.ReadLine());
            if (salario > 2000000)
            {
                Console.WriteLine(nombre + " Se le ha retenido el 10% de su salario");
                double porciento_salario_retenido = salario * 0.1;
                Console.WriteLine("Total de salario bruto con retencion del 10%: " + (salario - porciento_salario_retenido));
                Console.WriteLine("Total Retenido: " + porciento_salario_retenido);
            }
            else
            {
                Console.WriteLine(nombre + "  No se le ha retenido ningun por ciento de su salario");
                Console.WriteLine("Su Salario total es: " + salario);
            }
        }

        static void Ejercicio7()
        {
            // 7. Leer un número e imprimir un mensaje en caso que sea negativo.
            Console.WriteLine("Digite cualquier numero");
            int numero = int.Parse(Console.ReadLine());
            if (numero < 0)
            {
                Console.WriteLine("Su numero es negativo");
            }
            else
            {
                Console.WriteLine("Su numero es positivo");
            }

        }
        static void Ejercicio8()
        {
            /*8. Un hombre desea saber cuánto dinero se genera por concepto de intereses sobre la cantidad que tiene en inversión en el banco. 
             * El decidirá reinvertir los intereses siempre y cuando no excedan a $7000,
             * y en ese caso desea saber cuánto dinero tendrá finalmente en su cuenta.*/
            Console.WriteLine("Digite su nombre");
            String nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre + " Por favor digite la cantidad invertida");
            float cantidad_invertida = float.Parse(Console.ReadLine());
            Console.WriteLine(nombre + "Digite la tasa de interes");
            float tasa_interes = float.Parse(Console.ReadLine());
            double intereses = (cantidad_invertida / 100) * tasa_interes;
            if (intereses > 7000)
            {
                Console.WriteLine("los intereses son : " + intereses + " han excedido a $7000");
            }
            else
            {
                Console.WriteLine("Los intereses son: " + intereses + " no han excedido a $7000");
            }
            Console.WriteLine(nombre + " la cantidad de dinero final en su cuenta : " + (cantidad_invertida + intereses));

        }
        static void Ejercicio9()
        {
            /*9. Leer un número e imprimir un mensaje en caso que sea múltiplo de 5. */
            Console.WriteLine("Digite un numero");
            int numero = int.Parse(Console.ReadLine());
            if (numero % 5 == 0)
            {
                Console.WriteLine("El " + numero + " es multiplo de 5");
            }
            else
            {
                Console.WriteLine("El " + numero + " no es multiplo de 5");
            }


        }
        static void Ejercicio10()
        {
            /* 10. Leer la edad de una persona e imprimir un mensaje en caso que sea mayor de edad. */
            Console.WriteLine("Digita tu edad");
            int edad = int.Parse(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad");

            }
            else
            {
                Console.WriteLine("No eres mayor de edad");
            }
        }
        static void Ejercicio11()
        { /* 11.Leer 4 notas, calcular el promedio e imprimir un mensaje indicando que reprobó en caso que la nota sea menor a 3.5
  */
            Console.WriteLine("------PROMEDIO------");
            Console.WriteLine("DIGITAR CON COMAS Y NO CON PUNTOS");
            Console.WriteLine("Digite la primera nota");
            float nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la segunda nota");
            float nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la tercera nota");
            float nota3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la cuarta nota");
            float nota4 = float.Parse(Console.ReadLine());
            double promedio = (nota1 + nota2 + nota3 + nota4) / 4;
            if (promedio >= 3.5)
            {
                Console.WriteLine("FELICIDADES has aprobado la materia en: " + promedio);
            }
            else
            {
                Console.WriteLine("Has reprobado la materia con: " + promedio);
            }
        }
        static void Ejercicio12()
        {
            /* 12.Hacer un algoritmo que lea la estatura de una persona y si es mayor de 1.70, imprima que es alta
            */
            Console.WriteLine("Digita tu estatura");
            Console.WriteLine("DIGITAR CON COMAS Y NO CON PUNTOS");
            float estatura = float.Parse(Console.ReadLine());
            if (estatura > 1.70)
            {
                Console.WriteLine("Eres una persona alta");
            }
            else if (estatura > 1.60)
            {
                Console.WriteLine("Eres una persona de estatura promedio");
            }
            else
            {
                Console.WriteLine("Eres una persona de estatura Baja");
            }
        }
        static void Ejercicio13()
        {
            /* 13.Un proveedor de computadores ofrece descuento del 10%, si cuesta $1.000.000 o más. Determinar cuánto pagará, 
             * con IVA incluido (19%), un cliente cualquiera por la compra de una computadora.
         */
            Console.WriteLine("Digite el valor de la computadora");
            float valor_computadora = float.Parse(Console.ReadLine());
            if (valor_computadora >= 1000000)
            {
                Console.WriteLine("Has recibido un descuento del 10% ");
                double valor = valor_computadora * 0.1;
                double total_porciento = valor_computadora - valor;
                double valor_iva = total_porciento * 0.19;
                double total = total_porciento + valor_iva;

                Console.WriteLine("El valor total a pagar con descuento e IVA es: " + total);
                Console.WriteLine("Valor IVA: " + valor_iva);
                Console.WriteLine("Se le desconto: " + valor);

            }
            else
            {
                double valor_iva = valor_computadora * 0.19;
                Console.WriteLine("El valor total a pagar con  IVA es: " + (valor_computadora + valor_iva));
                Console.WriteLine("Valor IVA: " + valor_iva);
            }

        }
        static void Ejercicio14()
        {
            /*14. Realizar un algoritmo que lea dos números e imprima la suma de los 2, en caso que el primero sea mayor al segundo.
         */
            Console.WriteLine("Digite el PRIMER numero: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el SEGUNDO numero");
            int numero2 = int.Parse(Console.ReadLine());
            if (numero1 > numero2)
            {
                double suma = numero1 + numero2;
                Console.WriteLine("La suma de los dos numeros es: " + suma);
            }
            else
            {
                Console.WriteLine("No se realizara la suma");
            }
        }
        static void Ejercicio15()
        {
            /* 15.Realizar un algoritmo que lea un número y si éste es superior o igual a 10, permita imprimir su cubo. */
            Console.WriteLine("Digite un Numero: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero >= 10)
            {
                Console.WriteLine("EL cubo del numero: " + numero + " es: " + (numero * numero * numero));
            }
            else
            {
                Console.WriteLine("No se imprimira el cubo :)");
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
            Console.WriteLine("5. Ejercicio 5");
            Console.WriteLine("6. Ejercicio 6");
            Console.WriteLine("7. Ejercicio 7");
            Console.WriteLine("8. Ejercicio 8");
            Console.WriteLine("9. Ejercicio 9");
            Console.WriteLine("10. Ejercicio 10");
            Console.WriteLine("11. Ejercicio 11");
            Console.WriteLine("12. Ejercicio 12");
            Console.WriteLine("13. Ejercicio 13");
            Console.WriteLine("14. Ejercicio 14");
            Console.WriteLine("15. Ejercicio 15");
            int menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    Ejercicio1();

                    break;
                case 2:
                    Ejercicio2();

                    break;
                case 3:
                    Ejercicio3();


                    break;
                case 4:
                    Ejercicio4();


                    break;
                case 5:
                    Ejercicio5();

                    break;
                case 6:
                    Ejercicio6();

                    break;
                case 7:
                    Ejercicio7();

                    break;
                case 8:
                    Ejercicio8();

                    break;
                case 9:
                    Ejercicio9();

                    break;
                case 10:
                    Ejercicio10();

                    break;
                case 11:
                    Ejercicio11();

                    break;
                case 12:
                    Ejercicio12();

                    break;
                case 13:
                    Ejercicio13();

                    break;
                case 14:
                    Ejercicio14();

                    break;
                case 15:
                    Ejercicio15();

                    break;

                default:
                    Console.WriteLine("Digite una opcion correcta");
                    break;


            }






        }
    }
}
