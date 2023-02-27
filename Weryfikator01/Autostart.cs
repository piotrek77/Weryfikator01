using Soneta.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


[assembly: ProgramInitializer(typeof(Weryfikator01.Autostart))]
namespace Weryfikator01
{
    public class Autostart : IProgramInitializer
    {
        public void Initialize()
        {
            Tools singleton = Tools.GetInstance();

            singleton.Loguj(this.GetType().Name);



            _ = new WyzwalaczeReczne();
            
        }
    }
}
