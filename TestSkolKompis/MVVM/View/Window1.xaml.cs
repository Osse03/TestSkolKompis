using System;
using System.Linq;
using System.Windows;
using System.Windows.Media.Imaging;
using TestSkolKompis.MVVM.Data; 
using TestSkolKompis.MVVM.Model;

namespace TestSkolKompis.MVVM.View
{
    public partial class Window1 : Window
    {
        
        public Window1()
        {
            InitializeComponent();
            VisaRandomPerson();
        }

        private void VisaRandomPerson()
        {
            var personData = new PersonData();
            var personer = personData.GetPersoner();

            var random = new Random();
            var valdPerson = personer[random.Next(personer.Count)];

            // Textdata
            PersonNamn.Text = $"Namn: {valdPerson.Namn}";
            PersonÅlder.Text = $"Ålder: {valdPerson.Ålder}";
            PersonUtbildning.Text = $"Utbildning: {valdPerson.Utbildning}";
            PersonHobbys.Text = $"Hobbys: {string.Join(", ", valdPerson.Hobbys)}";

            // Bild
            PersonBild.Source = new BitmapImage(new Uri(valdPerson.Bild, UriKind.Relative));
        }

    }
}
