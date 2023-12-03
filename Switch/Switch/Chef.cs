using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch {
    class Chef {

        public void ChefMadeChicken()
        {
            Console.WriteLine("Chef made chicken");
        }

        public void ChefMadeSalad()
        {
            Console.WriteLine("Chef made salad");
        }

        public virtual void ChefMadeSpecialDish()
        {
            Console.WriteLine("Chef made paslie");
        }

    }
    class Thaichef : Chef
    {
        public override void ChefMadeSpecialDish()
        {
            Console.WriteLine("Chef made padthai");
        }

    }
}
