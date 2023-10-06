using System;

namespace LibreriaEntidades
{
    public class SistemaBinario : Numeracion
    {
        public SistemaBinario(string valor) : base()
        {
            InicializaValor(valor);
        }

        public override bool EsNumeracionValida(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                return false;
            }

            foreach (char c in valor)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }

            return true;
        }

        public static bool EsSistemaBinarioValido(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                return false;
            }

            foreach (char c in valor)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }

            return true;
        }

        public static implicit operator SistemaBinario(string valor)
        {
            if (EsSistemaBinarioValido(valor))
            {
                return new SistemaBinario(valor);
            }
            else
            {
                throw new ArgumentException("El valor no es válido para SistemaBinario.");
            }
        }

        private double BinarioADecimal(string binario)
        {
            if (!EsNumeracionValida(binario))
            {
                throw new ArgumentException("El valor no es un número binario válido.");
            }

            double resultado = 0;
            int longitud = binario.Length;
            int potencia = 0;

            for (int i = longitud - 1; i >= 0; i--)
            {
                int bit = int.Parse(binario[i].ToString());
                resultado += bit * (1 << potencia);
                potencia++;
            }

            return resultado;
        }

        public override double ValorNumerico
        {
            get { return BinarioADecimal(Valor); }
        }

        public SistemaDecimal BinarioADecimal()
        {
            double valorDecimal = BinarioADecimal(Valor);
            return new SistemaDecimal(valorDecimal.ToString());
        }

        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            if (sistema == ESistema.Decimal)
            {
                double valorDecimal = BinarioADecimal(Valor);
                return new SistemaDecimal(valorDecimal.ToString());
            }
            else if (sistema == ESistema.Binario)
            {
                return this;
            }
            else
            {
                throw new ArgumentException("No se puede cambiar a este sistema de numeración.");
            }
        }

    }
}
