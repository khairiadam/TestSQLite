using System.Collections.Generic;
using System.Threading.Tasks;
using TestSQLite.Models;
using SQLite;


namespace TestSQLite.Repository
{
    public class SQLiteRepo
    {
        SQLiteAsyncConnection db;

        public SQLiteRepo(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<Product>().Wait();
        }

        //Insert and Update new record
        public Task<int> SaveItemAsync(Product product)
        {
            if (product.Id != 0)
            {
                return db.UpdateAsync(product);
            }
            else
            {
                return db.InsertAsync(product);
            }
        }

        //Delete
        public Task<int> DeleteItemAsync(Product product)
        {
            return db.DeleteAsync(product);
        }

        //Read All Items
        public Task<List<Product>> GetItemsAsync()
        {
            return db.Table<Product>().ToListAsync();
        }


        //Read Item
        public Task<Product> GetItemAsync(int id)
        {
            return db.Table<Product>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }
    }
}