using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Trabajadores 
{
    class Program : Persona
    {
      public void Datos()
        {
            Console.WriteLine("Ingrese Nombre:");
            Nombre = Console.ReadLine();
            string linea;
            Console.WriteLine("Ingrese Edad:");
            linea = Console.ReadLine();
            Edad = int.Parse(linea);
            Console.WriteLine("Ingrese Salario:");
            linea = Console.ReadLine();
            Salario = int.Parse(linea);
        }
        public void Muestra()
        {
            Console.Write("Nombre:");
            Console.WriteLine(Nombre);
            Console.Write("Salario Total:");
            Console.WriteLine(Salario2);
        }
         public void Compara()
        {
            if (Salario > 10000)
            {
                Salario2 = (Salario*0.20) -Salario;
            }
            else
            {
                Salario2 = (Salario * 0.16) - Salario;
            }
            Console.ReadKey();
        }
  
        static void Main(string[] args)
        {
            Persona Per1 = new Persona();
            

        }
    }
}
