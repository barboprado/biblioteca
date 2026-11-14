using System;
using System.Collections.Generic;
using System.Text;

namespace biblioteca.Models
{
    internal class Livros
    {
        public int Id { get; set; }
        public int  ExemplaresDisponiveis { get; set; }
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string  Genero{ get; set; }
    }
}
