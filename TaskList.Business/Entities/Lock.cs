using System;

namespace TodoList.Business.Entities
{
    public class Lock
    {
        public int EntityId { get; set; }
        public string EntityType { get; set; }
        public string Owner { get; set; }
        public DateTime AcquiredDateTime { get; set; }
    }
}
