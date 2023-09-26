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

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtPrimerOperador.Clear();
            this.txtSegundoOperador.Clear();
            this.lblResultado.Text = null;
            this.cmbOperacion.Text = null;
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
            if (this.rdbBinario.Checked)
            {
                this.lblResultado.Text = "";
            }
            else if (this.rdbDecimal.Checked)
            {
                this.lblResultado.Text = "";
            }
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