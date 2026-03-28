/*using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace DroneX_API.Models
{
    public class GameSession
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = null!;

        [BsonElement("userId")]
        public string UserId { get; set; } = null!;

        [BsonElement("missionId")]
        public string MissionId { get; set; } = null!;

        [BsonElement("startTime")]
        public DateTime StartTime { get; set; } 

        [BsonElement("endTime")]
        public DateTime EndTime { get; set; } 
    }
}
*/
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DroneX_API.Models
{
    public class GameSession
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = null!;

        [BsonElement("userId")]
        public string UserId { get; set; } = null!;

        [BsonElement("missionId")]
        public string MissionId { get; set; } = null!;

        [BsonElement("startTime")]
        public DateTime StartTime { get; set; }

        [BsonElement("endTime")]
        public DateTime EndTime { get; set; }
    }
}