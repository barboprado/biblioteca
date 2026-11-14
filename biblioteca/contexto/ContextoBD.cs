using biblioteca.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace biblioteca.contexto
{
    internal class ContextoBD
    {
        public List<Emprestimos> emprestimos =new List<Emprestimos>();
        public List<Livros> livros =new List<Livros>();
        public List<Leitores> leitores =new List<Leitores>();

    }
}
