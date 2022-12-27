using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Savas.Library.Enum;
using Savas.Library.İnterface;

namespace Savas.Library.Abstract
{
    internal class Cisim:PictureBox,IHareketEden
    {

        public Size HareketAlaniBoyutlari { get; }
        public int HareketMesafesi { get; protected set; }

        public new int Right
        {
            get => base.Right; 
            set => Left = value - Width;
        }

        public new int Bottom
        {
            get=>base.Bottom; 
            set=> Top = value - Height;
        }

        public int Center
        {
            get => Left + Width / 2;
            set=>Left=value - Width / 2;
        }

        public int Middle
        {
            get => Top + Height / 2;
            set=>Top=value - Height / 2;
        }
        protected Cisim(Size hareketAlaniBoyutlari)
        {
            Image = Image.FromFile($@"Gorseller\{GetType().Name}.png");
            HareketAlaniBoyutlari = hareketAlaniBoyutlari;
            SizeMode = PictureBoxSizeMode.AutoSize;
        }

        
        public bool HareketEttir(Yon yon)
        {
            switch (yon)
            {
                case Yon.Yukari:
                    return YukariHareketEttir();
                case Yon.Saga:
                    return SagaHareketEttir();
                case Yon.Asagi:
                    return AsagıHareketEttir();
                case Yon.Sola:
                    return SolaHareketEttir();
                default:
                    throw new ArgumentOutOfRangeException(nameof(yon), yon, null);
            }
        }

        private bool SolaHareketEttir()
        {
            if (Left == 0) return true;

            var yeniLeft = Left - HareketMesafesi;
            var TasacakMi = yeniLeft < 0;
            Left = TasacakMi ? 0 : yeniLeft;

            return Left == 0;
        }

        private bool AsagıHareketEttir()
        {
            if (Bottom == HareketAlaniBoyutlari.Height) return true;

            var YeniBottom = Right + HareketMesafesi;
            var TasacakMi = YeniBottom > HareketAlaniBoyutlari.Height;

            Bottom = TasacakMi ? HareketAlaniBoyutlari.Height :YeniBottom;

            return Bottom == HareketAlaniBoyutlari.Height;
        }

        private bool SagaHareketEttir()
        {
            if(Right==HareketAlaniBoyutlari.Width) return true;

            var YeniRight = Right + HareketMesafesi;
            var TasacakMi = YeniRight > HareketAlaniBoyutlari.Width;

            Right = TasacakMi ? HareketAlaniBoyutlari.Width : YeniRight;
            
            return Right == HareketAlaniBoyutlari.Width;
        }

        private bool YukariHareketEttir()
        {
            if (Top == 0) return true;

            var yeniTop = Top - HareketMesafesi;
            var TasacakMi = yeniTop < 0;
            Top = TasacakMi ? 0 : yeniTop;

            return Top == 0;
        }
    }
}
