using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_clase_8
{
    class Bank
    {
        private string nombrePropietario;
        private CuentaCorriente cuenta;
        private CajaAhorro cajaAhorro;
        private SeguroDeHogar seguroH;
        private SeguroDeVida seguroV;

        public string NombrePropietario { get => nombrePropietario; set => nombrePropietario = value; }
        internal CuentaCorriente Cuenta { get => cuenta; set => cuenta = value; }
        internal CajaAhorro CajaAhorro { get => cajaAhorro; set => cajaAhorro = value; }
        internal SeguroDeHogar SeguroH { get => seguroH; set => seguroH = value; }
        internal SeguroDeVida SeguroV { get => seguroV; set => seguroV = value; }

        public Bank()
        {

        }
        public Bank(string nombrePropietario,CuentaCorriente cuenta, CajaAhorro caja, SeguroDeHogar hogar, SeguroDeVida vida)
        {
            this.NombrePropietario = nombrePropietario;
            this.Cuenta = cuenta;
            this.CajaAhorro = caja;
            this.SeguroH = hogar;
            this.SeguroV = vida;
        }

        public Bank ShallowCopy()
        {
            return (Bank)this.MemberwiseClone();
        }
        public Bank DeepCopy()
        {
            Bank clone = (Bank)this.MemberwiseClone();
            clone.Cuenta = new CuentaCorriente(Cuenta.cantidad);
            clone.CajaAhorro = new CajaAhorro(CajaAhorro.cantidad);
            clone.SeguroH = new SeguroDeHogar(SeguroH.valorSeguro, SeguroH.pagoMensual);
            clone.SeguroV = new SeguroDeVida(SeguroV.valorSeguro, SeguroV.pagoMensual);
            clone.NombrePropietario = NombrePropietario;
            return clone;
        }
    }
}
