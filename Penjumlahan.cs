using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODUL5_1302210087
{
    internal class Penjumlahan
    {
        public dynamic JumlahTigaAngka<T>(T a, T b, T c)
        {
            dynamic hasil = null;
            hasil = (dynamic) a + (dynamic)b + (dynamic)c;
            return hasil;
        }
    }
}
