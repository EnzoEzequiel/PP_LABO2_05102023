using System;

namespace LibreriaEntidades
{
    public enum ESistema
    {
        Decimal,
        Binario
    }
    public abstract class Numeracion
    {
        protected static string msgError = "Numero Invalido";
        protected string valor;

        public string Valor
        {
            get { return valor; }
        }

        public abstract double ValorNumerico { get; }

        public Numeracion() { }

        public Numeracion(string valor)
        {
            InicializaValor(valor);
        }

        public abstract Numeracion CambiarSistemaDeNumeracion(ESistema sistema);

        public virtual bool EsNumeracionValida(string valor)
        {
            return !string.IsNullOrWhiteSpace(valor);
        }

        public static explicit operator double(Numeracion numeracion)
        {
            return numeracion.ValorNumerico;
        }

        protected void InicializaValor(string valor)
        {
            if (EsNumeracionValida(valor))
            {
                this.valor = valor;
            }
            else
            {
                this.valor = msgError;
            }
        }

        public static bool operator !=(Numeracion n1, Numeracion n2)
        {
            return !(n1 == n2);
        }

        public static bool operator ==(Numeracion n1, Numeracion n2)
        {
            if (object.ReferenceEquals(n1, null) && object.ReferenceEquals(n2, null))
            {
                return true;
            }
            if (object.ReferenceEquals(n1, null) || object.ReferenceEquals(n2, null))
            {
                return false;
            }
            return n1.Valor == n2.Valor;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Numeracion))
            {
                return false;
            }
            Numeracion other = (Numeracion)obj;
            return this.Valor == other.Valor;
        }

        public override int GetHashCode()
        {
            return Valor.GetHashCode();
        }
    }
}
