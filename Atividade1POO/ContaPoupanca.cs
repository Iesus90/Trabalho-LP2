using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade1
{
    public class ContaPoupanca : Conta
    {

        private decimal juros;
        private DateTime aniversario;

        public ContaPoupanca(decimal j, DateTime d, string t) : base(t)
        {
            juros = j;
            aniversario = d;
        }

        public decimal Juros { get; set; }
        public DateTime DataAniversario { get; set; }

        public void AdicionarRendimento()
        {
            if (DateTime.Now.Equals(aniversario))
            {
                decimal ren;
                ren = Saldo * juros;
                Depositar(ren);
            }
        }

        public override int Id
        {
            get; set;
        }
    }
}
