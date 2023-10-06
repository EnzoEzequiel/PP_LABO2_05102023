using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
namespace Solucion
{
    partial class FrmCalculadora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1=new Label();
            btnOperar=new Button();
            btnLimpiar=new Button();
            btnCerrar=new Button();
            txtBoxPrimerOperador=new TextBox();
            txtBoxSegundoOperador=new TextBox();
            labelRepresentarResultadoEn=new Label();
            comboBoxOperacion=new ComboBox();
            labelResultado=new Label();
            labelPrimerOperador=new Label();
            labelSegundoOperador=new Label();
            labelOperacion=new Label();
            radioButtonDecimal=new RadioButton();
            radioButtonBinario=new RadioButton();
            label2=new Label();
            lstHistorial=new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location=new Point(12, 34);
            label1.Name="label1";
            label1.Size=new Size(212, 56);
            label1.TabIndex=0;
            label1.Text="---------->";
            // 
            // btnOperar
            // 
            btnOperar.Location=new Point(32, 387);
            btnOperar.Name="btnOperar";
            btnOperar.Size=new Size(142, 51);
            btnOperar.TabIndex=1;
            btnOperar.Text="Operar";
            btnOperar.UseVisualStyleBackColor=true;
            btnOperar.Click+=btnOperar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location=new Point(222, 387);
            btnLimpiar.Name="btnLimpiar";
            btnLimpiar.Size=new Size(142, 51);
            btnLimpiar.TabIndex=2;
            btnLimpiar.Text="Limpiar";
            btnLimpiar.UseVisualStyleBackColor=true;
            btnLimpiar.Click+=btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location=new Point(419, 387);
            btnCerrar.Name="btnCerrar";
            btnCerrar.Size=new Size(142, 51);
            btnCerrar.TabIndex=3;
            btnCerrar.Text="Cerrar";
            btnCerrar.UseVisualStyleBackColor=true;
            btnCerrar.Click+=btnCerrar_Click;
            // 
            // txtBoxPrimerOperador
            // 
            txtBoxPrimerOperador.Font=new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxPrimerOperador.Location=new Point(32, 316);
            txtBoxPrimerOperador.Name="txtBoxPrimerOperador";
            txtBoxPrimerOperador.Size=new Size(142, 33);
            txtBoxPrimerOperador.TabIndex=4;
            // 
            // txtBoxSegundoOperador
            // 
            txtBoxSegundoOperador.Font=new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxSegundoOperador.Location=new Point(419, 316);
            txtBoxSegundoOperador.Name="txtBoxSegundoOperador";
            txtBoxSegundoOperador.Size=new Size(142, 33);
            txtBoxSegundoOperador.TabIndex=6;
            // 
            // labelRepresentarResultadoEn
            // 
            labelRepresentarResultadoEn.AutoSize=true;
            labelRepresentarResultadoEn.Font=new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelRepresentarResultadoEn.Location=new Point(169, 208);
            labelRepresentarResultadoEn.Name="labelRepresentarResultadoEn";
            labelRepresentarResultadoEn.Size=new Size(164, 17);
            labelRepresentarResultadoEn.TabIndex=7;
            labelRepresentarResultadoEn.Text="Representar resultado en:";
            // 
            // comboBoxOperacion
            // 
            comboBoxOperacion.Font=new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxOperacion.FormattingEnabled=true;
            comboBoxOperacion.Location=new Point(222, 316);
            comboBoxOperacion.Name="comboBoxOperacion";
            comboBoxOperacion.Size=new Size(142, 33);
            comboBoxOperacion.TabIndex=10;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize=true;
            labelResultado.Font=new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point);
            labelResultado.Location=new Point(291, 34);
            labelResultado.Name="labelResultado";
            labelResultado.Size=new Size(51, 55);
            labelResultado.TabIndex=11;
            labelResultado.Text="0";
            // 
            // labelPrimerOperador
            // 
            labelPrimerOperador.AutoSize=true;
            labelPrimerOperador.Font=new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPrimerOperador.Location=new Point(32, 291);
            labelPrimerOperador.Name="labelPrimerOperador";
            labelPrimerOperador.Size=new Size(126, 18);
            labelPrimerOperador.TabIndex=12;
            labelPrimerOperador.Text="Primer Operador";
            // 
            // labelSegundoOperador
            // 
            labelSegundoOperador.AutoSize=true;
            labelSegundoOperador.Font=new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSegundoOperador.Location=new Point(419, 291);
            labelSegundoOperador.Name="labelSegundoOperador";
            labelSegundoOperador.Size=new Size(142, 18);
            labelSegundoOperador.TabIndex=13;
            labelSegundoOperador.Text="Segundo Operador";
            // 
            // labelOperacion
            // 
            labelOperacion.AutoSize=true;
            labelOperacion.Font=new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelOperacion.Location=new Point(248, 291);
            labelOperacion.Name="labelOperacion";
            labelOperacion.Size=new Size(85, 18);
            labelOperacion.TabIndex=14;
            labelOperacion.Text="Operacion:";
            // 
            // radioButtonDecimal
            // 
            radioButtonDecimal.AutoSize=true;
            radioButtonDecimal.Location=new Point(153, 240);
            radioButtonDecimal.Name="radioButtonDecimal";
            radioButtonDecimal.Size=new Size(68, 19);
            radioButtonDecimal.TabIndex=15;
            radioButtonDecimal.TabStop=true;
            radioButtonDecimal.Text="Decimal";
            radioButtonDecimal.UseVisualStyleBackColor=true;
            radioButtonDecimal.CheckedChanged+=radioButtonDecimal_CheckedChanged;
            // 
            // radioButtonBinario
            // 
            radioButtonBinario.AutoSize=true;
            radioButtonBinario.Location=new Point(280, 240);
            radioButtonBinario.Name="radioButtonBinario";
            radioButtonBinario.Size=new Size(62, 19);
            radioButtonBinario.TabIndex=16;
            radioButtonBinario.TabStop=true;
            radioButtonBinario.Text="Binario";
            radioButtonBinario.UseVisualStyleBackColor=true;
            radioButtonBinario.CheckedChanged+=radioButtonBinario_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Calibri", 21.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location=new Point(644, 135);
            label2.Name="label2";
            label2.Size=new Size(115, 36);
            label2.TabIndex=17;
            label2.Text="Historial";
            // 
            // lstHistorial
            // 
            lstHistorial.FormattingEnabled=true;
            lstHistorial.ItemHeight=15;
            lstHistorial.Location=new Point(581, 174);
            lstHistorial.Name="lstHistorial";
            lstHistorial.Size=new Size(265, 259);
            lstHistorial.TabIndex=18;
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(867, 450);
            Controls.Add(lstHistorial);
            Controls.Add(label2);
            Controls.Add(radioButtonBinario);
            Controls.Add(radioButtonDecimal);
            Controls.Add(labelOperacion);
            Controls.Add(labelSegundoOperador);
            Controls.Add(labelPrimerOperador);
            Controls.Add(labelResultado);
            Controls.Add(comboBoxOperacion);
            Controls.Add(labelRepresentarResultadoEn);
            Controls.Add(txtBoxSegundoOperador);
            Controls.Add(txtBoxPrimerOperador);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOperar);
            Controls.Add(label1);
            Name="FrmCalculadora";
            Text="Calculadora de Enzo Peña";
            Load+=FrmCalculadora_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnOperar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private TextBox txtBoxPrimerOperador;
        private TextBox txtBoxSegundoOperador;
        private Label labelRepresentarResultadoEn;
        private ComboBox comboBoxOperacion;
        private Label labelResultado;
        private Label labelPrimerOperador;
        private Label labelSegundoOperador;
        private Label labelOperacion;
        private RadioButton radioButtonDecimal;
        private RadioButton radioButtonBinario;
        private Label label2;
        private ListBox lstHistorial;
    }
}