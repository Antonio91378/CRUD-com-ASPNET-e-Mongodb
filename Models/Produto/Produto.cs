using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

namespace WebApiMongodb.Models
{
    public class Produto
    {
        [BsonId(IdGenerator = typeof(StringObjectIdGenerator))]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("Nome")] //====> Nome da coluna que estará no banco
        [BsonRepresentation(BsonType.String)]
        public string Nome { get; set; } = null; 
    }
}
