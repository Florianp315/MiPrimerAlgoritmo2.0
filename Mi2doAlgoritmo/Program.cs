using System;


namespace Mi2doAlgoritmo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un algoritmo que me pida 3 números por pantalla, con el primer número hallar el cuadrado, con el segundo número hallar la raíz cuadrada y con el tercer número hallar la raíz cúbica. Mostrar en pantalla los 3 resultados aritméticos.

            //Declaración de Variables

            double num1, num2, num3;
            double Cuadrado, RaizCuadrada, RaizCubica;
            string name;

            //Leer num1
            Console.Write("Ingresa el primer numero: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            //Leer num2
            Console.Write("Ingresa el Segundo numero ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            //Leer num3
            Console.Write("Ingresa el tercer numero ");
            num3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            //Realizar operaciones

            Cuadrado = Math.Pow(num1, 2);
            RaizCuadrada = Math.Sqrt(num2);
            RaizCubica = Math.Pow(num3, 1.0 / 3.0);


            //Imprimir en pantalla

            Console.WriteLine("El cuadrado del primer numero es: " + Cuadrado);
            Console.WriteLine("La Raiz Cuadrada del segundo numero es: " + RaizCuadrada);
            Console.WriteLine("La raiz Cubica del tercer numero es: " + RaizCubica);




        }
    }
}
