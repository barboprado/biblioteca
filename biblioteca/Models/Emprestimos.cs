using System;
using System.Collections.Generic;
using System.Text;

namespace biblioteca.Models
{
    internal class Emprestimos
    {
        public int Id { get; set; }
        public string NomeLeitor { get; set; }
        public string NomeLivro { get; set; }
        public int DataEmprestimo { get; set; }
        public int DataPrevista { get; set; }
        public int DataDevolucao { get; set; }
        public string Situacao { get; set; }
    }
}
