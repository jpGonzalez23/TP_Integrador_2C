using Entidades;
using Entidades.Modelos;

namespace TP_Integrador_2C
{
    public partial class FrmCalculadora : Form
    {
        private Operacion calcular;
        private Numeracion primerOperador;
        private Numeracion segundoOperador;
        private Numeracion resultado;
        private Numeracion.ESistema sistema;

        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            this.cmbOperacion.Text = "+";
            this.lblResultado.Text = "Resultado: ";
            this.rdbDecimal.Checked = true;
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtPrimerOperador.Text))
            {
                MessageBox.Show("Falta completar el primer campo",
                             "Error!",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(this.txtSegundoOperador.Text))
            {
                MessageBox.Show("Falta completar el segungo campo",
                             "Error!",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
            }
            else
            {
                this.primerOperador = new Numeracion(this.txtPrimerOperador.Text, this.sistema);
                this.segundoOperador = new Numeracion(this.txtSegundoOperador.Text, this.sistema);
                
                this.calcular = new Operacion(this.primerOperador, this.segundoOperador);

                char signo = Convert.ToChar(cmbOperacion.SelectedItem.ToString());

                this.resultado = calcular.Operar(signo);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtPrimerOperador.Clear();
            this.txtSegundoOperador.Clear();
            this.lblResultado.Text = "Resultado: ";
            this.cmbOperacion.Text = "+";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea cerrar la calculadora?",
                                                   "Confirmación",
                                                           MessageBoxButtons.YesNo,
                                                           MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void SetResultado()
        {
            this.lblResultado.Text = resultado.ToString();
        }

        private void txtPrimerOperador_TextChanged(object sender, EventArgs e)
        {
            if (rdbBinario.Checked)
            {
                primerOperador = new Numeracion(txtPrimerOperador.Text, Numeracion.ESistema.Binario);
            }
            else
            {
                primerOperador = new Numeracion(txtPrimerOperador.Text, Numeracion.ESistema.Decimal);
            }
        }

        private void txtSegundoOperador_TextChanged(object sender, EventArgs e)
        {
            if (rdbBinario.Checked)
            {
                segundoOperador = new Numeracion(txtSegundoOperador.Text, Numeracion.ESistema.Binario);
            }
            else
            {
                segundoOperador = new Numeracion(txtSegundoOperador.Text, Numeracion.ESistema.Decimal);
            }
        }

        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBinario.Checked)
            {
                rdbDecimal.Checked = false;
            }
        }

        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDecimal.Checked)
            {
                rdbBinario.Checked = false;
            }
        }
    }
}