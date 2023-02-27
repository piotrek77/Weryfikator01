using Soneta.Handel;
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


            HandelModule.PozycjaDokHandlowegoSchema.AddIloscAfterEdit(Metoda01);


        }

        private static void Metoda01(HandelModule.PozycjaDokHandlowegoRow row)
        {
            if (row == null) { return; }
            PozycjaDokHandlowego poz = row as PozycjaDokHandlowego;


            if (poz == null) { return; }

            Tools.GetInstance().Loguj($"Ilosc={poz.Ilosc}");
        }
    }
}
