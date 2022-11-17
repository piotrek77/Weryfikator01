using Soneta.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weryfikator01
{
    class Singleton
    {

        string nazwaLoga;
        Log log;
        private Singleton() 
        {
            nazwaLoga = "Weryfikator01";
            log = new Log(nazwaLoga, true);
        }

        private static Singleton _instance;

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
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
            bool doPliku = true;
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
