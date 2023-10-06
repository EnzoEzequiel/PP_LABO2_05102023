using System;
using System.Collections.Generic;

namespace LibreriaEntidades
{
    public class Calculadora
    {
        private string nombreAlumno;
        private List<string> operaciones;
        private Numeracion primerOperando;
        private Numeracion segundoOperando;
        private Numeracion resultado;
        private ESistema sistema;

        public string NombreAlumno
        {
            get { return nombreAlumno; }
            set { nombreAlumno = value; }
        }

        public List<string> Operaciones
        {
            get { return operaciones; }
            set { operaciones = value; }
        }

        public Numeracion PrimerOperando
        {
            get { return primerOperando; }
            set { primerOperando = value; }
        }

        public Numeracion SegundoOperando
        {
            get { return segundoOperando; }
            set { segundoOperando = value; }
        }

        public Numeracion Resultado
        {
            get { return resultado; }
        }

        public ESistema Sistema
        {
            get { return sistema; }
            set { sistema = value; }
        }

       
        public Calculadora()
        {
            operaciones = new List<string>();
            nombreAlumno = "";
            sistema = ESistema.Decimal; 
        }


        public Calculadora(string nombreAlumno)
        {
            operaciones = new List<string>();
            this.nombreAlumno = nombreAlumno;
            sistema = ESistema.Decimal; 
        }

        public void Calcular(char operador)
        {
            if (primerOperando == null || segundoOperando == null)
            {
                throw new InvalidOperationException("Faltan operandos para realizar el cálculo.");
            }

            if (primerOperando.GetType() != segundoOperando.GetType())
            {
                throw new InvalidOperationException("No se pueden operar numeraciones de diferentes tipos.");
            }

            double valorResultado = RealizarOperacion(operador);
            resultado = MapeaResultado(valorResultado);

            ActualizarHistorialDeOperaciones(operador);
        }

        private double RealizarOperacion(char operador)
        {
            double valorPrimerOperando = primerOperando.ValorNumerico;
            double valorSegundoOperando = segundoOperando.ValorNumerico;

            switch (operador)
            {
                case '+':
                    return valorPrimerOperando + valorSegundoOperando;
                case '-':
                    return valorPrimerOperando - valorSegundoOperando;
                case '*':
                    return valorPrimerOperando * valorSegundoOperando;
                case '/':
                    if (valorSegundoOperando == 0)
                    {
                        throw new DivideByZeroException("No se puede dividir por cero.");
                    }
                    return valorPrimerOperando / valorSegundoOperando;
                default:
                    throw new ArgumentException("Operador no válido.");
            }
        }

        private Numeracion MapeaResultado(double valorResultado)
        {
            switch (sistema)
            {
                case ESistema.Decimal:
                    return new SistemaDecimal(valorResultado.ToString());
                case ESistema.Binario:
                    return new SistemaBinario(valorResultado.ToString());
                
                default:
                throw new ArgumentException("Sistema de numeración no válido.");
            }
        }

        public void ActualizarHistorialDeOperaciones(char operador)
        {
            string operacion = $"{primerOperando.Valor} {operador} {segundoOperando.Valor} = {resultado.Valor}";
            operaciones.Add(operacion);
        }

        public void EliminarHistorialDeOperaciones()
        {
            operaciones.Clear();
        }
    }
}

