using Entidade;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class GerarArquivo
    {

        #region Métodos

        public static void GerarLog(List<Carro> lstCarro)
        {
            string nomeArquivo = @"log" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";
            StreamWriter writer = new StreamWriter(nomeArquivo);

            foreach(var item in lstCarro)
            {
                writer.WriteLine(item.Id + ";" + item.Nome + ";" + item.Marca + ";" + item.Modelo + ";");
            }

            writer.Close();
        }

        #endregion Métodos

    }
}
