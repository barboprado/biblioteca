using System;
using System.Collections.Generic;
using System.Text;

namespace biblioteca.Models
{
    public class Livros
    {
        public int Id { get; set; }
        public int  ExemplaresDisponiveis { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string  Genero{ get; set; }
    }
}
