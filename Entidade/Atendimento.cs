using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class Atendimento
    {
        #region Propriedades

        public Cliente cliente { get; set; }
        public Carro carro { get; set; }
        public DateTime data { get; set; }


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
