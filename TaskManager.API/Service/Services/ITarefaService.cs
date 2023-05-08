using TaskManager.API.Models;

namespace TaskManager.API.Service.Services
{
    public interface ITarefaService
    {
        void Adicionar(Tarefa tarefa);
        void Atualizar(string id, Tarefa tarefaAtualizada);
        IEnumerable<Tarefa>Buscar();
        Tarefa BuscarPorId(string id);
        void Remover(string id);
    }
}