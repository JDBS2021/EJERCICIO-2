using System;

namespace EJERCICIO2
{
    class Program
    {
        static void Main(string[] args)
        {
            Char Sexo;
            String NombrePersona;
            int Edad = 0;
            int PulsacionesHombre;
            int PulsacionesMujeres;

            Console.Write("digite el nombre de la persona:  ");
            NombrePersona = (Console.ReadLine());
            Console.Write("digite la edad de la persona:  ");
            Edad = Convert.ToInt32(Console.ReadLine());
            Console.Write("digite el sexo de la persona: (F O M)  ");
            Sexo = Convert.ToChar(Console.ReadLine());

            PulsacionesHombre = (210 - Edad) / 10;
            PulsacionesMujeres = (220 - Edad) / 10;


            Console.WriteLine("EL NOMBRE DE LA PERSONA  ES: " + NombrePersona);
            Console.WriteLine("LA EDAD DE LA PERSONA  ES: " + Edad);

            if (Sexo == 'F')
            {
                Console.Write("LAS PULSACIONES DE UNA MUJER CADA 10 SEGUNDOS ES: " + PulsacionesMujeres+"BMP"); 

            }
            if(Sexo == 'M')
            {
                Console.Write("LAS PULSACIONES DE UN HOMBRE CADA 10 SEGUNDOS ES: " + PulsacionesHombre+"BMP");

            }

            Console.ReadKey();
        }
    }
}
