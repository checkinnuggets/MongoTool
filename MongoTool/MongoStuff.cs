using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace MongoTool
{
    public interface IMongoStuff
    {
        IEnumerable<string> GetDatabaseNames();
        IEnumerable<string> GetCollectionsNames(string databaseName);
        IEnumerable<string> GetDocumentsForCollection(string databaseName, string collectionName);
        void DeleteCollection(string databaseName, string collectionName);
        void DeleteDatabase(string databaseName);
        string GetDocument(string databaseName, string collectionName, string documentId);
        void DeleteDocument(string databaseName, string collectionName, string documentId);               
    }

    public class MongoStuff : IMongoStuff
    {
        private readonly MongoClient _client;
        
        public MongoStuff(string serverName)
        {
            const string protocol = "mongodb://";
            const string port = ":27107";

            if (!serverName.StartsWith(protocol))
                serverName = protocol + serverName;

            if (!serverName.Contains(':'))
                serverName = serverName + port;

            _client = new MongoClient(serverName);
        }

        public IEnumerable<string> GetDatabaseNames()
        {
            return _client.GetServer().GetDatabaseNames();            
        }

        public IEnumerable<string> GetCollectionsNames(string databaseName)
        {
            return _client.GetServer().GetDatabase(databaseName).GetCollectionNames().Where(x=>x != "system.indexes");
        }

        public IEnumerable<string> GetDocumentsForCollection(string databaseName, string collectionName)
        {
            var database = _client.GetServer().GetDatabase(databaseName);

            var collection = database.GetCollection(collectionName);

            return collection.FindAll().Select( r=> r["_id"].ToString() );
        }

        public void DeleteCollection(string selectedDatabase, string selectedCollectionName)
        {
            _client.GetServer().GetDatabase(selectedDatabase).DropCollection(selectedCollectionName);
        }

        public void DeleteDocument(string databaseName, string collectionName, string documentId)
        {
            var collection =
                _client
                .GetServer()
                .GetDatabase(databaseName)
                .GetCollection(collectionName);

            collection.Remove(Query.EQ("_id", documentId));
        }

        public string GetDocument(string databaseName, string collectionName, string documentId)
        {
            var collection = 
                _client
                .GetServer()
                .GetDatabase(databaseName)
                .GetCollection(collectionName);

            var document = collection.FindOneById(BsonValue.Create(documentId)) ??
                         collection.FindOneById(ObjectId.Parse(documentId));

            return document.ToJson();
        }

        public void DeleteDatabase(string databaseName)
        {
            _client.GetServer().DropDatabase(databaseName);
        }
    }
}
