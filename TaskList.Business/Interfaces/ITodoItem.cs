using System;
using System.Collections.Generic;
using System.Text;

namespace TodoList.Business.Interfaces
{
    public interface ITodoItem : IEntityBase
    {
        string Title { get; set; }
        string Description { get; set; }
        bool IsDone { get; set; }
    }
}
