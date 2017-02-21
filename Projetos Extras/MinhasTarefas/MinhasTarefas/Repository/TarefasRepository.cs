using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace MinhasTarefas
{
	public class TarefasRepository
	{
		readonly SQLiteAsyncConnection database;

		public TarefasRepository(string dbPath)
		{
			database = new SQLiteAsyncConnection(dbPath);
			database.CreateTableAsync<Tarefa>().Wait();
		}

		public Task<List<Tarefa>> GetItemsAsync()
		{
			return database.Table<Tarefa>().ToListAsync();
		}

		public Task<List<Tarefa>> GetItemsNotDoneAsync()
		{
			return database.QueryAsync<Tarefa>("SELECT * FROM [Tarefa] WHERE [Concluida] = 0");
		}

		public Task<Tarefa> GetItemAsync(Guid id)
		{
			return database.Table<Tarefa>().Where(i => i.ID == id).FirstOrDefaultAsync();
		}

		public Task<int> SaveItemAsync(Tarefa item)
		{
			if (item.ID != new Guid())
			{
				return database.UpdateAsync(item);
			}

			item.ID = Guid.NewGuid();
			return database.InsertAsync(item);
		}

		public Task<int> DeleteItemAsync(Tarefa item)
		{
			return database.DeleteAsync(item);
		}

	}
}
