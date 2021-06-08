using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ProjetoCSharp.Models
{
    public class Diretor
    {
        public long id { get; set;}
        public string Nome { get; set;}
        public ICollection<Filme> Filmes { get; set;}

        public Diretor(string nome) 
        {
            this.Nome = nome;  
            Filmes = new List<Filmes>();   
        }

    }
}