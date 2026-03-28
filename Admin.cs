using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DroneX_API.Models
{
    public class Admin
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = null!;

        [BsonElement("adminName")]
        public string AdminName { get; set; } = null!;

        [BsonElement("password")]
        public string Password { get; set; } = null!;
    }
}

