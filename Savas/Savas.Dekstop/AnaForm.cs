using System;
using System.Diagnostics.Tracing;
using System.Windows.Forms;
using Savas.Library.Concrete;

namespace Savas.Dekstop
{
    public partial class AnaForm : Form
    {
        private readonly Oyun _oyun;
        public AnaForm()
        {
            InitializeComponent();
            
            _oyun = new Oyun(UcakSavarPanel);
            _oyun.GecenSureDegisti += Oyun_GecenSureDegisti;
        }

        private void AnaForm_KeyDown(object sender, KeyEventArgs e)
        {
           switch(e.KeyCode)
            {
                case Keys.Enter:
                    _oyun.Baslat();
                    break;
                case Keys.Right:
                    _oyun.UCaksavariHareketEttir(Library.Enum.Yon.Saga);
                    break;
                case Keys.Left:
                    _oyun.UCaksavariHareketEttir(Library.Enum.Yon.Sola);
                    break;
                case Keys.Space:
                    _oyun.AtesEt();
                    break;

            }
        }

        private void Oyun_GecenSureDegisti(object sender, EventArgs e)
        {
            SureLabel.Text = _oyun.GecenSure.ToString(@"m\:ss");
        }
            
         
    }
}
