using System.Collections.Generic;
using System.Threading.Tasks;
using ProjetoCSharp.Models;

public interface IDiretorService {
    Task<List<Diretor>> GetAll();
    Task<Diretor> GetById(long id);
    Task<Diretor> Post(DiretorInputPostDTO diretorInputDTO);
    Task<Diretor> Put(long id, DiretorInputPutDTO diretorInputPutDTO);
    Task<Diretor> Delete(long id)
}