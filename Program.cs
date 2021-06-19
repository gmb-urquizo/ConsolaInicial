using System;

namespace MiPrimerConsola
{
    class Program
    {
        static void Main(string[] datosPersona)
        {
            Console.WriteLine("Escriba su nombre");
            var nombre = Console.ReadLine();

            Console.WriteLine("Escriba su apellido");
            var apellido = Console.ReadLine();

            Console.WriteLine("Escriba su peso");
            var peso = int.Parse(Console.ReadLine());

            // todo: Rebeca, debo leer 10 datos de una persona utilizando todos esos tipos
            //float 
            //double
            //DateTime
            //bool

            Console.WriteLine("Escriba su edad");
            var edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Escriba su nota");
            var nota = float.Parse(Console.ReadLine());

            var amigo = new Persona
            {
                Nombre = nombre,
                Apellido = apellido,
                Nota = nota,
                Peso = peso,
                Edad = edad
            };



            Console.WriteLine($"Hola {amigo.Nombre}");
            Console.WriteLine($"tu apellido es {amigo.Apellido}");
            Console.WriteLine("tu nota es  " + amigo.Nota);
            Console.WriteLine("tu peso es  " + amigo.Peso);
            Console.WriteLine("tu edad es " + amigo.Edad);

            Persona vecina = new("Cecilia", "Robayo");
            Console.WriteLine($"tu vecina se llama {vecina.NombreCompleto}");
            Console.WriteLine("Escriba cualquier cosa para terminar");
            Console.Read();
        }

        void Metodo()
        {
            /*if (args != null && args.Length > 0)
           {*/
        /*Console.WriteLine($"hay{args.Length} argumentos");*/
        /*Console.WriteLine($"tu nombre es { args[0]}");*/

        /* if (args.Length > 1)
             Console.WriteLine($"tu apellido  es  {args[1]}");*/
        /* }
         else
             Console.WriteLine("hola desconocido");*/
    }

    }
}
