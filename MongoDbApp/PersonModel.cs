using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace MongoDbApp
{
    public class PersonModel
    {
        [BsonId]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [BsonElement("dob")]
        public DateTime DateOfBirth { get; set; }
        public AddressModel PrimaryAddress { get; set; }
    }


}
