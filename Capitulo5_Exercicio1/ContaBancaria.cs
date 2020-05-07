using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Capitulo5_Exercicio1
{
    class ContaBancaria
    {
        //Encapsolamento
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        // Construtor
        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }
        public ContaBancaria(int numero, string titular, double saldo): this(numero, titular)
        {
            Saldo = saldo;
        }

        public void Deposito(double quantia)
        {
            Saldo = Saldo + quantia;
        }

        public void Saque(double quantia)
        {
            Saldo = Saldo - (quantia + 5.0);
        }
        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }





        /* public int Numero;
         public string Titular;
         public double Saldo;

         public void Deposito(double quantia)
         {
             return quantia();*/
    }

    
}
