using biblioteca.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace biblioteca.contexto
{
    public static class ContextoBD
    {
        public static List<Leitores> leitores =new List<Leitores>();
        public static List<(int Id, string Titulo, string Autor, string Genero, int QuantidadeDisponivel)> livros = new List<(int, string, string, string, int)>();
        public static List<(int Id, int Matricula, string NomeLeitor, string Titulo, string Autor, DateTime DataEmprestimo, DateTime DataDevolucaoPrevist)> emprestimos = new List<(int, int, string, string, string, DateTime, DateTime)>();

    }
}
