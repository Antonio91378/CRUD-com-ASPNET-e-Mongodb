using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

namespace WebApiMongodb.Models
{
    public class Livro
    {
        [BsonId(IdGenerator = typeof(StringObjectIdGenerator))]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        [BsonElement("Titulo")] //====> Nome da coluna que estará no banco
        [BsonRepresentation(BsonType.String)]
        public string Titulo { get; set; } = null;
        public string Autor { get; set; }
        public int Ano { get; set; }
        public int Paginas { get; set; }
        public List<string> Assunto { get; set; }

    }
}
