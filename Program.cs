using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace inheritance_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Mag p1 = new Mag("Elf", 200, 50);
            Console.WriteLine(p1.name + " " + p1.HpPoints + " " + p1.mana);
        }
    }

    class Npc
    {
        public string name;
        public int HpPoints;
        public Npc()
        {

        }
        public Npc(string name, int hpPoints)
        {
            this.name = name;
            this.HpPoints = hpPoints;
        }
    }

    class Mag : Npc
    {
        public Mag(string name, int HpPoints, int mana) : base(name, HpPoints)
        {
            this.mana = mana;
        }

        public int mana;
    }
}
