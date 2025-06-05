using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace KretaClone.Views
{
    public partial class JegyekPage : Page
    {
        public ObservableCollection<Jegy> JegyekLista { get; set; } = new();

        public JegyekPage()
        {
            InitializeComponent();
            JegyekDataGrid.ItemsSource = JegyekLista;
        }

        private void HozzaadButton_Click(object sender, RoutedEventArgs e)
        {
            string tantargy = TantargyTextBox.Text;
            string jegySzoveg = JegyTextBox.Text;
            DateTime? datum = DatumPicker.SelectedDate;

            if (string.IsNullOrWhiteSpace(tantargy) || string.IsNullOrWhiteSpace(jegySzoveg) || !datum.HasValue)
            {
                MessageBox.Show("Kérlek, töltsd ki az összes mezőt!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (!int.TryParse(jegySzoveg, out int jegy) || jegy < 1 || jegy > 5)
            {
                MessageBox.Show("A jegynek 1 és 5 közötti számnak kell lennie.", "Hiba", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            JegyekLista.Add(new Jegy
            {
                Tantargy = tantargy,
                JegyErtek = jegy,
                Datum = datum.Value.ToShortDateString()
            });

            TantargyTextBox.Clear();
            JegyTextBox.Clear();
            DatumPicker.SelectedDate = DateTime.Now;
        }
    }

    public class Jegy
    {
        public string Tantargy { get; set; }
        public int JegyErtek { get; set; }
        public string Datum { get; set; }
    }
}