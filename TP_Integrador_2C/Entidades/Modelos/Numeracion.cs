using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Numeracion
    {
        /// <summary>
        /// Declaracion de enumerados
        /// </summary>
        public enum ESistema
        {
            Decimal,
            Binario
        };

        // Declaracion de Variables
        private ESistema sistema;
        private double valorNumerico;

        /// <summary>
        /// Propiedad de lectura de la variable Sistema
        /// </summary>
        public ESistema Sistema
        {
            get
            {
                return this.sistema;
            }
        }

        /// <summary>
        /// Propiedad de lectura que retorna una cadena de caracteres
        /// </summary>
        public string Valor
        {
            get
            {
                return this.ConvertirA(this.sistema);
            }
        }

        /// <summary>
        /// Constructor de instancia de la clase Numeracion
        /// </summary>
        /// <param name="valor">Recibe como parametro un double</param>
        /// <param name="sistema">Recibe como parametro un enumero</param>
        public Numeracion(double valor, ESistema sistema) 
            : this(valor.ToString(), sistema)
        {
            
        }

        /// <summary>
        /// Sobrecarga del constructor de instacia de la Numeracion
        /// </summary>
        /// <param name="valor">Recibe una string</param>
        /// <param name="sistema">Recibe un enumerado</param>
        public Numeracion(string valor, ESistema sistema) 
        {
            this.InicializarValores(valor, sistema);
        }

        /// <summary>
        /// Metodo para inicialiazar los valores 
        /// </summary>
        /// <param name="valor">recibe un string</param>
        /// <param name="sistema">recibe un enumerado</param>
        private void InicializarValores(string valor, ESistema sistema)
        {
            if (sistema == ESistema.Decimal)
            {
                double.TryParse(valor, out this.valorNumerico);
            }
            else if (EsBinario(valor) && sistema == ESistema.Binario)
            {
                this.valorNumerico = this.BinarioADecimal(valor);
            }
            else
            {
                this.valorNumerico = double.MinValue;
            }

            this.sistema = sistema;
        }

        public string ConvertirA(ESistema sistema)
        {
            if (sistema == this.sistema)
            {
                return this.valorNumerico.ToString();
            }
            else if (sistema == ESistema.Binario)
            {
                return this.BinarioADecimal(Valor).ToString();
            }
            else if (sistema == ESistema.Decimal)
            {
                return this.DecimalABinario(Valor);
            }
            else
            {
                return "Numero invalido";
            }
        }

        /// <summary>
        /// Metodo para saber si es binario o no
        /// </summary>
        /// <param name="valor">Recibe un string</param>
        /// <returns>Retorna false si no es un numero binario, true si lo es</returns>
        private bool EsBinario(string valor)
        {
            foreach (char c in valor)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Metodo para pasar de decimal a binario
        /// </summary>
        /// <param name="valor">Recibe un int</param>
        /// <returns>retorna una cadena de caracteres</returns>
        private string DecimalABinario(int valor)
        {
            string valorBinario = string.Empty;

            do
            {
                valorBinario = (valor % 2) + valorBinario;
                valor /= 2;

            } while (valor >= 2);
            valorBinario = valor + valorBinario;

            return valorBinario;
        }

        /// <summary>
        /// Sobrecarga del metodo de DecimalBinario
        /// </summary>
        /// <param name="valor">Recibe un string</param>
        /// <returns>Retorna una cadena de caracteres </returns>
        private string DecimalABinario(string valor)
        {
            if (!int.TryParse(valor, out int decimalNumero))
            {
                return "Numero invalido";
            }
            return DecimalABinario(decimalNumero);
        }

        /// <summary>
        /// Metodo para pasar de binario a decimal
        /// </summary>
        /// <param name="valor">Recibe un string</param>
        /// <returns>Devuelve un double</returns>
        private double BinarioADecimal(string valor)
        {
            double resultado = 0;
            int longitud = valor.Length;

            for (int i = 0; i < longitud; i++)
            {
                if (valor[i] == '1')
                {
                     int exponente = longitud - i - 1;
                     resultado += Math.Pow(2, exponente);
                 }
            }

            return resultado;
        }

        /// <summary>
        /// Metodo para 
        /// </summary>
        /// <param name="numeroUno"></param>
        /// <param name="numeroDos"></param>
        /// <returns></returns>
        public static bool operator ==(Numeracion numeroUno, Numeracion numeroDos)
        {
            return numeroUno.valorNumerico == numeroDos.valorNumerico && numeroUno.Sistema == numeroDos.Sistema;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numeroUno"></param>
        /// <param name="numeroDos"></param>
        /// <returns></returns>
        public static bool operator !=(Numeracion numeroUno, Numeracion numeroDos)
        {
            return !(numeroUno == numeroDos);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sistema"></param>
        /// <param name="numeracion"></param>
        /// <returns></returns>
        public static bool operator ==(ESistema sistema, Numeracion numeracion)
        {
            return sistema == numeracion.Sistema;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sistema"></param>
        /// <param name="numeracion"></param>
        /// <returns></returns>
        public static bool operator !=(ESistema sistema, Numeracion numeracion)
        {
            return !(sistema == numeracion);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static Numeracion operator +(Numeracion n1, Numeracion n2)
        {
            double suma = n1.valorNumerico + n2.valorNumerico;
            return new Numeracion(suma, ESistema.Decimal);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static Numeracion operator -(Numeracion n1, Numeracion n2)
        {
            double resta = n1.valorNumerico - n2.valorNumerico;
            
            return new Numeracion(resta, ESistema.Decimal);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static Numeracion operator *(Numeracion n1, Numeracion n2)
        {
            double multiplicacion = n1.valorNumerico * n2.valorNumerico;

            return new Numeracion(multiplicacion, ESistema.Decimal);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static Numeracion operator /(Numeracion n1, Numeracion n2)
        {
            double division = n1.valorNumerico / n2.valorNumerico;

            return new Numeracion(division, ESistema.Decimal);
        }
    }
}
