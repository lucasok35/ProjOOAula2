using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class Carro
    {
        #region Propriedades

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int AnoModelo { get; set; }
        public string Cor { get; set; }
        public int AnoFab { get; set; }
        public Motor motor { get; set; }

        #endregion Propriedades

        #region Métodos



        #endregion Métodos
    }
}
