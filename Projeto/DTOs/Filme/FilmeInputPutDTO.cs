public class FilmeInputPutDTO{
    public string Titulo {get; set;}
    public long DiretorId {get;set;}
    
    public  FilmeInputPutDTO(string titulo, long diretorId){
        Titulo = titulo;
        DiretorId = diretorId;
    }
}