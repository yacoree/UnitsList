using UnitsList.Data.Units;
using UnitsList.Data.Mongo;

namespace UnitsList.Data
{
    public class UnitsLoadService
    {
        public List<Unit> UnitsList { get; set; }

        public List<Unit> GetUnitsList()
        {
            UnitsList = MongoExample.FindAllUnits();
            return UnitsList;
        }
    }
}
