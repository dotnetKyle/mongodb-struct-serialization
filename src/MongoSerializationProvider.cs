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
