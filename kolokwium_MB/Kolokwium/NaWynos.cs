using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    public class Nawynos : Zamowienie
    {
        public override bool PoprawnyCzas()
        {
            if (czasDostawy == "dzis")
            {
                return true;
            }
            return false;
        }
    }
}
