using System.Windows.Forms;
using Savas.Library.Concrete;

namespace Savas.Dekstop
{
    public partial class AnaForm : Form
    {
        private readonly Oyun _oyun= new Oyun();
        public AnaForm()
        {
            InitializeComponent();
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
    }
}
