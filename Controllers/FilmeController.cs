using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoCSharp.Models;

[ApiController]
[Route("[controller]")]
public class FilmeController: ControllerBase
{
    private readonly ApplicationDbContext _context;
    
    public FilmeController(ApplicationDbContext context) 
    {
        _context = context;
    }

    [HttpGet]
    public async Task<List<FilmeOutputGetAllDTO>> Get()
    {
        var filmes = await _context.Filmes.ToListAsync();

        var outputDTOList = new List<FilmeOutputGetAllDTO>();
        foreach(Filme filme in filmes){
            outputDTOList.Add(new FilmeOutputGetAllDTO(filme.Id, filme.Titulo));
        }

        return outputDTOList;
    } 

     [HttpGet(("id"))]
    public async Task<ActionResult<FilmeOutputGetByIDDTO>> GetById(long id)
    {
         var filme = await _context.Filmes.FirstOrDefaultAsync(filme => filme.Id == id);

         var outputDTO = new FilmeOutputGetByIDDTO(filme.Id, filme.Titulo);
         return Ok(outputDTO);
    }

    [HttpPost]
    public async Task<ActionResult<FilmeOutputPostDTO>> Post([FromBody] FilmeInputPostDTO filmeInputDTO) {
        var filme = new Filme(filmeInputDTO.Titulo);
        _context.Filmes.Add(filme);
        await _context.SaveChangesAsync();
    
        var filmeOutputDTO = new FilmeOutputPostDTO(filme.Id, filme.Titulo);
        return Ok(filmeOutputDTO);
    }

    [HttpPut(("id"))]
    public async Task<ActionResult<FilmeOutputPutDTO>> Put(int id, [FromBody] FilmeInputPutDTO filmeInputPutDTO)
    {   
        var filme = new Filme(filmeInputPutDTO.Titulo);
        filme.Id = id;
        _context.Filmes.Update(filme);
        await _context.SaveChangesAsync();

         var filmeOutputDTO = new FilmeOutputPutDTO(filme.Id, filme.Titulo);
         return Ok(filmeOutputDTO);
    }


    [HttpDelete(("id"))]
    public async Task<ActionResult> Delete(long id)
    {
      var filme = await _context.Filmes.FirstOrDefaultAsync(filme => filme.Id == id);
      _context.Remove(filme);
      await _context.SaveChangesAsync();

      return Ok(filme);
    }
}