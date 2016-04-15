using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGameContent_Class_Library.KingdomBuilding
{
    public class TerrainType
    {
        public TerrainType (string name = null, int exploreTime = 0, int prepTime = 0, int prepCost = 0, int farmCost = 0, int roadCost = 0)
        {
            Name = name;
            ExplorationTime = exploreTime;
            PreparationTime = prepTime;
            PreparationCost = prepCost;
            FarmCost = farmCost;
            RoadCost = roadCost;
        }

        public string Name { get; set; }
        public int ExplorationTime { get; set; } //In days. 0 is immediate. -1 is explorable.
        public int PreparationTime { get; set; } //In months. 0 is immediate. -1 is unpreparable.
        public int PreparationCost { get; set; } //In BP. 0 is none. -1 is unpreparable.
        public int FarmCost { get; set; } //In BP. 0 is none. -1 is unfarmable.
        public int RoadCost { get; set; } //In BP. 0 is none. -1 is unroadable.

        //Question: Should I create booleans for "CanExplore", "CanPrepare", "CanFarm", or "CanRoad"?
        //Initial Answer: Eh... probably not. Just check for -1s.
        //Current Answer: What if I made them calculated readonly properties?

        public bool CanExplore { get { return ExplorationTime < 0; } }
        public bool CanPrepare { get { return PreparationTime < 0 || PreparationCost < 0; } }
        public bool CanFarm { get { return FarmCost < 0; } }
        public bool CanRoad { get { return RoadCost < 0; } }
    }
}
