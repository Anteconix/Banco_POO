using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Conta
    {
        // propriedades
        public string numero;
        public string titular;
        public decimal saldo;
        public List<Transacao> transacoes = new List<Transacao>();

        // método construtor
        public Conta(string num, string tit) 
        { 
            this.numero = num;
            this.titular = tit;
            this.saldo = 0;
        }
    }
}
