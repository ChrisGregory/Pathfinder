using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGameContent_Class_Library.KingdomBuilding
{
    class CivilizationOfficial
    {
        public String Name { get; set; }
        public String Title { get; set; }

        public CivilizationGovRole Role { get; set; }

        bool hasLeadership;

        public int LoyaltyModifier { get; set; }
        public int EconomyModifier { get; set; }
        public int StabilityModifier { get; set; }

    }
}
