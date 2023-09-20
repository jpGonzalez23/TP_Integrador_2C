using Entidades;
using Entidades.Modelos;

namespace TP_Integrador_2C
{
    public partial class FrmCalculadora : Form
    {
        private Operacion calcular;
        private Numeracion primerOperador;
        private Numeracion segundoOperador;
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

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtPrimerOperador.Clear();
            this.txtSegundoOperador.Clear();
            this.lblResultado.Text = "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}