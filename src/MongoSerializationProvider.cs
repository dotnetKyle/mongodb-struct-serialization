using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;

public class MongoSerializationProvider : IBsonSerializationProvider
{
    public IBsonSerializer GetSerializer(Type type)
    {
        if(type == typeof(EmailAddress)
            return new EmailAddresSerializer();
            
        return null;
    }
}

/*
Usage: inside the Startup.cs or a early place near where the database gets set up (where it will run only once)

MongoDB.Bson.Serialization.BsonSerializer
    .RegisterSerializationProvider(new MongoSerializationProvider());

*/
