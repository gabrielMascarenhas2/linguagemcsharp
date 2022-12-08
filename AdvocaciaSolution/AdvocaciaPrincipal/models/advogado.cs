using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvocaciaPrincipal.models
{
    public class advogado
    {
        public int codigo { get; set; }
        public string nome  { get; set; }
        public int idade { get; set; }
        public char sexo { get; set; }

        public bool verificarseadvogadoemaiorqueidade()
        {

            if (this.idade>=18)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        public List<advogado> getALLAdvogados()
        {
            return null;
        }
        public bool experience()
        {
            return false;
        }
    }
}
