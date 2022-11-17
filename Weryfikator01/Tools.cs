using Soneta.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weryfikator01
{
    class Tools
    {

        string nazwaLoga;
        Log log;
        private Tools() 
        {
            nazwaLoga = "Weryfikator01";
            log = new Log(nazwaLoga, true);
        }

        private static Tools _instance;

        public static Tools GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Tools();
            }
            return _instance;
        }



        public void Loguj(string tresc)
        {
            Loguj(tresc, new object[0]);
        }

        void Loguj(string tresc, params object[] parametry)
        {
            bool debug = true;
            bool doPliku = false;
            string nazwaPliku = "c:\\temp\\log.txt";
            
            if (debug)
            {
                
                log.WriteLine(tresc, parametry);
                if (doPliku && !string.IsNullOrEmpty(nazwaPliku))
                {
                    System.IO.File.AppendAllText(nazwaPliku, string.Format(tresc, parametry) + System.Environment.NewLine);
                }
            }
        }


    }
}
