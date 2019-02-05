using System;
using System.Threading;
using static System.Console;

namespace Atividade1
{
    class Aplicacao
    {
        public const decimal Juros = 0.5M;
        
        static void Main(string[] args)
        {
            int s = 0;
            int idContaCorrente = 1;
            int idContaPoupanca = 1;

            Banco b = new Banco();
            while (true)
            {
                Menu();
                int op = int.Parse(ReadLine());
                switch (op)
                {
                    case 1:
                        Agencia a = new Agencia();
                        s++;
                        a.IdAgencia = s;
                        b.AdicionarAgencia(a);
                        break;
                    case 2:
                        Cliente c = new Cliente();
                        WriteLine("Qual o tipo de conta?");
                        WriteLine("1-Conta Corrente, 2-Conta Poupança");

                        int tipoConta = int.Parse(ReadLine());
                        if (tipoConta == 1)
                        {
                            ContaCorrente cc = new ContaCorrente(c.Nome);
                            if(b.listaIdAgencias() == false)
                            { break; }
                            
                            Write("\nSelecione a Agência: ");

                            int numAgencia = int.Parse(ReadLine());

                            Agencia ag = b.buscaAgencia(numAgencia);
                            if (ag != null)
                            {
                                cc.Id = idContaCorrente;
                                ag.addContaCorrente(cc);
                                idContaCorrente++;
                            }
                            else
                            {
                                WriteLine("Dados errado, tente novamente.");
                            }
                        }
                        else if (tipoConta == 2)
                        {
                            ContaPoupanca cp = new ContaPoupanca(Juros, DateTime.Now, c.Nome);
                            if (b.listaIdAgencias() == false)
                            { break; }

                            Write("\nSelecione a Agência: ");
                            int numAgencia = int.Parse(ReadLine());

                            Agencia ag = b.buscaAgencia(numAgencia);
                            if (ag != null)
                            {
                                cp.Id = idContaPoupanca;
                                ag.addContaPoupanca(cp);
                                idContaPoupanca++;
                            }
                            else
                            {
                                WriteLine("Dados errado, tente novamente.");
                            }
                        }
                        break;
                    case 3:
                        Solicitacao solicitacao = new Solicitacao();
                        solicitacao.realizarSolicitacao(b);
                        break;
                    case 4:
                        b.listaIdAgencias();
                        break;
                    case 5:
                        Console.Clear();
                        break;
                    case 0:
                        init = false;
                        break;
                    default:
                        WriteLine("Comando Inválido");
                        break;
                }
            }
        }

        public static void Menu()
        {
            WriteLine("Banco Caixa");
            WriteLine("1 - Cadastrar Agência  ");
            WriteLine("2 - Criar Conta ");
            WriteLine("3 - Abrir uma Sessão ");
            WriteLine("4 - Listar agências ");
            WriteLine("5 - Limpar tela");
            WriteLine("0 - Sair");
        }



    }
}
