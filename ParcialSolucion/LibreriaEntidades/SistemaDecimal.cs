using System;

namespace LibreriaEntidades
{
    public class SistemaDecimal : Numeracion
    {
        public SistemaDecimal(string valor) : base()
        {
            InicializaValor(valor);
        }

        public override bool EsNumeracionValida(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                return false;
            }

            if (!double.TryParse(valor, out double resultado))
            {
                return false;
            }

            return true;
        }

        public static bool EsSistemaDecimalValido(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                return false;
            }

            if (!double.TryParse(valor, out double resultado))
            {
                return false;
            }

            return true;
        }

        public static implicit operator SistemaDecimal(double valor)
        {
            return new SistemaDecimal(valor.ToString());
        }

        public static implicit operator SistemaDecimal(string valor)
        {
            if (EsSistemaDecimalValido(valor))
            {
                return new SistemaDecimal(valor);
            }
            else
            {
                throw new ArgumentException("El valor no es válido para SistemaDecimal.");
            }
        }

        public override double ValorNumerico
        {
            get { return Convert.ToDouble(Valor); }
        }

        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            if (sistema == ESistema.Binario)
            {
                return new SistemaBinario(DecimalABinario(ValorNumerico));
            }
            else if (sistema != ESistema.Decimal)
            {
                throw new ArgumentException("No se puede cambiar a este sistema de numeración.");
            }

            return this;
        }

        public string DecimalABinario(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("El valor debe ser un número decimal positivo.");
            }

            if (valor == 0)
            {
                return "0";
            }

            int parteEntera = (int)valor;
            double parteDecimal = valor - parteEntera;

            string binarioParteEntera = "";
            while (parteEntera > 0)
            {
                int residuo = parteEntera % 2;
                binarioParteEntera = residuo + binarioParteEntera;
                parteEntera /= 2;
            }

            string binarioParteDecimal = "";
            if (parteDecimal > 0)
            {
                binarioParteDecimal = ".";

                for (int i = 0; i < 32; i++)
                {
                    parteDecimal *= 2;
                    int bit = (int)parteDecimal;
                    binarioParteDecimal += bit;
                    parteDecimal -= bit;
                    if (parteDecimal == 0)
                    {
                        break;
                    }
                }
            }
            return binarioParteEntera + binarioParteDecimal;
        }
    }
}
