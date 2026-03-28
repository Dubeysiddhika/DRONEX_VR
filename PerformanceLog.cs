/*public class PerformanceLog
{
    public string SessionId { get; set; }
    public int Score { get; set; }
    public int TimeTaken { get; set; }
}*//*

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DroneX_API.Models
{
    public class PerformanceLog
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        public string? Username { get; set; }

        public int Score { get; set; }

        public string? Terrain { get; set; }

        public float TimeTaken { get; set; }
    }
}*/
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DroneX_API.Models
{
    public class PerformanceLog
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        public string? Username { get; set; }
        public string? Terrain { get; set; }
        public int Score { get; set; }
        public float TimeTaken { get; set; }
        public float Distance { get; set; }
        public float Altitude { get; set; }
    }
}