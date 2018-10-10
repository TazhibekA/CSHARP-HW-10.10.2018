using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.WordOfTanks
{
    class Tank
    {
        private string nameOfTank;
        private int ammunitionLevel;
        private int armorLevel;
        private int maneuverabilityLevel;

        public Tank(string nameOfTank)
        {
            this.nameOfTank = nameOfTank;
            Random random = new Random();

            this.ammunitionLevel = random.Next(0, 100);
            this.armorLevel = random.Next(0, 100);
            this.maneuverabilityLevel = random.Next(0, 100);

        }

        public static Tank operator *(Tank firstTank, Tank secondTank) {
            if ((firstTank.ammunitionLevel > secondTank.ammunitionLevel && firstTank.armorLevel > secondTank.armorLevel) || (firstTank.ammunitionLevel > secondTank.ammunitionLevel && firstTank.maneuverabilityLevel > secondTank.maneuverabilityLevel) || (firstTank.armorLevel > secondTank.armorLevel && firstTank.maneuverabilityLevel > secondTank.maneuverabilityLevel)) {
                return firstTank;
            }
            else  
            {
                return secondTank;
            }

        }

        public void GetInfo() {
            Console.WriteLine("Ammunition Level" + ammunitionLevel);
            Console.WriteLine("Armor Level" + armorLevel);
            Console.WriteLine("Maneuverability Level" + maneuverabilityLevel);
        }
    }
}
