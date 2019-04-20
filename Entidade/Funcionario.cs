using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class Funcionario : Pessoa
    {
        #region Propriedades
        public decimal Salario { get; set; }

        #endregion Propriedades

        #region Metodos
        public override string ToString()
        {
            return base.ToString() + "\nSalário: " + this.Salario;
        }
        #endregion Metodos
    }
}
