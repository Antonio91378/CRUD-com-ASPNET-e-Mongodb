using Microsoft.Extensions.Options;
using MongoDB.Driver;
using WebApiMongodb.Models;

namespace WebApiMongodb.services.LivrosServices
{
    public class LivroServices
    {
        private readonly IMongoCollection<Livro> _livroCollection;

        public LivroServices(IOptions<LivroDatabaseSettings> livroServices)
        {
            var mongoClient = new MongoClient(livroServices.Value.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(livroServices.Value.DatabaseName);

            _livroCollection = mongoDatabase.GetCollection<Livro>(livroServices.Value.LivroCollectionName);
        }

        public async Task<List<Livro>> GetAsync() =>
            await _livroCollection.Find(x => true).ToListAsync();

        public async Task<Livro> GetAsync(string id) =>
            await _livroCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Livro livro) =>
            await _livroCollection.InsertOneAsync(livro);

        public async Task UpdateAsync(string id, Livro livro) =>
            await _livroCollection.ReplaceOneAsync(x => x.Id == id, livro);
        public async Task RemoveAsync(string id) =>
            await _livroCollection.DeleteOneAsync(x => x.Id == id);
    }
}
