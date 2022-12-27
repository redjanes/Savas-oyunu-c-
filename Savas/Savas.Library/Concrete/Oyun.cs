﻿using System;
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
        private TimeSpan _gecenSure;
        private readonly Panel _ucaksavarPanel;
        private Ucaksavar _ucaksavar;
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

        public Oyun(Panel ucaksavarPanel)
        {
            _ucaksavarPanel= ucaksavarPanel;
            _gecenSureTimer.Tick += GecenSureTimer_Tick;
        }
        private void GecenSureTimer_Tick(object sender, EventArgs e)
        {
            GecenSure += TimeSpan.FromSeconds(1);
        }
        public void Baslat()
        {
            if (DevamEdiyorMu) return;
            
            DevamEdiyorMu = true;
            _gecenSureTimer.Start();

            UcaksavarOlustur();
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
            _gecenSureTimer.Stop();
        }

        public void AtesEt()
        {
            throw new NotImplementedException();
        }

        public void UCaksavariHareketEttir(Yon yon)
        {
           if(!DevamEdiyorMu) return;
            _ucaksavar.HareketEttir(yon);
        }

        #endregion




    }
}
