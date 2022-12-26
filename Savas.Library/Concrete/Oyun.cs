using Savas.Library.Enum;
using Savas.Library.İnterface;
using System;
using System.Windows.Forms;

namespace Savas.Library.Concrete
{
    public class Oyun : IOyun
    {
        #region Olaylar

        public event EventHandler GecenSureDegisti;

        #endregion
       
        #region Alanlar

        private readonly Timer _gecenSureTimer = new Timer { Interval = 1000 };
        private TimeSpan _gecenSure;
        #endregion
        
        #region Özellikler

        public bool DevamEdiyorMu { get; private set; }

        public TimeSpan GecenSure
        {
            get => _gecenSure;
            private set
            {
                _gecenSure= value;

                GecenSureDegisti?.Invoke(this,EventArgs.Empty);
            }
        }

        #endregion
        
        #region Metotlar

        public Oyun()
        {
            _gecenSureTimer.Tick += GecenSureTimer_Tick;
        }
        private void GecenSureTimer_Tick(object sender, EventArgs e)
        {
            GecenSure += TimeSpan.FromSeconds(1);
        }
        public void Baslat()
        {
            if (DevamEdiyorMu) return;
            MessageBox.Show("oyun başladı.");
            DevamEdiyorMu = true;
            _gecenSureTimer.Start();
        }

        private void Bitir()
        {

            if (!DevamEdiyorMu) return;
            DevamEdiyorMu = false;
            _gecenSureTimer.Stop();
        }

        public void AtesEt()
        {
            throw new NotImplementedException();
        }

        public void UCaksavariHareketEttir(Yon yon)
        {
            throw new NotImplementedException();
        }

        #endregion




    }
}
