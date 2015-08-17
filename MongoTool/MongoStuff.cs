using System;
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

        void InsertRecord(string databaseName, string collectionName, string json);
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

            
            ObjectId objectId;
            if( ObjectId.TryParse(documentId, out objectId ) )
                collection.Remove(Query.EQ("_id", objectId));
            
            collection.Remove(Query.EQ("_id", BsonValue.Create(documentId)));    
        }

        public string GetDocument(string databaseName, string collectionName, string documentId)
        {
            var collection = 
                _client
                .GetServer()
                .GetDatabase(databaseName)
                .GetCollection(collectionName);

            BsonDocument document = null;
            ObjectId objectId;
<<<<<<< HEAD

            if( ObjectId.TryParse(documentId, out objectId) )
                document = collection.FindOneById(objectId);

=======

            if( ObjectId.TryParse(documentId, out objectId) )
                document = collection.FindOneById(objectId);

>>>>>>> origin/master
            
            if (document == null)
                document = collection.FindOneById(BsonValue.Create(documentId));
            
            return document == null ? string.Empty : document.ToJson();
        }

        public void DeleteDatabase(string databaseName)
        {
            _client.GetServer().DropDatabase(databaseName);
        }


        public void InsertRecord(string databaseName, string collectionName, string json)
        {
            var collection = _client.GetServer().GetDatabase(databaseName).GetCollection(collectionName);

            var document = MongoDB.Bson.Serialization.BsonSerializer.Deserialize<BsonDocument>(json);

            collection.Insert(document);
        }
    }
}
