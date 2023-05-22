using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using BackendLogic.PC;

namespace BackendLogic.DatabaseContext.DatabaseContext
{
    public class CharacterDbContext
    {
        private readonly string[] _paths = { "..", "..", "..", "BackendLogic", "DatabaseContext", "DatabaseContext", "DB", "Characters.json" };
        private readonly string _filePath;
        private readonly SemaphoreSlim _semaphore;

        public CharacterDbContext()
        {
            _filePath = Path.Combine(_paths);
            if (!File.Exists(_filePath))
            {
                File.Create(_filePath).Close();
            }
            _semaphore = new SemaphoreSlim(1);
        }

        public async Task SaveCharacters(IEnumerable<Character> characters)
        {
            string json = JsonSerializer.Serialize(characters);
            await _semaphore.WaitAsync();
            StreamWriter writer = null;
            try
            {
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

        public List<Character> LoadCharacters()
        {
            _semaphore.Wait();
            StreamReader reader = new StreamReader(_filePath);
            string line = reader.ReadLine();
            reader.Close();
            _semaphore.Release();
            if (line == null)
            {
                return new List<Character>();
            }
            return JsonSerializer.Deserialize<List<Character>>(line);
        }
    }
}
