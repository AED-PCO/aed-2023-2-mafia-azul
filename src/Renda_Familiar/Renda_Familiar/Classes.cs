using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renda_Familiar
{
    public class Pessoa
    {
        public string ID { get; set; }
        public string login;
        public string senha;
        public string usuario;
        public string Nome;
        public string Data_de_nascimento;
        public float Saldo;
        public void debito(float valor)
        {
            this.Saldo = this.Saldo - valor;
        }
        public void credito(float valor)
        {
            this.Saldo = this.Saldo + valor;
        }
    }
    public class Transacao
    {
        public string nome;
        public string data;
        public string valor;
        public string idUsuario;

    }
}
