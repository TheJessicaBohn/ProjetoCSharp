using System.Collections.Generic;
using System.Threading.Tasks;
using ProjetoCSharp.Models;

public interface IFilmeService {
    Task<List<Filme>> GetAll();
    Task<Filme> GetById(long id);
    Task<Filme> Post(FilmeInputPostDTO fimeInputDTO);
    Task<Filme> Put(int id, FilmeInputPutDTO filmeInputPutDTO);
    Task<Filme> Delete(long id);
}