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
            Binario,
            Decimal
        };

        // Declaracion de Variables
        private ESistema sistema;
        private double valorNumerico;

        /// <summary>
        /// Constructor de instancia de la clase Numeracion
        /// </summary>
        /// <param name="valor">Recibe como parametro un double</param>
        /// <param name="sistema">Recibe como parametro un enumero</param>
        public Numeracion(double valor, ESistema sistema)
        {
            this.valorNumerico = valor;
            this.sistema = sistema;
        }

        /// <summary>
        /// Sobrecarga del constructor de instacia de la Numeracion
        /// </summary>
        /// <param name="valor">Recibe una string</param>
        /// <param name="sistema">Recibe un enumerado</param>
        public Numeracion(string valor, ESistema sistema)
        {
            if (this.EsBinario(valor))
            {
                this.InicializarValores(valor, sistema);
            }
        }

        /// <summary>
        /// Metodo para inicialiazar los valores 
        /// </summary>
        /// <param name="valor">recibe un string</param>
        /// <param name="sistema">recibe un enumerado</param>
        private void InicializarValores(string valor, ESistema sistema)
        {

            if (EsBinario(valor))
            {
                this.valorNumerico = BinarioADecimal(valor);
            }
            else if (int.TryParse(valor, out int nuevoValor))
            {
                this.valorNumerico = nuevoValor;
            }
            else
            {
                this.valorNumerico = double.MinValue;
            }
        }

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
                StringBuilder sb = new StringBuilder();

                if (this.sistema == ESistema.Binario)
                {
                    sb.AppendLine("Es Binario");
                }
                else
                {
                    sb.AppendLine("Es Decimal");
                }

                return sb.ToString();
            }
        }

        public string ConvertirA(ESistema sistema)
        {
            if (sistema is ESistema.Binario)
            {
                return "";
            }
            else if (sistema is ESistema.Decimal)
            {
                return "";
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
            double resultadoDiv = valor;
            double restoDiv;

            if (valor >= 0)
            {
                do
                {
                    restoDiv = resultadoDiv % 2;
                    resultadoDiv /= 2;
                    valorBinario = restoDiv.ToString() + valorBinario;

                } while (resultadoDiv > 0);
            }
            else
            {
                return "Numero invalido";
            }

            return valorBinario;
        }

        /// <summary>
        /// Sobrecarga del metodo de DecimalBinario
        /// </summary>
        /// <param name="valor">Recibe un string</param>
        /// <returns>Retorna una cadena de caracteres </returns>
        private string DecimalABinario(string valor)
        {
            double.TryParse(valor, out double resultadoDiv);
            double restoDiv;

            if (string.IsNullOrEmpty(valor))
            {
                do
                {
                    restoDiv = resultadoDiv % 2;
                    resultadoDiv /= 2;
                    valor = resultadoDiv.ToString() + valor;

                } while (resultadoDiv > 0);
            }
            else
            {
                return "Numero invalido";
            }

            return valor;
        }

        /// <summary>
        /// Metodo para pasar de binario a decimal
        /// </summary>
        /// <param name="valor">Recibe un string</param>
        /// <returns>Devuelve un double</returns>
        private double BinarioADecimal(string valor)
        {
            double resultado = 0;
            double cantDeCarcter = valor.Length;

            if (this.EsBinario(valor))
            {
                foreach (char caracter in valor)
                {
                    cantDeCarcter--;
                    if (caracter == '1')
                    {
                        resultado += (double)Math.Pow(2, cantDeCarcter);
                    }
                }
            }
            else
            {
                return resultado;
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
            return sistema == (ESistema)numeracion.valorNumerico;
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
            return n1 + n2;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static Numeracion operator -(Numeracion n1, Numeracion n2)
        {
            return n1 - n2;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static Numeracion operator *(Numeracion n1, Numeracion n2)
        {
            return n1 * n2;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static Numeracion operator /(Numeracion n1, Numeracion n2)
        {
            return n1 / n2;
        }
    }
}
