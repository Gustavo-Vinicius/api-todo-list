namespace TaskManager.API.Data.Configuracoes
{
    public class DataBaseConfig : IDataBaseConfig
    {
        public string DataBaseName { get; set; }
        public string ConnectionString { get; set; }
    }
}