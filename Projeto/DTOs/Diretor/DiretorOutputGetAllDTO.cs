public class DiretorOutputGetAllDTO{

    public long Id{ get; set; }

    public string Nome {get; set;}

    public DiretorOutputGetAllDTO(long id, string nome){
        Id = id;
        Nome = nome;
    }
}
