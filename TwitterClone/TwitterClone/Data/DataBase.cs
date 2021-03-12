using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterClone.Models;

namespace TwitterClone.Data
{
    public class Database
    {
        readonly SQLiteAsyncConnection _database;
        readonly string _dbPath;
        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Like>().Wait();
            _database.CreateTableAsync<Tweet>().Wait();
            _database.CreateTableAsync<User>().Wait();
            FillUsers();
            //_database.CreateTableAsync<PossibleOrder>().Wait();
            _dbPath = dbPath;
        }

        public async Task<List<User>> GetUsers()
        {
            return await _database.Table<User>().ToListAsync();
        }

        public async Task<int> ValidateUser(string name, string password)
        {
            var userVal = await _database.Table<User>().Where(x => x.FirstName == name && x.Password == password).FirstOrDefaultAsync();
            if (userVal != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private async void FillUsers()
        {
            var Users = await GetUsers();
            if(Users.Count() == 0)
            {
                User user1 = new User()
                {
                    Id = 1,
                    FirstName = "Juan",
                    LastName = "Grullon",
                    Password = "jg"
                };
                User user2 = new User()
                {
                    Id = 2,
                    FirstName = "Daniel",
                    LastName = "Grullon",
                    Password = "dg"
                    
                };
                User user3 = new User()
                {
                    Id = 3,
                    FirstName = "Luis",
                    LastName = "Gomez",
                    Password = "lg"
                };
                await _database.InsertAsync(user1);
                await _database.InsertAsync(user2);
                await _database.InsertAsync(user3);
            }
        }
    }
}
