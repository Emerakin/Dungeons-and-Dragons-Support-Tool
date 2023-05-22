using System.Collections.Generic;
using System.Threading.Tasks;
using BackendLogic.DatabaseContext.DatabaseContext;
using BackendLogic.DM;

namespace BackendLogic.DatabaseContext
{
    public class MonsterService
    {
        private MonsterDbContext _dbContext;
        private List<Monster> _monsters;

        public MonsterService(MonsterDbContext dbContext)
        {
            _dbContext = dbContext;
            _monsters = _dbContext.LoadMonsters();
        }

        public MonsterService() : this(new MonsterDbContext()) { }

        public List<Monster> GetMonsters()
        {
            return _monsters;
        }

        public void AddMonster(Monster monster)
        {
            _monsters.Add(monster);
        }

        public void RemoveMonster(Monster monster)
        {
            _monsters.Remove(monster);
        }

        public async Task SaveMonsters()
        {
            await _dbContext.SaveMonsters(_monsters);
        }
    }
}
