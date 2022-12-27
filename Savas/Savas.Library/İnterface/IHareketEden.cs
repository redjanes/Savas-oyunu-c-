using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Savas.Library.Enum;

namespace Savas.Library.İnterface
{
    internal interface IHareketEden
    {
        Size HareketAlaniBoyutlari { get; }
        
        int HareketMesafesi { get; }
        
        /// <summary>
       /// Cismi istenen yönde hareket ettirir
       /// </summary>
       /// <param name="yon">Hangi yöne hareket edileceği</param>
       /// <returns>Cisim duvara çarparsa true döndürür</returns>
        bool HareketEttir(Yon yon);
    }
}
