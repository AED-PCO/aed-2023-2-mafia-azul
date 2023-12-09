using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renda_Familiar
{
    public class Usuarios
    {
        public int ID { get; set; }
        public string senha { get; set; }
        public string usuario { get; set; }
        public string nome { get; set; }
        public string data_de_nascimento { get; set; }
        public float saldo { get; set; }
        public List<Transacao> transacoes { get; set; }
    }
    public class Transacao
    {
        public string tipo;
        public string data;
        public float valor;
        public int ID;
    }
    public class Caminho
    {
        public string geraCaminho()
        {
            string caminhoArquivo = "Banco\\Usuarios.json";
            string caminhoCompleto = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, caminhoArquivo);

            return caminhoCompleto;
        }
    }
}
