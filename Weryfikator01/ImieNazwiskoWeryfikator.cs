using Soneta.Business;
using Soneta.Kadry;
using Soneta.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Weryfikator01
{
    public class ImieNazwiskoWeryfikator : RowVerifier<Pracownik>
    {
        public ImieNazwiskoWeryfikator(Pracownik pracownik) : base(pracownik)
        {
        }
 
        public override string Description => "imie, nazwisko musi wyglądać jak imię, nazwisko :)";

        protected override bool IsValid()
        {
            Pracownik p = this.Row as Pracownik;

            if (p == null)
            {
                return true;
            }
            Tools.GetInstance().Loguj(this.GetType().Name);
            //weryfikator sprawdza czy imie i nazwisko są wpisane wg wzorca: pierwsza literaz wielka, pozostałe małe
            string wzor = "^\\p{Lu}\\p{Ll}*$";
            //https://stackoverflow.com/questions/2385701/regular-expression-for-first-and-last-name
            //Regex rx = new Regex(wzor, RegexOptions.Compiled);

            if (!Regex.IsMatch(p.Imie, wzor))
                return false;

            if (!Regex.IsMatch(p.Nazwisko, wzor))
                return false;

            return true;
        }


        public override VerifierType Type => VerifierType.Warning;

    }
}
