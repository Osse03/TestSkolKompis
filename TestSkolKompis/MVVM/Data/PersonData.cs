using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSkolKompis.MVVM.Model;

namespace TestSkolKompis.MVVM.Data
{
    public class PersonData
    {
        // Detta är en metod som returnerar en lista med personer
        public List<Personer> GetPersoner()
        {
            return new List<Personer>
            {
                new Personer
                {
                    Namn = "Anna Svensson",
                    Ålder = 25,
                    Utbildning = "Civilingenjör",
                    Hobbys = new List<string> { "Läsa", "Promenader", "Gaming" },
                    Bild = "/Images/anna.jpg"

                },
                new Personer
                {
                    Namn = "Erik Johansson",
                    Ålder = 30,
                    Utbildning = "Ekonom",
                    Hobbys = new List<string> { "Fotboll", "Resa", "Spela gitarr" , "Fotografering"},
                    Bild = "/Images/erik.jpg"
                },
                new Personer
                {
                    Namn = "Lisa Karlsson",
                    Ålder = 22,
                    Utbildning = "Systemvetare",
                    Hobbys = new List<string> { "Simning", "Fotografering", "Programering" },
                    Bild = "/Images/lisa.jpg"

                },
                new Personer
                      {
                         Namn = "Filip Andersson",
                        Ålder = 27,
                          Utbildning = "Systemutvecklare",
                         Hobbys = new List<string> { "Programmera", "Gaming", "Laga mat" },
                         Bild = "/Images/filip.jpg"
                       },
                  new Personer
                     {
                          Namn = "Sofia Berg",
                         Ålder = 24,
                        Utbildning = "Psykolog",
                        Hobbys = new List<string> { "Yoga", "Läsa böcker", "Fotboll", "Promenader" },
                        Bild = "/Images/Sofia.jpg"
                       },
                     new Personer
                      {
                         Namn = "Johan Nilsson",
                         Ålder = 29,
                         Utbildning = "Lärare",
                          Hobbys = new List<string> { "Vandra", "Fotboll", "Kolla serier", "Gaming" },
                          Bild = "/Images/Johan.jpg"
                      },
                 new Personer
                     {
                        Namn = "Emma Persson",
                          Ålder = 21,
                        Utbildning = "Sjuksköterska",
                       Hobbys = new List<string> {  "Resa", "Baka", "Gaming", "Promenader" },
                        Bild = "/Images/Emma.jpg"
                       },
                  new Personer
                    {
                        Namn = "Markus Lund",
                        Ålder = 23,
                        Utbildning = "Marknadsföring",
                        Hobbys = new List<string> { "Fotografering", "Gym", "Fiska", "Gaming" },
                        Bild = "/Images/Markus.jpg"
                     },
                  new Personer
                  {
                      Namn = "Sara Eriksson",
                       Ålder = 26,
                       Utbildning = "Jurist",
                      Hobbys = new List<string> { "Läsa", "Resa", "Sy" },
                       Bild = "/Images/Sara.jpg"
                       },
                   new Personer
                   {
                       Namn = "Daniel Gustavsson",
                     Ålder = 28,
                     Utbildning = "Arkitekt",
                     Hobbys = new List<string> { "Rita", "Spela gitarr", "Bygga saker" },
                      Bild = "/Images/Daniel.jpg"
    }
                    };
        }
    }
}
