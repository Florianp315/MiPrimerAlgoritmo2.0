using System;

namespace MiPrimerAlgoritmo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Ingresar por pantalla 2 números y calcular las 4 operaciones aritméticas con dichos números. Mostrar en pantalla un mensaje de advertencia que indique que el segundo número debe ser diferente de 0. Imprimir en pantalla el resultado de cada operación.

            //Declaracion de Variables
            double num1, num2;
            double sum, rest, prod, coc;
            string name;

            //Leer num1
            Console.Write("Ingrese el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine()); // Todo lo que Ingrese En esta linea, sera Tomado como un STRING
            Console.WriteLine(" ");

            //Leer num2
            
            Console.Write("Ingrese el segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");


            //Hacer Los calculos
            
            sum = num1 + num2;
            rest = num1 - num2;
            prod = num1 * num2;
            coc = num1 / num2;


            //Imprimir en pantalla
            Console.WriteLine("La suma entre " + num1 + " + " + num2 + " es: " + sum);
            Console.WriteLine("La resta entre " + num1 + " - " + num2 + " es: " + rest);
            Console.WriteLine("La multiplicacion entre " + num1 + " x " + num2 + " es: " + prod);
            Console.WriteLine("La division entre " + num1 + " / " + num2 + " es: " + coc);





        }

    }
}
