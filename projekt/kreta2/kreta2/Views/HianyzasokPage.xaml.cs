using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace KretaClone.Views
{
    public partial class HianyzasokPage : Page
    {
        public ObservableCollection<Hianyzas> HianyzasLista { get; set; } = new();

        public HianyzasokPage()
        {
            InitializeComponent();
            DataContext = this;
            HianyzasokDataGrid.ItemsSource = HianyzasLista;
        }

        private void HozzaadButton_Click(object sender, RoutedEventArgs e)
        {
            string tantargy = TantargyTextBox.Text;
            DateTime? datum = DatumPicker.SelectedDate;
            string megjegyzes = MegjegyzesTextBox.Text;

            if (string.IsNullOrWhiteSpace(tantargy) || !datum.HasValue)
            {
                MessageBox.Show("Kérlek, töltsd ki a tantárgyat és a dátumot!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            HianyzasLista.Add(new Hianyzas
            {
                Tantargy = tantargy,
                Datum = datum.Value,
                Megjegyzes = megjegyzes
            });

            TantargyTextBox.Clear();
            MegjegyzesTextBox.Clear();
            DatumPicker.SelectedDate = DateTime.Now;
        }
    }

    public class Hianyzas
    {
        public string Tantargy { get; set; }
        public DateTime Datum { get; set; }
        public string Megjegyzes { get; set; }
    }
}