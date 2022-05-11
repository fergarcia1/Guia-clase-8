using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_clase_8
{
    interface Servicios
    {
        void Baja();
    }
    class CuentaCorriente : Servicios
    {
        public double cantidad;

        public CuentaCorriente(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public double Cantidad { get => cantidad; set => cantidad = value; }

        public void Depositar(double cantidad)
        {
            this.Cantidad += cantidad;
        }
        public void Retirar(double cantidad)
        {
            this.Cantidad -= cantidad;
        }
        public void Baja()
        {
            Console.WriteLine("Se cancela el servicio, por favor retire su dinero");
        }
    }
    class CajaAhorro : Servicios
    {
        public double cantidad;

        public CajaAhorro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public double Cantidad { get => cantidad; set => cantidad = value; }

        public void Depositar(double cantidad)
        {
            this.Cantidad += cantidad;
        }
        public void Retirar(double cantidad)
        {
            this.Cantidad -= cantidad;
        }
        public void Baja()
        {
            Console.WriteLine("Se cancela el servicio, por favor retire su dinero");
        }
    }
    class SeguroDeVida : Servicios
    {
        public int valorSeguro;
        public int pagoMensual;

        public SeguroDeVida(int valorSeguro, int pagoMensual)
        {
            this.valorSeguro = valorSeguro;
            this.pagoMensual = pagoMensual;
        }

        public int ValorSeguro { get => valorSeguro; set => valorSeguro = value; }
        public int PagoMensual { get => pagoMensual; set => pagoMensual = value; }

        public void Baja()
        {
            Console.WriteLine("Se cancela el servicio");
        }
    }
    class SeguroDeHogar : Servicios
    {
        public int valorSeguro;
        public int pagoMensual;

        public SeguroDeHogar(int valorSeguro, int pagoMensual)
        {
            this.valorSeguro = valorSeguro;
            this.pagoMensual = pagoMensual;
        }

        public int ValorSeguro { get => valorSeguro; set => valorSeguro = value; }
        public int PagoMensual { get => pagoMensual; set => pagoMensual = value; }

        public void Baja()
        {
            Console.WriteLine("Se cancela el servicio");
        }
    }
}
