using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoLocacao.Model
{
    public class CarroModel
    {
        //Atributos
        public int IdCarro { get; set; } //PK
        public string NumPlaca { get; set; }
        public bool TemAr { get; set; }
        public string Ano { get; set; }
        public int QtdPortas { get; set; }
        public int IdTabela { get; set; } //FK TabelaPreco
    }
}
