using System;

namespace HexGameFieldInit
{
    class Program
    {
        static void Main(string[] args)
        {
            //var sf = new SotaFields("application", "++++++++++++++++++++++++++++");
            //var sf = new SotaFields("application", "ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            var sf = new HexFields("application", "abcdefghijklmnopqrstuvwxyz");
            sf.Print();
        }
    }
}
