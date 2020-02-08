using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MessagingThingService.Models
{
    public class Message
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string FromDevice { get; set; }
        public string ToDevice { get; set; }
        public string Text { get; set; }
    }
}
