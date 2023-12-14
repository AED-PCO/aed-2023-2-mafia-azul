using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renda_Familiar.Classes
{
    public class Ordenacoes
    {
        public List<Transacao> OrdenaTransacaoPorData(List<Transacao> tran)
        {
            //tran[0].data = "2023-12-14";

            for (int i = 0; i < tran.Count; i++)
            {
                DateTime aux = DateTime.Parse(tran[i].data);
                int j = i - 1;

                while (j >= 0 && DateTime.Parse(tran[j].data) > aux)
                {
                    tran[j + 1] = tran[j];
                    j = j - 1;
                }

                tran[j + 1].data = aux.ToString();
            }
                //DateTime dataAtual = DateTime.Parse(tran[0].data);

            return tran;
        }
    }
}
