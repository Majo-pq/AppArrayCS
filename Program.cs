using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppArrayCS
{
    class Program
    {
        static void Main(string[] args)

        {
            Celular[] a = new Celular[5];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = new Celular();
                Console.WriteLine("Marca del celular");
                a[i].Marca = "";
                a[i].Marca = Console.ReadLine();
                Console.WriteLine("Color del celular");
                a[i].Color = "";
                a[i].Color = Console.ReadLine();
                Console.WriteLine("Capacidad de Almacenamiento");
                a[i].CapacidadAlmacenamiento = "";
                a[i].CapacidadAlmacenamiento = Console.ReadLine();
                
            }

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i].ToString());
            }   
            Console.ReadKey();

        
        }
    }
}
