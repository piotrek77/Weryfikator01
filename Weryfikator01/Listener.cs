using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Soneta.Business;
using Soneta.Business.App;
using Soneta.Handel;
using Soneta.Kadry;
using static Soneta.Handel.HandelModule;

[assembly: Service(typeof(ILoginListener), typeof(Weryfikator01.Listener), ServiceScope.Login)]
namespace Weryfikator01
{
    class Listener : ILoginListener
    {
        public void AfterLogin(Login login)
        {

            Tools singleton = Tools.GetInstance();

            singleton.Loguj(this.GetType().Name);
            //Soneta.Kadry.KadryModule.PracHistoriaSchema.AddOnEditin


            Soneta.Kadry.KadryModule.PracownikSchema.AddOnAdded((Soneta.Kadry.KadryModule.PracownikRow Row) =>
            {
                Row.Session.Verifiers.Add(new ImieNazwiskoWeryfikator(Row as Pracownik));
            }
            );
            Soneta.Kadry.KadryModule.PracownikSchema.AddOnEditing((Soneta.Kadry.KadryModule.PracownikRow Row) =>
            {
                Row.Session.Verifiers.Add(new ImieNazwiskoWeryfikator(Row as Pracownik));
            }
            );


            Soneta.Handel.HandelModule.PozycjaDokHandlowegoSchema.AddOnAdded((PozycjaDokHandlowegoRow Row) =>
            {
                Row.Session.Verifiers.Add(new PozDokHanglowegoWeryfikator(Row as PozycjaDokHandlowego));

            }
            );
            Soneta.Handel.HandelModule.PozycjaDokHandlowegoSchema.AddOnEditing((PozycjaDokHandlowegoRow Row) =>
            {
                Row.Session.Verifiers.Add(new PozDokHanglowegoWeryfikator(Row as PozycjaDokHandlowego));

            }
            );

        }

        public void BeforeLogin(Session session)
        {

        }

        public void BeforeUnlogin(Login login)
        {

        }
    }
}
