using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media.Imaging;
using TestSkolKompis.MVVM.Data;
using TestSkolKompis.MVVM.Model;

namespace TestSkolKompis.MVVM.View
{
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            LaddaPersoner();
        }

        private void LaddaPersoner()
        {
            var personData = new PersonData();
            var personer = personData.GetPersoner();

            var listItems = personer.Select(p => new
            {
                Namn = p.Namn,
                Ålder = $"Ålder: {p.Ålder}",
                Utbildning = $"Utbildning: {p.Utbildning}",
                Hobbys = $"Hobbys: {string.Join(", ", p.Hobbys)}",
                Bild = p.Bild
            }).ToList();

            PersonList.ItemsSource = listItems;
        }
    }
}
