﻿using System;

namespace Taller_ComplejidadCiclo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Ingrese el número a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número b: ");
            int b = int.Parse(Console.ReadLine());
            if (a>b)
            {
                Console.WriteLine("El número a: ", a, "es mayor que el número b: ", b);
            }
            else
            {
                if(a==b)
                {
                    Console.WriteLine("El número a: ", a, "es igual al número b: ", b);
                }
                else
                {
                    Console.WriteLine("El número a: ", a, "es menor que el número b: ", b);
                }
            }
        }
    }
}
