using System;

namespace juridico.Models
{
    class Pessoa
    {
        public int Numro { get; set; }
        public char TipoPessoa { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public List<Pessoa> Listajuridica()
        {
            return null;
        }
        public List<Pessoa> Listafisica()
        {
            return null;
        }

    }

}
