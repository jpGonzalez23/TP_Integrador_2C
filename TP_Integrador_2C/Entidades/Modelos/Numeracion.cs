using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Numeracion
    {
        public enum ESistema
        {
            Binario,
            Decimal
        };

        private ESistema sistema;
        private double valorNumerico;

        public Numeracion(double valor, ESistema sistema)
        {
            Numeracion.InicializarValores();
        }

        public Numeracion(string valor, ESistema sistema)
        {
            Numeracion.InicializarValores(valor, sistema);
        }

        private static void InicializarValores(string valor, ESistema sistema)
        {

        }

        public ESistema Sistema
        {
            get
            {
                return this.sistema;
            }
        }

        //public string Valor
        //{
        //    get
        //    {

        //    }
        //}

        //public static string ConvertirA(ESistema sistema)
        //{

        //}


        public static bool operator ==(Numeracion numeroUno, Numeracion numeroDos)
        {
            return numeroUno.valorNumerico == numeroDos.valorNumerico;
        }

        public static bool operator !=(Numeracion numeroUno, Numeracion numeroDos)
        {
            return !(numeroUno == numeroDos);
        }

        public static bool operator ==(ESistema sistema, Numeracion numeracion)
        {

        }

        public static bool operator !=(ESistema sistema, Numeracion numeracion)
        {
            return !(sistema == numeracion);
        }

        public static Numeracion operator +(Numeracion n1, Numeracion n2)
        {
            return n1 + n2;
        }

        public static Numeracion operator -(Numeracion n1, Numeracion n2)
        {
            return n1 - n2;
        }

        public static Numeracion operator *(Numeracion n1, Numeracion n2)
        {
            return n1 * n2;
        }

        public static Numeracion operator /(Numeracion n1, Numeracion n2)
        {
            return n1 / n2;
        }
    }
}
