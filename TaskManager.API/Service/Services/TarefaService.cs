using TaskManager.API.Data.Repositories;
using TaskManager.API.Models;

namespace TaskManager.API.Service.Services
{
    public class TarefaService : ITarefaService
    {   
        private readonly ITarefasRepository _repository;

        public TarefaService(ITarefasRepository repository)
        {
            _repository = repository;
        }

        public void Adicionar(Tarefa tarefa)
        {
            _repository.Adicionar(tarefa);
        }

        public void Atualizar(string id, Tarefa tarefaAtualizada)
        {
            _repository.Atualizar(id, tarefaAtualizada);
        }

        public IEnumerable<Tarefa> Buscar()
        {
           return _repository.Buscar();
        }

        public Tarefa BuscarPorId(string id)
        {
            return _repository.BuscarPorId(id);
        }

        public void Remover(string id)
        {
            _repository.Remover(id);
        }
    }
}