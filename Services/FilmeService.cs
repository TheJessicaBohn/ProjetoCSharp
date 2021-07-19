using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoCSharp.Models;

public class FilmeService : IFilmeService {

  private readonly ApplicationDbContext _context;
    public FilmeService(ApplicationDbContext context) {
        _context = context;
    }

    public async Task<List<Filme>> GetAll() {
        
      return await _context.Filmes.ToListAsync();

    }

    public async Task<Filme> GetById(long id) {

         return await _context.Filmes.Include(filme => filme.Diretor).FirstOrDefaultAsync(filme => filme.Id == id);
    }

    public async Task<Filme> Post(FilmeInputPostDTO filmeInputDTO) {
     
        var diretor = await _context.Diretores.FirstOrDefaultAsync(diretor => diretor.Id == filmeInputDTO.DiretorId);
        if (diretor == null){
            throw new Exception("Diretor informado não encontrado");
        }

        var filme = new Filme(filmeInputDTO.Titulo, diretor.Id);
        _context.Filmes.Add(filme);
        await _context.SaveChangesAsync();
        return filme;
    }

     public async Task<Filme> Put(int id, FilmeInputPutDTO filmeInputPutDTO) {
        var filme = new Filme(filmeInputPutDTO.Titulo, filmeInputPutDTO.DiretorId);
        filme.Id = id;
        _context.Filmes.Update(filme);
        await _context.SaveChangesAsync();
        return filme;
     }

     public async Task<Filme> Delete(long id){
        var filme = await _context.Filmes.FirstOrDefaultAsync(filme => filme.Id == id);
      _context.Remove(filme);
      await _context.SaveChangesAsync();
      return filme;
     }
}