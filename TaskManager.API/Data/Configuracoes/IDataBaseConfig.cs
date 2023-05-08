namespace TaskManager.API.Data.Configuracoes
{
    public interface IDataBaseConfig
    {
         string DataBaseName { get; set; }
         string ConnectionString { get; set; }
    }
}