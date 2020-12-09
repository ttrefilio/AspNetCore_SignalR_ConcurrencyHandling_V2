using TodoList.Business.Entities;
using TodoList.Business.Interfaces.Repository;
using TodoList.Data.Context;

namespace TodoList.Data.Repositories
{
    public class ItemRepository 
        : BaseRepository<Item>, IItemRepository
    {
        public ItemRepository(AppDbContext context) : base(context)
        {

        }       
    }
}
