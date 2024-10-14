﻿using Mates.Core.Domain.Entities;

namespace Mates.Core.Domain.RepositoryInterfaces
{
    public interface IRelationshipsRepository
    {
        public Task<Relationship> CreateRelationshipAsync(Relationship relationship);
        public Task<Relationship?> GetRelationshipAsync(Guid userId, Guid otherUserId);
        public Task<List<Relationship>> GetFriendsAsync(Guid userId);
    }
}
