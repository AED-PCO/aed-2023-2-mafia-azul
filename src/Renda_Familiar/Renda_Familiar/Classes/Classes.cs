using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renda_Familiar.Classes
{
    public class Caminho
    {
        public void gravaArquivo(List<Usuarios> usu)
        {
            Caminho caminho = new Caminho();

            string Json = "";
            Json = JsonConvert.SerializeObject(usu);

            File.WriteAllText(caminho.geraCaminho(), Json);
        }
        public string geraCaminho()
        {
            //mudado o endereço da pasta do json
            string caminhoArquivo = "Banco\\Usuarios.json";
            string caminhoCompleto = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, caminhoArquivo);

            return caminhoCompleto;
        }
    }
}
