using System;
using System.Collections.Generic;
using System.Drawing;
using Savas.Library.Enum;
using Savas.Library.İnterface;

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
        private readonly Timer _hareketTimer = new Timer { Interval = 100 };
        private TimeSpan _gecenSure;
        private readonly Panel _ucaksavarPanel;
        private readonly Panel _SavasalaniPanel;
        private Ucaksavar _ucaksavar;
        private readonly List<Mermi>_mermiler= new List<Mermi>();

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

        public Oyun(Panel ucaksavarPanel, Panel savasalaniPanel)
        {
            _ucaksavarPanel= ucaksavarPanel;
            _SavasalaniPanel = savasalaniPanel;
            _gecenSureTimer.Tick += GecenSureTimer_Tick;
            _hareketTimer.Tick += hareketTimer_Tick;
        }
        private void GecenSureTimer_Tick(object sender, EventArgs e)
        {
            GecenSure += TimeSpan.FromSeconds(1);
        }

        private void hareketTimer_Tick(object sender, EventArgs e)
        {
            MermileriHareketEttir();
        }

        private void MermileriHareketEttir()
        {
            for (int i = _mermiler.Count-1; i >= 0; i--)
            {
                var mermi = _mermiler[i];
                var carptiMi = mermi.HareketEttir(Yon.Yukari);
                if (carptiMi)
                {
                    _mermiler.Remove(mermi);
                    _SavasalaniPanel.Controls.Remove((mermi));
                }

            }



        }


        public void Baslat()
        {
            if (DevamEdiyorMu) return;
            
            DevamEdiyorMu = true;
           
            ZamanlayicilarBaslat();

            UcaksavarOlustur();
        }

        private void ZamanlayicilarBaslat()
        {
            _gecenSureTimer.Start();
            _hareketTimer.Start();
        } 

        private void UcaksavarOlustur()
        {

            _ucaksavar = new Ucaksavar(_ucaksavarPanel.Width, _ucaksavarPanel.Size);
            
            _ucaksavarPanel.Controls.Add(_ucaksavar);
        }

        private void Bitir()
        {

            if (!DevamEdiyorMu) return;
            DevamEdiyorMu = false;
           
            ZamanlayıcılarıDurdur();
        }

        private void ZamanlayıcılarıDurdur()
        {
            _gecenSureTimer.Stop();
            _hareketTimer.Stop();
        }

        public void AtesEt()
        {
            if (!DevamEdiyorMu) return;

            var mermi = new Mermi(_SavasalaniPanel.Size,_ucaksavar.Center);
            _mermiler.Add(mermi);
            _SavasalaniPanel.Controls.Add(mermi);
            

        }

        public void UCaksavariHareketEttir(Yon yon)
        {
           if(!DevamEdiyorMu) return;
            _ucaksavar.HareketEttir(yon);
        }

        #endregion




    }
}
