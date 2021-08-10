using System;
public class DiretorOutputGetByIDDTO{

    public long Id{ get; set; }

    public string Nome {get; set;}

    public DiretorOutputGetByIDDTO(long id, string nome){
        if(nome == null){
            throw new ArgumentNullException("Nome não informado!");
        }
        Id = id;
        Nome = nome;
    }
}
