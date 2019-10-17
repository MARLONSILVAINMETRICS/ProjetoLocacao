using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoLocacao.Model
{
    class LocatarioModel
    {
        public int Cpf { get; set; }//PK
        public string Nome { get; set; }
        public DateTime DataNsc { get; set; }
        public bool Fumante { get; set; }
        public string Sexo { get; set; }
    }
}
