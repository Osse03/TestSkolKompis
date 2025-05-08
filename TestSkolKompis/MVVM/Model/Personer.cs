using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSkolKompis.MVVM.Model
{
    public class Personer
    {
        public string Namn { get; set; }
        public int Ålder { get; set; }
        public string Utbildning { get; set; }
        public List<string> Hobbys { get; set; }
        public string Bild { get; set; }
    }
}
