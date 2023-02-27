using Mono.CSharp;
using Soneta.Business;
using Soneta.Handel;
using Soneta.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weryfikator01
{
    public class PozDokHanglowegoWeryfikator : RowVerifier<PozycjaDokHandlowego>
    {
        public PozDokHanglowegoWeryfikator(PozycjaDokHandlowego row) : base(row)
        {
        }

        public override string Description => "sww nie może być krótsze niz 5 znaków";

        protected override bool IsValid()
        {

            PozycjaDokHandlowego poz = this.Row as PozycjaDokHandlowego;

            if (poz == null)
            {
                return true;
            }
            if (poz.SWW.Length<5)
            {
                return false;
            }

            return true;
        }

        public override VerifierType Type => VerifierType.Warning;
    }
}
