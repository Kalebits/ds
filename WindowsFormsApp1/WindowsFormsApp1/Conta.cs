using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Conta
    {

        public int numero;
        public Cliente titular;

        public Conta(Cliente cli)
        {

            this.titular = cli;

        }

        public double saldo;
        public double limite;

        public void sacar(double valor)
        {
            saldo -= valor;
        }
        
        public void depositar(double valor)
        {
            saldo += valor; 
        }

    }
}
