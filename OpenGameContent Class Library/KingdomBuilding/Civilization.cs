using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGameContent_Class_Library.KingdomBuilding
{
    public class Civilization
    {
        CivilizationAlignment alignment;

        //Build Points.
        public int BuildPoints { get; set; }

        //Build Point Upkeep per Month.
        public int Consumption { get { return Size; } }

        //DC of Control Checks.
        public int ControlDC { get; set; }

        //Economy Level of the Kingdom.
        public int Economy { get { return alignment.EconomyModifier; } }

        //Loyalty Level of the Kingdom.
        public int Loyalty { get { return alignment.LoyaltyModifier; } }

        //Stability Level of the Kingdom.
        public int Stability { get { return alignment.StabilityModifier; } }

        //Number of people living in this Kingdom.
        public int Population { get; set; }

        //The number of Hexes that this Kingdom takes up.
        public int Size { get; set; }

        //Build Points saved up that can be spent on activities.
        public int Treasury { get; set; }

        //The age of the Kingdom in Months.
        public int Age { get; set; }

        public void UpkeepPhase()
        {
            //Determine Kingdom Stability

            //Pay Consumption

            //Fill Vacant Magic Item Slots

            //Modify Unrest
        }
        public void EdictPhase()
        {
            //Assign Leadership
            
            //Claim and Abandon Hexes

            //Build Terrain Improvements

            //Create and Improve Settlements

            //Create Army Units

            //Issue Edicts
        }
        public void IncomePhase()
        {
            //Make withdrawls from the Treasury

            //Make Deposits to the Treasury

            //Sell expensive items for BP

            //Collect Taxes
        }
        bool eventHappenedLastMonth;
        public void EventPhase()
        {
            int percentChanceOfEvent = eventHappenedLastMonth ? 75 : 25;
        }
    }
}
