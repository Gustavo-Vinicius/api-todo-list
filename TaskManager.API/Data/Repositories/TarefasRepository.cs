using TaskManager.API.Models;
using MongoDB.Driver;
using TaskManager.API.Data.Configuracoes;

namespace TaskManager.API.Data.Repositories
{
    public class TarefasRepository : ITarefasRepository
    {
        private readonly IMongoCollection<Tarefa> _tarefas;

        public TarefasRepository(IDataBaseConfig dataBaseConfig)
        {
            var client = new MongoClient(dataBaseConfig.ConnectionString);
            var dataBase = client.GetDatabase(dataBaseConfig.DataBaseName);

            _tarefas = dataBase.GetCollection<Tarefa>("tarefas");
        }

        public void Adicionar(Tarefa tarefa)
        {
            _tarefas.InsertOne(tarefa);
        }

        public void Atualizar(string id, Tarefa tarefaAtualizada)
        {
            _tarefas.ReplaceOne(tarefa => tarefa.Id == id, tarefaAtualizada);
        }

        public IEnumerable<Tarefa> Buscar()
        {
            return _tarefas.Find(tarefa => true).ToList();
        }

        public Tarefa BuscarPorId(string id)
        {
            return _tarefas.Find(tarefa => tarefa.Id == id).FirstOrDefault ();
        }

        public void Remover(string id)
        {
            _tarefas.DeleteOne(tarefa => tarefa.Id == id);
        }
    }
}