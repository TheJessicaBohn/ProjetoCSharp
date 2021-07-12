using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoCSharp.Models;
using System.Linq;

[ApiController]
[Route("[controller]")]
public class DiretorController: ControllerBase
{
    private readonly ApplicationDbContext _context;
    
    public DiretorController(ApplicationDbContext context) 
    {
        _context = context;
    }

    // Get api/diretore
    [HttpGet]
    public async Task<ActionResult<List<DiretorOutputGetAllDTO>>> Get()
    {
        var diretores = await _context.Diretores.ToListAsync();

        var outputDTOList = new List<DiretorOutputGetAllDTO>();
        foreach(Diretor diretor in diretores){
            outputDTOList.Add(new DiretorOutputGetAllDTO(diretor.Id, diretor.Nome));
        }

        if(!outputDTOList.Any()){
            return NotFound("Não Existem diretores cadastrados");
        }
        return outputDTOList; 
    } 

    // Get api/diretores/1
    [HttpGet(("id"))]
    public async Task<ActionResult<DiretorOutputGetByIDDTO>> GetById(long id)
    {
         var diretor = await _context.Diretores.FirstOrDefaultAsync(diretor => diretor.Id == id);

         var outputDTO = new DiretorOutputGetByIDDTO(diretor.Id, diretor.Nome);
         return Ok(outputDTO);
    }

    /// <returns>O diretor criado</returns>
    /// <response code="200">Diretor foi criado com sucesso</response>
    /// <response code="500">Erro interno inesperado</response>
    /// <response code="400">Erro de validação</response>
    [HttpPost]
    public async Task<ActionResult<DiretorOutputPostDTO>> Post([FromBody] DiretorInputPostDTO diretorInputDTO) {
        var diretor = new Diretor(diretorInputDTO.Nome);
        _context.Diretores.Add(diretor);
        await _context.SaveChangesAsync();
    
        var diretorOutputDTO = new DiretorOutputPostDTO(diretor.Id, diretor.Nome);
        return Ok(diretorOutputDTO);
    }

    /// <summary>
    /// Cria um diretor
    /// </summary>
    /// <remarks>
    /// Sample request:
    ///
    ///     PUT /diretor/{id}
    ///     {
    ///        "nome": "Martin Scorsese"
    ///     }
    ///
    /// </remarks>
    /// <param name="id">Id do diretor</param>
    /// <param name="diretorInputDto">Nome do diretor</param>
    /// <returns>O diretor criado</returns>
    /// <response code="200">Diretor foi criado com sucesso</response>
    /// <response code="500">Erro interno inesperado</response>
    [HttpPut(("id"))]
    public async Task<ActionResult<DiretorOutputPutDTO>> Put(long id, [FromBody] DiretorInputPutDTO diretorInputPutDTO)
    {   
        var diretor = new Diretor(diretorInputPutDTO.Nome);
        diretor.Id = id;
        _context.Diretores.Update(diretor);
        await _context.SaveChangesAsync();

         var diretorOutputDTO = new DiretorOutputPutDTO(diretor.Id, diretor.Nome);
         return Ok(diretorOutputDTO);
    }


    [HttpDelete(("id"))]
    public async Task<ActionResult> Delete(long id)
    {
      var diretor = await _context.Diretores.FirstOrDefaultAsync(diretor => diretor.Id == id);
      _context.Remove(diretor);
      await _context.SaveChangesAsync();

      return Ok(diretor);
    }
}