using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGameContent_Class_Library.KingdomBuilding
{
    class CivilizationAlignment
    {
        bool good;
        bool evil;
        bool lawful;
        bool chaotic;

        public bool Good
        {
            get { return good; }
            set { good = value; Evil = good ? !good : Evil; }
        }

        public bool Evil
        {
            get { return evil; }
            set { evil = value; Good = evil ? !evil : Good; }
        }

        public bool Lawful
        {
            get { return lawful; }
            set { lawful = value; Chaotic = lawful ? !lawful : Chaotic; }
        }

        public bool Chaotic
        {
            get { return chaotic; }
            set { chaotic = value; Lawful = chaotic ? !chaotic : Lawful; }
        }

        public string Alignment
        {
            get
            {
                string result = "";
                if(!Good && !Evil && !Lawful && !Chaotic)
                {
                    result += "Neutral";
                }
                else
                {
                    result += Lawful ? "Lawful" : "";
                    result += Chaotic ? "Chaotic" : "";
                    result += (Lawful || Chaotic) && (Good || Evil) ? " " : "";
                    result += Good ? "Good" : "";
                    result += Evil ? "Evil" : "";
                }
                return result;
            }
        }

        public int LoyaltyModifier
        {
            get
            {
                int result = 0;
                result += Good ? 2 : 0;
                result += Chaotic ? 2 : 0;
                return result;
            }
        }

        public int EconomyModifier
        {
            get
            {
                int result = 0;
                result += Evil ? 2 : 0;
                result += Lawful ? 2 : 0;
                return result;
            }
        }

        public int StabilityModifier
        {
            get
            {
                int result = 0;
                result += !Evil && !Good ? 2 : 0;
                result += !Lawful && !Chaotic ? 2 : 0;
                return result;
            }
        }
    }
}
