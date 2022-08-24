using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WebApiMongodb.Models
{
    public class Produto
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("Nome")] //====> Nome da coluna que estará no banco
        public string Nome { get; set; } = null; 
    }
}
