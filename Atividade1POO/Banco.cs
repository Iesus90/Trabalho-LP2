using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Atividade1
{
    public class Banco
    {
         
        List<Agencia> agencias = new List<Agencia>();

        public void AdicionarAgencia(Agencia a)
        {
    
            agencias.Add(a);
            WriteLine("Agência " + a.IdAgencia + " criada com sucesso!");
            WriteLine("Numero de agencias: " + (agencias.Count) + "\n");
        }

        public int IdBanco { get; set; }

        public List<Agencia> Agencias { get; }

        public Agencia buscaAgencia(int num)
        {
            Agencia ag = null;
            foreach (var e in agencias)
            {
                if (e.IdAgencia == num)
                {
                    ag = e;
                    return ag;
                }
            }
            WriteLine("Dados errados !!!\n");
            return null;
            
            
        }

        public bool listaIdAgencias()
        {
            if(agencias.Count == 0)
            {
                WriteLine("Nenhuma agência cadastrada");
                return false;
            }
            else
            {
                WriteLine("Agências");
                foreach (var agencia in agencias)
                {
                    WriteLine("Ag: " + agencia.IdAgencia);
                }
                return true;
            }
        }

    }
}
