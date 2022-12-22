using Savas.Library.Enum;
using Savas.Library.İnterface;
using System;
using System.Windows.Forms;

namespace Savas.Library.Concrete
{
    public class Oyun : IOyun
    {
        public bool DevamEdiyorMu { get; private set; }
        public TimeSpan GecenSure { get; }
        public void Baslat()
        {
            if (DevamEdiyorMu) return;
            MessageBox.Show("oyun başladı.");
            DevamEdiyorMu = true;
        }

        private void Bitir()
        {

            if(!DevamEdiyorMu) return;
            DevamEdiyorMu = false;
        }

        public void AtesEt()
        {
            throw new NotImplementedException();
        }

        public void UCaksavariHareketEttir(Yon yon)
        {
            throw new NotImplementedException();
        }
    }
}
