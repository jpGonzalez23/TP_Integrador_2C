namespace Entidades.Modelos
{
    public class Operacion
    {
        private Numeracion primerOperador;
        private Numeracion segundoOperador;

        public Numeracion PrimerOperador
        {
            get { return this.primerOperador; }
            set { this.primerOperador = value; }
        }

        public Numeracion SegundoOperador
        {
            get { return this.segundoOperador; }
            set { this.segundoOperador = value; }
        }

        public Operacion(Numeracion primerOperador, Numeracion segundoOperador)
        {
            this.primerOperador = primerOperador;
            this.segundoOperador = segundoOperador;
        }

        public Numeracion Operar(char operacion = '+')
        {
            switch (operacion)
            {
                case '+':
                    break;
                case '-':
                    break;
                case '*':
                    break;
                case '/':
                    break;
            }
        }
    }
}