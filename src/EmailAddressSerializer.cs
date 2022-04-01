using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;

public class EmailAddressSerializer : SerializerBase<EmailAddress>
{
    public override void Serialize(BsonSerializationContext context, BsonSerializationArgs args, EmailAddress value)
    {
        context.Writer.WriteString((string)value);
    }
    public override EmailAddress Deserialize(BsonDeserializationContext context, BsonSerializationArgs args)
    {
        return new EmailAddress(context.Reader.ReadString());
    }
}
