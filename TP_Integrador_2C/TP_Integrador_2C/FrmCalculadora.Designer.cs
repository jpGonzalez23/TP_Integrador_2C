namespace TP_Integrador_2C
{
    partial class FrmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblResultado = new Label();
            rdbBinario = new RadioButton();
            rdbDecimal = new RadioButton();
            gpbSistema = new GroupBox();
            lblPrimerOperador = new Label();
            lblOperador = new Label();
            lblSegundoOperador = new Label();
            txtPrimerOperador = new TextBox();
            txtSegundoOperador = new TextBox();
            cmbOperacion = new ComboBox();
            btnOperar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            gpbSistema.SuspendLayout();
            SuspendLayout();
            // 
            // lblResultado
            // 
            lblResultado.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(12, 9);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(380, 40);
            lblResultado.TabIndex = 0;
            lblResultado.Text = "Resultado:";
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Location = new Point(6, 33);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(62, 19);
            rdbBinario.TabIndex = 1;
            rdbBinario.TabStop = true;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Location = new Point(100, 33);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(68, 19);
            rdbDecimal.TabIndex = 2;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            // 
            // gpbSistema
            // 
            gpbSistema.Controls.Add(rdbBinario);
            gpbSistema.Controls.Add(rdbDecimal);
            gpbSistema.Location = new Point(156, 52);
            gpbSistema.Name = "gpbSistema";
            gpbSistema.Size = new Size(200, 68);
            gpbSistema.TabIndex = 3;
            gpbSistema.TabStop = false;
            gpbSistema.Text = "Representar el resultado en:";
            // 
            // lblPrimerOperador
            // 
            lblPrimerOperador.AutoSize = true;
            lblPrimerOperador.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrimerOperador.Location = new Point(12, 139);
            lblPrimerOperador.Name = "lblPrimerOperador";
            lblPrimerOperador.RightToLeft = RightToLeft.No;
            lblPrimerOperador.Size = new Size(154, 25);
            lblPrimerOperador.TabIndex = 4;
            lblPrimerOperador.Text = "Primer Operador";
            // 
            // lblOperador
            // 
            lblOperador.AutoSize = true;
            lblOperador.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblOperador.Location = new Point(205, 139);
            lblOperador.Name = "lblOperador";
            lblOperador.Size = new Size(100, 25);
            lblOperador.TabIndex = 5;
            lblOperador.Text = "Operación";
            // 
            // lblSegundoOperador
            // 
            lblSegundoOperador.AutoSize = true;
            lblSegundoOperador.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSegundoOperador.Location = new Point(340, 139);
            lblSegundoOperador.Name = "lblSegundoOperador";
            lblSegundoOperador.Size = new Size(173, 25);
            lblSegundoOperador.TabIndex = 6;
            lblSegundoOperador.Text = "Segundo Operador";
            // 
            // txtPrimerOperador
            // 
            txtPrimerOperador.Location = new Point(12, 167);
            txtPrimerOperador.Name = "txtPrimerOperador";
            txtPrimerOperador.Size = new Size(154, 23);
            txtPrimerOperador.TabIndex = 7;
            // 
            // txtSegundoOperador
            // 
            txtSegundoOperador.Location = new Point(340, 167);
            txtSegundoOperador.Name = "txtSegundoOperador";
            txtSegundoOperador.Size = new Size(173, 23);
            txtSegundoOperador.TabIndex = 8;
            // 
            // cmbOperacion
            // 
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cmbOperacion.Location = new Point(194, 167);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(121, 23);
            cmbOperacion.TabIndex = 9;
            // 
            // btnOperar
            // 
            btnOperar.Location = new Point(12, 208);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(154, 43);
            btnOperar.TabIndex = 10;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(194, 208);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(121, 43);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(340, 208);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(173, 43);
            btnCerrar.TabIndex = 12;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 276);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOperar);
            Controls.Add(cmbOperacion);
            Controls.Add(txtSegundoOperador);
            Controls.Add(txtPrimerOperador);
            Controls.Add(lblSegundoOperador);
            Controls.Add(lblOperador);
            Controls.Add(lblPrimerOperador);
            Controls.Add(gpbSistema);
            Controls.Add(lblResultado);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora Gonzalez Juan Pablo";
            gpbSistema.ResumeLayout(false);
            gpbSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResultado;
        private RadioButton rdbBinario;
        private RadioButton rdbDecimal;
        private GroupBox gpbSistema;
        private Label lblPrimerOperador;
        private Label lblOperador;
        private Label lblSegundoOperador;
        private TextBox txtPrimerOperador;
        private TextBox txtSegundoOperador;
        private ComboBox cmbOperacion;
        private Button btnOperar;
        private Button btnLimpiar;
        private Button btnCerrar;
    }
}