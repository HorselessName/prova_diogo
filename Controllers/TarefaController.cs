using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using API.Models;

namespace API.Controllers;

[Route("api/tarefa")]
[ApiController]
public class TarefaController : ControllerBase

{
    private readonly AppDataContext _context;

    public TarefaController(AppDataContext context) =>
        _context = context;

    // GET: api/tarefa/listar
    [HttpGet]
    [Route("listar")]
    public IActionResult Listar()
    {
        try
        {
            List<Tarefa> tarefas = _context.Tarefas.Include(x => x.Categoria).ToList();
            return Ok(tarefas);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    // DOIS GET - LISTAR AS CONCLUIDAS E NAO CONCLUIDAS!
    // GET: /api/tarefa/naoconcluidas
    [Route("naoconcluidas")]
    [HttpGet]
    public IActionResult TarefasNaoConcluidas()
    {
        // Mudei pra Boolean, porquê ele não tava conseguindo comparar com STRING... 

        Tarefa tarefa = _context.Tarefas.FirstOrDefault(tarefaNaoConcluida => tarefaNaoConcluida.Status == false);

        if (tarefa == null)
        {
            return NotFound();
        }
        return Ok(tarefa);
    }

    // GET: /api/tarefa/concluidas
    [Route("concluidas")]
    [HttpGet]
    public IActionResult TarefasConcluidas()
    {
        // Mudei pra Boolean, porquê ele não tava conseguindo comparar com STRING... 
        Tarefa tarefa = _context.Tarefas.FirstOrDefault(tarefaNaoConcluida => tarefaNaoConcluida.Status == true);

        if (tarefa == null)
        {
            return NotFound();
        }
        return Ok(tarefa);
    }

    // POST: api/tarefa/cadastrar
    [HttpPost]
    [Route("cadastrar")]
    public IActionResult Cadastrar([FromBody] Tarefa tarefa)
    {
        try
        {
            Categoria? categoria = _context.Categorias.Find(tarefa.CategoriaId);
            if (categoria == null)
            {
                return NotFound();
            }
            tarefa.Categoria = categoria;
            _context.Tarefas.Add(tarefa);
            _context.SaveChanges();
            return Created("", tarefa);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }


    // Patch - Ao passar ID dentro de HttpPatch (Igual no PUT) dá erro. Removi.
    // PATCH: api/tarefa/alterar
    [HttpPatch] // << Aqui da erro se passar ID, vou alterar o objeto todo e substituir. 
    [Route("alterar")]
    public async Task<IActionResult> AlterarATarefa([FromBody] Tarefa tarefa)
    {
        // Esse método altera a tarefa de acordo com a Model e e os dados recebidos.
        _context.Entry(tarefa).State = EntityState.Modified;

        try
        {
            // IMPORTANTE: Jogar o Objeto Categoria dentro senão vem como NULL
            Categoria? categoria = _context.Categorias.Find(tarefa.CategoriaId);


            if (categoria == null)
            {
                return NotFound();
            }

            // Salva o Objeto, atualizando o mesmo...
            tarefa.Categoria = categoria;
            _context.Tarefas.Update(tarefa);
            await _context.SaveChangesAsync();

            // Retornar a nova Tarefa...
            return Ok(tarefa);
        }

        catch (DbUpdateConcurrencyException)
        {
            // Tratar algum erro.
            throw;
        }
    }
}