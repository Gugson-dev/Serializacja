using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serializacja
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba1 = new Osoba();
            osoba1.Imie = "Daniel";
            osoba1.Nazwisko = "Szypniewski";
            osoba1.Wiek = 21;
            osoba1.Save("DaneOsobowe.xml");
            Osoba wczytaj = Osoba.Load("DaneOsobowe.xml");
        }
    }
}