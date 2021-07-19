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
    private readonly IDiretorService _diretorService;
    
    public DiretorController(ApplicationDbContext context, IDiretorService diretorService) 
    {
        _context = context;
        _diretorService = diretorService;
    }

    // Get api/diretore
    [HttpGet]
    public async Task<ActionResult<List<DiretorOutputGetAllDTO>>> Get()
    {
        var diretores = await _diretorService.GetAll();

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
         var diretor = await  _diretorService.GetById(id);

         var outputDTO = new DiretorOutputGetByIDDTO(diretor.Id, diretor.Nome);
         return Ok(outputDTO);
    }

    /// <returns>O diretor criado</returns>
    /// <response code="200">Diretor foi criado com sucesso</response>
    /// <response code="500">Erro interno inesperado</response>
    /// <response code="400">Erro de validação</response>
    [HttpPost]
    public async Task<ActionResult<DiretorOutputPostDTO>> Post([FromBody] DiretorInputPostDTO diretorInputDTO) {
        var diretor = await _diretorService.Post(diretorInputDTO);
    
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
        var diretor = await _diretorService.Put(id, diretorInputPutDTO);

         var diretorOutputDTO = new DiretorOutputPutDTO(diretor.Id, diretor.Nome);
         return Ok(diretorOutputDTO);
    }


    [HttpDelete(("id"))]
    public async Task<ActionResult> Delete(long id)
    {
      var diretor = await _diretorService.Delete(id);

      return Ok(diretor);
    }
}