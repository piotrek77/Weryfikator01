using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weryfikator01
{
    public class WyzwalaczeReczne
    {

        //konstruktor statyczny jest lepszy, gdyż jest wołany tylko raz
        static WyzwalaczeReczne()
        {
            Tools.GetInstance().Loguj("WyzwalaczeReczne - konstruktor statyczny");
        }
    }
}
