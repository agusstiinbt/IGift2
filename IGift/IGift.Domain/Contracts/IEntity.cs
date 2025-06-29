﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace IGift.Domain.Contracts
{
    public interface IEntity<TId> : IEntity
    {
        public TId Id { get; set; }
    }

    public interface IEntity
    {
    }

    /// <summary>
    /// Interfaz para entidades que no puede modificarse
    /// </summary>
    /// <typeparam name="TId"></typeparam>
    public abstract class Entity<TId> : IEntity<TId>
    {
        public TId Id { get; set; }
    }

    public abstract class MongoDbEntity<TId> : IEntity<TId>
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public TId Id { get; set; }
    }

    public interface IMongoDbEntity<TId> : IMongoDbEntity
    {
        public TId Id { get; set; }
    }

    public interface IMongoDbEntity
    {

    }

}
