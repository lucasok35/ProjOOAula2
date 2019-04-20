using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class Garagem
    {
        #region Propriedades
        public string Cnpj { get; set; }
        public string Nome { get; set; }
        public List<decimal> Carro { get; set; }
        public string Telefone { get; set; }
        #endregion Propriedades

        #region Métodos

        public void Inserir()
        {

        }

        public void Consultar()
        {

        }

        #endregion Métodos
    }
}
