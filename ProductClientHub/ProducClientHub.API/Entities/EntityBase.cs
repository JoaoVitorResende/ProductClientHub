﻿namespace ProducClientHub.API.Entities
{
    public abstract class EntityBase
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
