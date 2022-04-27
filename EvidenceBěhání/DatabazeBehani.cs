using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenceBěhání
{
    class DatabazeBehani
    {
        public ObservableCollection<BehVykon> behani_db;

        public DatabazeBehani()
        {
            behani_db = new ObservableCollection<BehVykon>();
        }

        public void Vlozit(BehVykon behVykonItem) 
        {
            behani_db.Add(behVykonItem);
        }

        public void Smazat(BehVykon behVykonItem)
        {
            behani_db.Remove(behVykonItem);
        }

        public double Souhrn()
        {
            double finalSum = 0;
            foreach (var item in behani_db)
            {
                finalSum += item.Delka;
            }
            return finalSum;
        }

        public void Export()
        {
            FileStream stream = new FileStream(@"C:\export.txt", FileMode.OpenOrCreate);
            using (var streamWriter = new StreamWriter(stream, Encoding.UTF8))
            {
                foreach (var item in behani_db)
                {
                    streamWriter.Write(item.Nazev.ToString() + ";");
                    streamWriter.Write(item.Delka.ToString() + ";");
                    streamWriter.Write(item.Datum.ToString() + ";");
                    streamWriter.Write(item.Cas.ToString() + ";");
                    streamWriter.WriteLine();
                }
            }

        }
    }
}
