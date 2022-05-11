using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_clase_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator creator = new Creator();
            Creator.CreateConection(1).GetConnection();
            Creator.CreateConection(2).GetConnection();
            Creator.CreateConection(3).GetConnection();
            Console.ReadKey();

            CuentaCorriente corriente = new CuentaCorriente(5000.2);
            CajaAhorro caja = new CajaAhorro(0);
            SeguroDeHogar hogar = new SeguroDeHogar(0,0);
            SeguroDeVida vida = new SeguroDeVida(0, 0);
            string nombre = "pepe";

            Bank banquito = new Bank(nombre, corriente, caja, hogar, vida);
            Bank banquito02 = banquito.ShallowCopy();

            Console.WriteLine("Nombre: " + banquito02.NombrePropietario);
            Console.WriteLine("Cuenta: " + banquito02.Cuenta.cantidad);
            Console.ReadKey();
        }
  
    }
}
