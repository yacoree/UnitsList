using UnitsList.Data.Units;
using UnitsList.Data.Mongo;

namespace UnitsList.Data
{
    public class UnitsLoadService
    {
        public List<Unit> UnitsList { get; set; }

        public Task<List<Unit>> GetUnitsListAsync()
        {
            return Task.FromResult(MongoExample.FindAllUnits());
        }
    }
}
