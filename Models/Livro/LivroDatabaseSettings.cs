namespace WebApiMongodb.Models
{
    public class LivroDatabaseSettings
    {
        public string ConnectionString { get; set; } = null;
        public string DatabaseName { get; set; } = null;
        public string LivroCollectionName { get; set; } = null;
    }
}
