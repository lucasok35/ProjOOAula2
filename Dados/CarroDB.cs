using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Dados
{
    public class CarroDB
    {
        private StringBuilder sb;
        private Conexao conexao;
        public bool Insert(Carro carro)
        {
            try
            {
                sb = new StringBuilder();

                sb.Append("INSERT INTO TB_CARRO (nome, marca, modelo, anomodelo, cor, anofab, motor) VALUES");
                sb.Append(string.Format("('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                    carro.Nome, carro.Marca, carro.Modelo, carro.AnoModelo, carro.Cor, carro.AnoFab, carro.motor));

                using (conexao = new Conexao())
                {
                    conexao.ExecutaComando(sb.ToString());
                }

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
