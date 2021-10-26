using System;
using Enum;

namespace Entity
{
    public class Serie : EntityBase
    {
        public Genero Genero { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Ano { get; set; }

        public bool Excluido { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Excluido = false;
        }

        public override string ToString()
        {
            return "Genero: " + Genero + Environment.NewLine +
                   "Titulo: " + Titulo + Environment.NewLine +
                   "Descricao: " + Descricao + Environment.NewLine +
                   "Ano de Inicio: " + Ano;
        }

        public string RetornaTitulo()
        {
            return Titulo;
        }
        public int RetornaId()
        {
            return Id;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}
