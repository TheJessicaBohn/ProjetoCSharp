using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoCSharp.Models;

[ApiController]
[Route("[controller]")]
public class DiretorController: ControllerBase
{
    private readonly ApplicationDbContext _context;
    
    public DiretorController(ApplicationDbContext context) 
    {
        _context = context;
    }

    [HttpGet]
    public async Task<List<Diretor>> Get()
    {
        return await _context.Diretores.ToListAsync();
    } 

    [HttpGet(("id"))]
    public async Task<ActionResult<Diretor>> GetById(long id)
    {
         var diretor = await _context.Diretores.FirstOrDefaultAsync(diretor => diretor.Id == id);
         return Ok(diretor);
    }

    [HttpPost]
    public async Task<ActionResult<DiretorInputDTO>> Post([FromBody] DiretorInputDTO diretorInputDTO) {
        var diretor = new Diretor(diretorInputDTO.Nome);
        _context.Diretores.Add(diretor);
        await _context.SaveChangesAsync();
    
        var diretorOutputDTO = new DiretorOutputDTO(diretor.Id, diretor.Nome);
        return Ok(diretorOutputDTO);
    }

    [HttpPut(("id"))]
    public async Task<ActionResult<Diretor>> Put(long id, [FromBody] Diretor diretor)
    {
        diretor.Id = id;
        _context.Diretores.Update(diretor);
        await _context.SaveChangesAsync();

        return Ok(diretor);
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