using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    public class Zamowienie
    {
         protected string czasDostawy;

          public void UstawCzasDostawy(string czasDostawy)
        {
            this.czasDostawy = czasDostawy;
        }

          public virtual bool PoprawnyCzas()
        {
            return czasDostawy == null ? (czasDostawy == "wczoraj" ? false : true) : false;
        }
    }
}
