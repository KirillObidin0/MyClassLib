using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib
{
    public class Tank
    {
        private string Name;
        private int ArsenalLevel;
        private int ArmorLevel;
        private int MobilityLevel;
        private static Random rnd = new Random();

        public string GetName() { return Name; }
        public string GetArsenalInfo() { return ArsenalLevel.ToString(); }
        public string GetArmorInfo() { return ArmorLevel.ToString(); }
        public string GetMobilityInfo() { return MobilityLevel.ToString(); }

        public Tank(string name)
        {
            Name = name;
            ArsenalLevel = rnd.Next(1, 100);
            ArmorLevel = rnd.Next(1, 100);
            MobilityLevel = rnd.Next(1, 100);
        }

        public static Tank operator *(Tank tank1, Tank tank2)
        {
            int t1Points = 0;
            int t2Points = 0;

            if (tank1.ArsenalLevel > tank2.ArsenalLevel)
                t1Points++;
            else t2Points++;

            if (tank1.ArmorLevel > tank2.ArmorLevel)
                t1Points++;
            else t2Points++;

            if (tank1.MobilityLevel > tank2.MobilityLevel)
                t1Points++;
            else t2Points++;

            if (t1Points >= 2)
                return tank1;
            else if (t2Points >= 2)
                return tank2;
            else throw new Exception("draw");
        }

        public string GetInfo()
        {
            return string.Format("Name: {0}\nArsenal level: {1}\nArmor level: {2}\nMobility level: {3}.", Name, ArsenalLevel, ArmorLevel,MobilityLevel);
        }
    }
}
