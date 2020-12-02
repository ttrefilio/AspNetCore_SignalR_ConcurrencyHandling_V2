using System;
using System.Collections.Generic;
using System.Text;
using TodoList.Business.Interfaces;

namespace TodoList.Business.Entities
{
    public class TodoItem : ITodoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }        
    }
}
