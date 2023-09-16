namespace Entidades.Modelos
{
    public class Operacion
    {
        // Declaracion de Variables
        private Numeracion primerOperador;
        private Numeracion segundoOperador;

        /// <summary>
        /// Propiedad de lectura/escritura
        /// </summary>
        public Numeracion PrimerOperador
        {
            get { return this.primerOperador; }
            set { this.primerOperador = value; }
        }

        /// <summary>
        /// Propiedad de escritura/lectura
        /// </summary>
        public Numeracion SegundoOperador
        {
            get { return this.segundoOperador; }
            set { this.segundoOperador = value; }
        }

        /// <summary>
        /// Constructor de instancia de la clase Operacion
        /// </summary>
        /// <param name="primerOperador">Primer parametro a ingresar</param>
        /// <param name="segundoOperador">Segundo parametro a ingresa</param>
        public Operacion(Numeracion primerOperador, Numeracion segundoOperador)
        {
            this.primerOperador = primerOperador;
            this.segundoOperador = segundoOperador;
        }

        /// <summary>
        /// Metodo que realiza la operacion dependiendo del caracter
        /// </summary>
        /// <param name="operacion">Recibe como parametro un caracter</param>
        /// <returns>Devuelve la operacion realizada</returns>
        public Numeracion Operar(char operacion)
        {
            switch (operacion)
            {
                case '+':
                    return this.PrimerOperador + this.SegundoOperador;
                case '-':
                    return this.PrimerOperador - this.SegundoOperador;
                case '*':
                    return this.PrimerOperador * this.SegundoOperador;
                case '/':
                    return this.PrimerOperador / this.SegundoOperador;
                default:
                    return this.PrimerOperador + this.SegundoOperador;
            }
        }
    }
}