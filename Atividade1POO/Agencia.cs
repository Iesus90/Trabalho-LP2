using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Atividade1
{
    public class Agencia
    {

        List<ContaCorrente> contasCorrente = new List<ContaCorrente>();
        List<ContaPoupanca> contasPoupanca = new List<ContaPoupanca>();
        List<Solicitacao> solicitacoes = new List<Solicitacao>();

        public void addContaCorrente(ContaCorrente cc){
            contasCorrente.Add(cc);
            WriteLine("Dados da Conta\n" + "Numero: "  + cc.Id + "\n" + "Titular: " + cc.Titular + "\n" + "Conta Criada com sucesso\n");
        }
        public void addContaPoupanca(ContaPoupanca cp){
            contasPoupanca.Add(cp);
            WriteLine("Dados da Conta\n" + "Numero: " + cp.Id + "\n" + "Titular: " + cp.Titular + "\n" + "Conta Criada com sucesso\n");

        }
        public ContaCorrente getCorrente(int num)
        {
            ContaCorrente cc = null;
            foreach (var e in contasCorrente)
            {
                if (e.Id == num)
                {
                    cc = e;
                    return cc;
                }
            }

            WriteLine("Dados invalidos !!!");
            return null;
        }
        public ContaPoupanca getPoupanca(int num)
        {
            ContaPoupanca cp = null;
            foreach (var e in contasPoupanca)
            {
                if (e.Id == num)
                {
                    cp = e;
                    return cp;
                }
            }
            WriteLine("Dados invalidos !!!");
            return null;
        }
        public int IdAgencia { get; set; }
    }
}
