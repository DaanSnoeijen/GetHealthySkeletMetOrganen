using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetHealthySkelet
{
    class UitkomstContainer
    {
        public List<Uitkomst> UitkomstList = new List<Uitkomst>();

        public void AddUitkomst()
        {
            Uitkomst uitkomst = new Uitkomst();
            UitkomstList.Add(uitkomst);
        }
    }
}
