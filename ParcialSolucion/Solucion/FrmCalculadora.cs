using LibreriaEntidades;
using System;
using System.Windows.Forms;

namespace Solucion
{
    public partial class FrmCalculadora : Form
    {
        private Calculadora calculadora;

        public FrmCalculadora()
        {
            InitializeComponent();
            this.calculadora = new Calculadora("Nombre y Apellido");
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            comboBoxOperacion.Items.Add("+");
            comboBoxOperacion.Items.Add("-");
            comboBoxOperacion.Items.Add("*");
            comboBoxOperacion.Items.Add("/");
            comboBoxOperacion.SelectedIndex = 0;
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            char operador;
            this.calculadora.PrimerOperando = this.GetOperando(txtBoxPrimerOperador.Text);
            this.calculadora.SegundoOperando = this.GetOperando(txtBoxSegundoOperador.Text);
            operador = comboBoxOperacion.SelectedItem.ToString()[0];
            this.calculadora.Calcular(operador);
            labelResultado.Text = $"Resultado: {calculadora.Resultado.Valor}";
            this.MostrarHistorial();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.calculadora.EliminarHistorialDeOperaciones();
            this.MostrarHistorial();
            txtBoxPrimerOperador.Clear();
            txtBoxSegundoOperador.Clear();
            comboBoxOperacion.SelectedIndex = 0;
            setResultado("0");
        }

        private void setResultado(string resultado)
        {
            labelResultado.Text = resultado;
        }
        private void MostrarHistorial()
        {
            this.lstHistorial.Items.Clear();

            foreach (var operacion in this.calculadora.Operaciones)
            {
                this.lstHistorial.Items.Add(operacion);
            }
        }


        private Numeracion GetOperando(string value)
        {
            if (this.calculadora.Sistema == ESistema.Binario)
            {
                return new SistemaBinario(value);
            }
            return new SistemaDecimal(value);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cerrar la calculadora?", "Cerrar Calculadora", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void radioButtonBinario_CheckedChanged(object sender, EventArgs e)
        {
            this.calculadora.Sistema = ESistema.Binario;
        }

        private void radioButtonDecimal_CheckedChanged(object sender, EventArgs e)
        {
            this.calculadora.Sistema = ESistema.Decimal;
        }

    }
}
