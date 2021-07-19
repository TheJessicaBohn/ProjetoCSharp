using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoCSharp.Models;
using System.Linq;

[ApiController]
[Route("[controller]")]
public class FilmeController: ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly IFilmeService _filmeService;
    
    public FilmeController(ApplicationDbContext context, IFilmeService _filmeService) 
    {
        _filmeService = filmeService;
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<FilmeOutputGetAllDTO>>> Get()
    {
        var filmes = await _filmeService.GetAll();

        var outputDTOList = new List<FilmeOutputGetAllDTO>();
        foreach(Filme filme in filmes){
            outputDTOList.Add(new FilmeOutputGetAllDTO(filme.Id, filme.Titulo));
        }

         if(!outputDTOList.Any()){
            return NotFound("Não Existem diretores cadastrados");
        }

        return outputDTOList;
    } 

     [HttpGet(("id"))]
    public async Task<ActionResult<FilmeOutputGetByIDDTO>> GetById(long id)
    {
         var filme = await _filmeService.GetById(id);

         var outputDTO = new FilmeOutputGetByIDDTO(filme.Id, filme.Titulo, filme.Diretor.Nome);
         return Ok(outputDTO);
    }

    [HttpPost]
    public async Task<ActionResult<FilmeOutputPostDTO>> Post([FromBody] FilmeInputPostDTO filmeInputDTO) {
        var filme = await _filmeService.Post(filmeInputDTO);
    
        var filmeOutputDTO = new FilmeOutputPostDTO(filme.Id,filme.Titulo);
        return Ok(filmeOutputDTO);
    }

    [HttpPut(("id"))]
    public async Task<ActionResult<FilmeOutputPutDTO>> Put(int id, [FromBody] FilmeInputPutDTO filmeInputPutDTO)
    {   
        var filme = await _filmeService.Put(id, filmeInputPutDTO);
        var filmeOutputDTO = new FilmeOutputPutDTO(filme.Id, filme.Titulo);
        return Ok(filmeOutputDTO);
    }


    [HttpDelete(("id"))]
    public async Task<ActionResult> Delete(long id)
    {
      var filme = await _filmeService.Delete(id);

      return Ok(filme);
    }
}