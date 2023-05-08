using Microsoft.AspNetCore.Mvc;
using TaskManager.API.Models;
using TaskManager.API.Models.InputModels;
using TaskManager.API.Service.Services;

namespace TaskManager.API.Controllers
{
    [Route("api/tarefas")]
    public class TarefasController : ControllerBase
    {
        private readonly ITarefaService _service;
        
        public TarefasController(ITarefaService service)
        {
            _service = service;
        }        

        [HttpGet]
        public IActionResult Get()
        {
            var tarefas = _service.Buscar();
            return Ok(tarefas);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            var tarefa = _service.BuscarPorId(id);
            if(tarefa == null) return NotFound();
            return Ok(tarefa);
        }
        [HttpPost]
        public IActionResult Post([FromBody] TarefaInputModel novaTarefa)
        {
            var tarefa = new Tarefa(novaTarefa.Nome, novaTarefa.Detalhes);

            _service.Adicionar(tarefa);

            return Created("", tarefa);
        }

        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody]TarefaInputModel tarefaAtualizada)
        {
            var tarefaExistente = _service.BuscarPorId(id);

            if(tarefaExistente == null) return NotFound();

            tarefaExistente.AtualizarTarefa(tarefaAtualizada.Nome, tarefaAtualizada.Detalhes, tarefaAtualizada.Concluido);

            _service.Atualizar(id, tarefaExistente);

            return Ok(tarefaExistente);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete (string id)
        {
            var tarefaExistente = _service.BuscarPorId(id);

            if(tarefaExistente == null) return NotFound();

            _service.Remover(id);

            return NoContent();

        }

    }
}