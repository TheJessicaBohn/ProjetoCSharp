using System;
public class FilmeOutputGetByIDDTO{

    public long Id{ get; set; }

    public string Titulo {get; set;}
    public string NomeDoDiretor{get;set;}

    public FilmeOutputGetByIDDTO(long id, string titulo, string nomeDoDiretor){
        if(titulo == null){
            throw new ArgumentNullException("Nome não informado!");
        }
        Id = id;
        Titulo = titulo;
        NomeDoDiretor = nomeDoDiretor;
    }
}
