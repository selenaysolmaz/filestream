using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filestream
{
    class Program
    {
        static void Main(string[] args)
        {
            string adres = @"C:\TestDizini\NewFile.txt";
            FileStream fs = new FileStream(adres, FileMode.OpenOrCreate);
            FileStream fs2 = new FileStream(adres, FileMode.Append,FileAccess.Write);
            FileStream fs3 = new FileStream(adres, FileMode.Truncate, FileAccess.Write,FileShare.None);
            //filestream akımının tamponunu temizler
            //hafızadaki tampon bölgedeki bilgileri hemen diske yazar.
            fs.Flush();
            //Filestream tarafından kullanılan kaynakları boşaltır.
            //tampon bölgeleri diske yazar serbesr bırakır.
            //sistem kaynaklarını serbest bırakıyor.
            //file close yapılmadan başkaları file i açıp işslem yapamaz.
            fs.Close();

        }
    }
}
