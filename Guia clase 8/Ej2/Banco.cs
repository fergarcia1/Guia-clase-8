using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_clase_8
{
    class Banco
    {
        private string nombrePropietario;
        private CuentaCorriente cuenta;
        private CajaAhorro cajaAhorro;
        private SeguroDeHogar seguroH;
        private SeguroDeVida seguroV;

        public Banco()
        {

        }
        public Banco(string nombrePropietario,CuentaCorriente cuenta, CajaAhorro caja, SeguroDeHogar hogar, SeguroDeVida vida)
        {
            this.nombrePropietario = nombrePropietario;
            this.cuenta = cuenta;
            this.cajaAhorro = caja;
            this.seguroH = hogar;
            this.seguroV = vida;
        }

        public Banco ShallowCopy()
        {
            return (Banco)this.MemberwiseClone();
        }
        public Banco DeepCopy()
        {
            Banco clone = (Banco)this.MemberwiseClone();
            clone.cuenta = new CuentaCorriente(cuenta.cantidad);
            clone.cajaAhorro = new CajaAhorro(cajaAhorro.cantidad);
            clone.seguroH = new SeguroDeHogar(seguroH.valorSeguro, seguroH.pagoMensual);
            clone.seguroV = new SeguroDeVida(seguroV.valorSeguro, seguroV.pagoMensual);
            clone.nombrePropietario = nombrePropietario;
            return clone;
        }
    }
}
