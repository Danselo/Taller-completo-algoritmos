using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Para digitar todo en un menu puedes escribir el metodo Menu();
            //pero tambien puedes escribir el metodo de cada ejercicio ejemplo : Parte2_Ejercicio1();


            Menu();



        }
        static void Parte2_Ejercicio1()
        {
            /* 1. Hacer un algoritmo que imprima el nombre de un artículo, clave, precio original y su precio con descuento. 
             * El descuento lo hace en base a la clave, si la clave es 01 el descuento es del 10% y si la clave es 02 el descuento es del 20% 
             * (solo existen dos claves).
         */
            Console.WriteLine("Digite el nombre de el articulo ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Digite la clave del articulo (" + nombre + ")");
            Console.WriteLine("Claves: 01 , 02");
            decimal clave_articulo = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite el precio de " + nombre);
            float precio_original = float.Parse(Console.ReadLine());
            Console.Clear();
            if (clave_articulo == 01)
            {
                Console.WriteLine("Has obtenido un descuento del 10%");
                double descuento = precio_original * 0.1;
                Console.WriteLine("Nombre Articulo: " + nombre);
                Console.WriteLine("Clave: " + clave_articulo);
                Console.WriteLine("El precio original es: " + precio_original);
                Console.WriteLine("El precio con descuento es: " + (precio_original - descuento));

            }
            else if (clave_articulo == 02)
            {

                Console.WriteLine("Has obtenido un descuento del 20%");
                double descuento = precio_original * 0.2;
                Console.WriteLine("Nombre Articulo: " + nombre);
                Console.WriteLine("Clave: " + clave_articulo);
                Console.WriteLine("El precio original es: " + precio_original);
                Console.WriteLine("El precio con descuento es: " + (precio_original - descuento));
            }
            else
            {
                Console.WriteLine("Digite una clave valida");
                Console.WriteLine("Ejemplo: 01,02");
            }
        }
        static void Parte2_Ejercicio2()
        {
            /* 2.Hacer un algoritmo que calcule el total a pagar por la compra de camisas.
             * Si se compran tres camisas o más se aplica un descuento del 20% sobre el total de la compra
             * y si son menos de tres camisas un descuento del 10%
         */
            Console.WriteLine("Digite el precio de una camisa");
            float precio = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite cuantas camisas desea comprar: ");
            int cantidad_camisas = int.Parse(Console.ReadLine());
            double subtotal = precio * cantidad_camisas;
            if (cantidad_camisas >= 3)
            {
                Console.WriteLine("Se le ha aplicado un descuento del 20%");
                double descuento = precio * 0.2;
                Console.WriteLine("Total a pagar por " + cantidad_camisas + " Camisas: " + (subtotal - descuento));
                Console.WriteLine("Valor descontado: " + descuento);
            }
            else
            {
                Console.WriteLine("Se le ha aplicado un descuento del 10%");
                double descuento = precio * 0.1;
                Console.WriteLine("Total a pagar por " + cantidad_camisas + " Camisas: " + (subtotal - descuento));
                Console.WriteLine("Valor descontado: " + descuento);
            }
        }
        static void Parte2_Ejercicio3()
        {
            /* 3.  Elabore un algoritmo que lea un número y si este es mayor o igual a 10
                devuelva el triple de este de lo contrario la cuarta parte de este. */
            Console.WriteLine("Digite un numero: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero >= 10)
            {
                Console.WriteLine("El triple del numero " + numero + " es: " + (numero * 3));
            }
            else
            {

                Console.WriteLine("la cuarta parte del numero " + numero + " es: " + (numero / 4));
            }

        }
        static void Parte2_Ejercicio4()
        {
            //4.Hacer un algoritmo que lea dos números y los imprima en orden ascendente.
            Console.WriteLine("Digite el primer numero");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el Segundo numero");
            int numero2 = int.Parse(Console.ReadLine());
            if (numero1 > numero2)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine(numero2);
                Console.WriteLine(numero1);
            }
            else
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine(numero1);
                Console.WriteLine(numero2);
            }
        }
        static void Parte2_Ejercicio5()
        {
            /*5. Determinar el precio de un pasaje de ida y vuelta por avión, conociendo la
            distancia a recorrer y sabiendo que que esta es superior a 1.000 km, 
            la línea aérea le hace un descuento del 30%. El precio por kilómetro es de $150.*/
            Console.WriteLine("Digite la distancia de ida y regreso en kilometros: ");
            float distancia = float.Parse(Console.ReadLine());
            double precio_total = 150 * distancia;
            if (distancia > 1000)
            {
                Console.WriteLine("Se le ha hecho un descuento del 30%");
                double descuento = precio_total * 0.3;
                Console.WriteLine("Precio del pasaje de ida y vuelta: " + (precio_total - descuento));
                Console.WriteLine("Valor descontado: " + descuento);
            }
            else
            {
                Console.WriteLine("Precio del pasaje de ida y vuelta: " + precio_total);
            }

        }
        static void Parte2_Ejercicio6()
        {
            /* 6. Calcular e imprimir el salario de un empleado, teniendo en cuenta que si el
            salario bruto es igual o superior a $2.000.000, debe hacerse una retención del
            10%, si el salario es inferior, la retención será del 3%.  */
            Console.WriteLine("Digite su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("¡Hola! " + nombre + ", Por Favor Ingrese su salario bruto");
            float salario = float.Parse(Console.ReadLine());
            if (salario >= 2000000)
            {
                Console.WriteLine(nombre + " Se le ha retenido el 10% de su salario");
                double porciento_salario_retenido = salario * 0.10;
                Console.WriteLine("Total de salario bruto con retencion del 10%: " + (salario - porciento_salario_retenido));
                Console.WriteLine("Total Retenido: " + porciento_salario_retenido);
            }
            else
            {
                double salario_retenido = salario * 0.03;
                Console.WriteLine(nombre + "  Se le ha retenido el 3% de su salario");
                Console.WriteLine("Su Salario total es: " + (salario - salario_retenido));
                Console.WriteLine("Total Retenido: " + salario_retenido);
            }

        }
        static void Parte2_Ejercicio7()
        {
            //7.Leer un número e imprimir un mensaje si es par o impar.
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
        static void Parte2_Ejercicio8()
        {
            /*8. Elaborar un algoritmo que permita calcular el número de pulsaciones que debe
            tener una persona por cada 10 segundos de ejercicio aeróbico; la fórmula que
            se aplica cuando el sexo es femenino, es:
            numpulsaciones = (220-edad)/10
            y si el sexo es masculino:
            numpulsaciones = (210-edad)/10 */
            Console.WriteLine("Digite su edad:");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite su genero");
            Console.WriteLine("1.Femenino");
            Console.WriteLine("2.Masculino");
            int genero = int.Parse(Console.ReadLine());
            if (genero == 1)
            {
                double numero_pulsaciones = (220 - edad) / 10;
                Console.WriteLine("El numero de pulsaciones que debes tener cada 10 seg de ejercicio aerobico es: ");
                Console.WriteLine(numero_pulsaciones);
                Console.WriteLine("-------------------------------");
            }
            else if (genero == 2)
            {
                double numero_pulsaciones = (210 - edad) / 10;
                Console.WriteLine("El numero de pulsaciones que debes tener cada 10 seg de ejercicio aerobico es: ");
                Console.WriteLine(numero_pulsaciones);
                Console.WriteLine("-------------------------------");
            }
            else
            {
                Console.WriteLine("Ha dijitado un genero invalido");
            }
        }
        static void Parte2_Ejercicio9()
        {
            /* 9. Un obrero necesita calcular su salario semanal, el cual se obtiene de la
            siguiente manera:
            Si trabaja 40 horas o menos, se le paga a $10.000 la hora
            Si trabaja más de 40 horas, se le paga $10.000 por cada una de las primeras
            40 horas y $15.000 por cada una de las horas extras. */
            Console.WriteLine("Hola señor obrero digite Por favor cuantas horas trabajo en la semana: ");
            int horas = int.Parse(Console.ReadLine());
            if (horas <= 40)
            {
                double pago = 10000 * horas;
                Console.WriteLine("Su salario semanal es: " + pago);
            }
            else if (horas > 40)
            {
                double pago_extra = (horas - 40);
                double pago_total = (40 * 10000) + (pago_extra * 15000);
                Console.WriteLine("su salario semanal es: " + pago_total);

            }
        }
        static void Parte2_Ejercicio10()
        {
            /* 10. Una persona enferma y cuyo peso es 70 kg, se encuentra en reposo y desea
            saber cuántas calorías consume su cuerpo durante el tiempo que realice una
            misma actividad. Las actividades que puede realizar son únicamente dormir o
            estar sentado. Los datos que tiene son que estando dormido consume 1.08
            calorías por minuto y estando sentado en reposo consume 1.66 calorías por
            minuto.  */
            Console.WriteLine("Contar calorias:");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Cuantos minutos duerme: ");
            int minutos_dormido = int.Parse(Console.ReadLine());
            Console.WriteLine("Cuantos minutos pasa entado en reposo: ");
            int minutos_sentado = int.Parse(Console.ReadLine());
            double calorias_sentado = 1.66 * minutos_sentado;
            double calorias_dormido = 1.08 * minutos_sentado;
            Console.WriteLine("Calorias consumidas por estar sentado: " + calorias_sentado);
            Console.WriteLine("Calorias consumidas por estar dormido: " + calorias_dormido);
            Console.WriteLine("Total de calorias: " + (calorias_sentado + calorias_dormido));
        }
        static void Parte2_Ejercicio11()
        {
            /*  11. Una empresa desea hacer una compra de varias piezas de la misma clase a
        una fábrica. La empresa, dependiendo del valor de la compra, decidirá la
        forma en que le pagará al fabricante. Si el valor de la compra excede o es
        igual a $5.000.000, la empresa tendrá la capacidad de pagar con recursos
        propios el 55% del valor de la compra, pedirá prestado a un banco el 30% y el
        resto lo pagará solicitando un crédito al fabricante. Si el monto total de la
        compra no excede de $5.000.000, la empresa tendrá la capacidad de pagar
        con recursos propios un 70% y el 30% restante, lo pagará solicitando un
        crédito al fabricante. El fabricante cobra un 15% de interés sobre la cantidad
        que le pague a crédito. */
            Console.WriteLine("Digite el valor de la compra: ");
            float valor_compra = float.Parse(Console.ReadLine());
            if (valor_compra < 0)
            {
                Console.WriteLine("Digite un valor valido");
            }
            else if (valor_compra >= 5000000)
            {
                double parte_empresa = valor_compra * 0.55;
                double prestamo = valor_compra * 0.3;
                double credito = (valor_compra - parte_empresa) - prestamo;
                double intereses = credito * 0.15;
                Console.WriteLine("La empresa debe pagar: " + parte_empresa);
                Console.WriteLine("El prestamo del banco es: " + prestamo);
                Console.WriteLine("Credito del fabricante: " + credito);
                Console.WriteLine("Intereses: " + intereses);
                Console.WriteLine("---------------------");
            }
            else if (valor_compra < 5000000)
            {
                double parte_empresa = valor_compra * 0.7;
                double credito = valor_compra - parte_empresa;
                double intereses = credito * 0.15;
                Console.WriteLine("La empresa debe pagar: " + parte_empresa);
                Console.WriteLine("Credito de fabricante : " + credito);
                Console.WriteLine("Intereses: " + intereses);
                Console.WriteLine("---------------------");
            }
            else if (valor_compra < 0)
            {
                Console.WriteLine("Digite un valor valido");
            }


        }
        static void Parte2_Ejercicio12()
        {
            /* 12. Elaborar un algoritmo que permita calcular el valor total a pagar en una
            papelería teniendo en cuenta que, si lleva 5 cuadernos o más, se le cobrarán
            $2.000 por cada uno, mientras que, si lleva menos, se le cobrarán $2.500 por
            cada uno. */
            Console.WriteLine("Digite cuantos cuadernos desea llevar");
            int cuadernos = int.Parse(Console.ReadLine());
            if (cuadernos >= 5)
            {
                double total = 2000 * cuadernos;
                Console.WriteLine("Total a pagar por " + cuadernos + " cuadernos: " + total);
            }
            else if (cuadernos < 0)
            {
                Console.WriteLine("Digite un valor valido");
            }
            else
            {
                double total = 2500 * cuadernos;
                Console.WriteLine("Total a pagar por " + cuadernos + " cuadernos: " + total);

            }
        }
        static void Parte2_Ejercicio13()
        {
            /* 13. Una constructora ofrece vivienda de interés social, bajo las siguientes
            condiciones: Si los ingresos del comprador son iguales o superiores a
            $1.200.000, la cuota inicial será del 15% del valor de la vivienda y el resto, se
            distribuirá en 120 cuotas mensuales con un interés del 2% mensual. Si los
            ingresos del comprador son inferiores a $1.200.000, la cuota inicial será del
            30% del valor de la vivienda y el resto, lo distribuirá en 84 cuotas mensuales
            con un interés del 1% mensual. La constructora desea saber cuánto debe
            pagar un comprador por concepto de cuota inicial y cuánto por cada cuota
            mensual.*/
            Console.WriteLine("Digite el valor de la vivienda: ");
            float vivienda = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite el ingreso del comprador: ");
            float ingresos_comprador = float.Parse(Console.ReadLine());
            if (ingresos_comprador >= 1200000)
            {
                double cuota_inicial = vivienda * 0.15;
                double cuota_mensual = (vivienda - cuota_inicial) / 120;
                double intereses = cuota_mensual * 0.02;
                //valor redondeado
                double total_pagar = cuota_mensual + intereses;
                int total_redondeado = (int)Math.Round(total_pagar);
                Console.WriteLine("El Comprador debe pagar : " + cuota_inicial + " por cuota inicial");
                Console.WriteLine("Intereses mensuales: 1% ");
                Console.WriteLine("El Comprador debe pagar : " + (total_redondeado) + " por cada cuota mensual mas intereses");
            }
            else if (vivienda < 0)
            {
                Console.WriteLine("Digite un valor valido");
            }
            else
            {
                double cuota_inicial = vivienda * 0.30;
                double cuota_mensual = (vivienda - cuota_inicial) / 84;
                double intereses = cuota_mensual * 0.01;
                double total_pagar = cuota_mensual + intereses;
                //valor redondeado
                int total_redondeado = (int)Math.Round(total_pagar);

                Console.WriteLine("El Comprador debe pagar : " + cuota_inicial + " por cuota inicial");
                Console.WriteLine("Intereses mensuales: 1% ");
                Console.WriteLine("El Comprador debe pagar : " + (total_redondeado) + " por cada cuota mensual mas intereses");
            }
        }
        static void Parte2_Ejercicio14()
        {
            /* 14. Elaborar un algoritmo que lea un número, si es par, que imprima el cubo y si
            es impar, que imprima el triple. */
            Console.WriteLine("Digite un numero :");
            int numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.WriteLine("El numero es par");
                Console.WriteLine("El cubo del numero " + numero + " es: " + (numero * numero * numero));
            }
            else
            {
                Console.WriteLine("El numero es impar");
                Console.WriteLine("El triple del numero " + numero + " es: " + (numero * 3));
            }
        }
        static void Parte2_Ejercicio15()
        {
            /*  15. En un almacén se hace un 17% de descuento a los clientes cuya compra sea
        superior a $200.000, para las compras inferiores, el descuento será del 5%.
        ¿Cuánto deberá pagar cada cliente? */
            Console.WriteLine("Digite su nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Digite el valor de su compra: ");
            float compra = float.Parse(Console.ReadLine());
            if (compra > 200000)
            {
                Console.WriteLine("El almacen le ha dado un 17% de descuento por su compra");
                double descuento = compra * 0.17;
                Console.WriteLine("Valor a pagar: " + (compra - descuento));

            }
            else if (compra < 0)
            {
                Console.WriteLine("Digite un valor valido ");
            }
            else
            {
                Console.WriteLine("El almacen le ha dado 5% de descuento");
                double descuento = compra * 0.05;
                Console.WriteLine("Valor a pagar: " + (compra - descuento));
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
                    Parte2_Ejercicio1();

                    break;
                case 2:

                    Parte2_Ejercicio2();
                    break;
                case 3:
                    Parte2_Ejercicio3();

                    break;
                case 4:
                    Parte2_Ejercicio4();

                    break;
                case 5:
                    Parte2_Ejercicio5();
                    break;
                case 6:
                    Parte2_Ejercicio6();
                    break;
                case 7:
                    Parte2_Ejercicio7();
                    break;
                case 8:
                    Parte2_Ejercicio8();
                    break;
                case 9:
                    Parte2_Ejercicio9();
                    break;
                case 10:
                    Parte2_Ejercicio10();
                    break;
                case 11:
                    Parte2_Ejercicio11();
                    break;
                case 12:
                    Parte2_Ejercicio12();
                    break;
                case 13:
                    Parte2_Ejercicio13();
                    break;
                case 14:
                    Parte2_Ejercicio14();
                    break;
                case 15:
                    Parte2_Ejercicio15();
                    break;

                default:
                    Console.WriteLine("Digite una opcion correcta");
                    break;


            }






        }
    }
}
