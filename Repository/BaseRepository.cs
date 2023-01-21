using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using th_pl.Model;
using th_pl.Tools;

namespace th_pl.Repository
{
    public class BaseRepository<T> where T : BaseModel, new()
    {
        
        protected SQLiteAsyncConnection Database;
        public BaseRepository()
        {
            
        }


        protected virtual async Task Init()
        {
            if (Database is not null)
                return;

            Database ??= new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
            await Database.CreateTableAsync<T>();
        }

        public async Task<List<T>> GetItemsAsync()
        {
            await Init();
            return await Database.Table<T>().ToListAsync();
        }

        public async Task<T> GetItemAsync(int id)
        {
            await Init();
            return await Database.Table<T>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public async Task<int> SaveItemAsync(T item)
        {
            await Init();
            if (item.Id != 0)
            {
                return await Database.UpdateAsync(item);
            }
            else
            {
                return await Database.InsertAsync(item);
            }
        }

        public async Task<int> DeleteItemAsync(T item)
        {
            await Init();
            return await Database.DeleteAsync(item);
        }




    //    // cours
    //    public async Task<T> GetById(int id)
    //    {
    //        return await Database.FindAsync<T>(id);
    //    }

        
    //    public async Task<List<T>> GetList() => await Database.Table<T>().ToListAsync();

        
    //    public async Task<int> Insert(T entity) => await Database.InsertAsync(entity);

    //    //
    //    public async Task<int> Update(T entity) => await Database.UpdateAsync(entity);

    //    //
    //    public async Task<int> Delete(T entity) => await Database.DeleteAsync(entity);
    }
}
