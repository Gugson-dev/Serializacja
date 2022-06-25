using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serializacja
{
    public class Osoba
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Wiek { get; set; }
        public void Save(string nazwaPliku)
        {
            using (var stream = new FileStream(nazwaPliku, FileMode.Create))
            {
                var XML = new XmlSerializer(typeof(Osoba));
                XML.Serialize(stream, this);
            }
        }
        public static Osoba Load(string nazwaPliku)
        {
            using (var stream = new FileStream(nazwaPliku, FileMode.Open))
            {
                var XML = new XmlSerializer(typeof(Osoba));
                return (Osoba)XML.Deserialize(stream);
            }
        }
    }
}
