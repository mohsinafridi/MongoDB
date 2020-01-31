using MongoDB.Bson;
using MongoDB.Driver;
using System;

namespace MongoDB
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("employeeDB");
            var collection = database.GetCollection<BsonDocument>("employee");


            var data = new BsonDocument
            {
                { "name" , "Mohsin Azam" },
                {"age" , "28" },
                {"email" , "mohsin.azam@gmail.com" },
                {"position" , "Developer" }
            };
            collection.InsertOneAsync(data);
            Console.ReadKey();
        }
    }
}
