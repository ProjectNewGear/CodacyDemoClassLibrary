using System;
using CodacyDemoClassLibrary;

namespace CodacyDemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient pat1 = new Patient("Beleren", "Jace", Convert.ToDateTime("6-3-1988"));
            Patient pat2 = new Patient("Nalaar", "Chandra", Convert.ToDateTime("1-1-2000"));

            pat1 = pat2;
        }
    }
}
