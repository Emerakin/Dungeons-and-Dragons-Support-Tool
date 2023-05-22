using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using BackendLogic.DM;

namespace BackendLogic.DatabaseContext.DatabaseContext
{
    public class MonsterDbContext
    {
        private readonly string[] _paths = { "..", "..", "..", "BackendLogic", "DatabaseContext", "DatabaseContext", "DB", "Monsters.json" };
        private readonly string _filePath;
        private readonly SemaphoreSlim _semaphore;

        public MonsterDbContext()
        {
            _filePath = Path.Combine(_paths);
            if (!File.Exists(_filePath))
            {
                File.Create(_filePath).Close();
            }
            _semaphore = new SemaphoreSlim(1);
        }

        public async Task SaveMonsters(IEnumerable<Monster> monsters)
        {
            string json = JsonSerializer.Serialize(monsters);
            await _semaphore.WaitAsync();
            StreamWriter writer = null;
            try
            {
                File.Delete(_filePath);
                writer = new StreamWriter(_filePath);
                writer.WriteLine(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
                _semaphore.Release();
            }
        }

        public List<Monster> LoadMonsters()
        {
            _semaphore.Wait();
            StreamReader reader = new StreamReader(_filePath);
            string line = reader.ReadLine();
            reader.Close();
            _semaphore.Release();
            if (line == null)
            {
                return new List<Monster>();
            }
            return JsonSerializer.Deserialize<List<Monster>>(line);
        }
    }
}
