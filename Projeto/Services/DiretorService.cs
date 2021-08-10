using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoCSharp.Models;

public class DiretorService : IDiretorService {

  private readonly ApplicationDbContext _context;
    public DiretorService(ApplicationDbContext context) {
        _context = context;
    }

    public async Task<List<Diretor>> GetAll() {
        
       return await _context.Diretores.ToListAsync();
       
    }

    public async Task<Diretor> GetById(long id) {

         return await _context.Diretores.FirstOrDefaultAsync(diretor => diretor.Id == id);
    }

    public async Task<Diretor> Post(DiretorInputPostDTO diretorInputDTO) {
        var diretor = new Diretor(diretorInputDTO.Nome);
         _context.Diretores.Add(diretor);
         await _context.SaveChangesAsync();
         return diretor;
    }

     public async Task<Diretor> Put(long id,DiretorInputPutDTO diretorInputPutDTO) {
        var diretor = new Diretor(diretorInputPutDTO.Nome);
        diretor.Id = id;
        _context.Diretores.Update(diretor);
        await _context.SaveChangesAsync();
        return diretor;
     }

     public async Task<Diretor> Delete(long id){
        var diretor = await _context.Diretores.FirstOrDefaultAsync(diretor => diretor.Id == id);
      _context.Remove(diretor);
      await _context.SaveChangesAsync();
      return diretor;
     }
}