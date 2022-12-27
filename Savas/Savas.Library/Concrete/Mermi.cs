using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Savas.Library.Abstract;

namespace Savas.Library.Concrete
{
    internal class Mermi:Cisim
    {
        public Mermi(Size HareketAlaniBoyutlari,int namluOrtasiX):base(HareketAlaniBoyutlari)
        {
            BaslangicKonumunuAyarla(namluOrtasiX);
            HareketMesafesi = (int)(Height * 1.5);
        }

        private void BaslangicKonumunuAyarla(int namluOrtasiX)
        {
            Bottom = HareketAlaniBoyutlari.Height;
            Center=namluOrtasiX;
        }
    }
}
