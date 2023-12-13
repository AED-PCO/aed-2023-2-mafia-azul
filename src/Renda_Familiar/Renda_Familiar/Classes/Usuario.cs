using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renda_Familiar.Classes
{
    public class Usuarios
    {
        public int ID { get; set; }
        public string senha { get; set; }
        public string usuario { get; set; }
        public string nome { get; set; }
        public string data_de_nascimento { get; set; }
        public decimal saldo { get; set; }
        public List<Transacao> transacoes { get; set; } = new List<Transacao>();

    }
}
