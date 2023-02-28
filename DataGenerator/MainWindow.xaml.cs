using DataGenerator.Generation.Settings;
using System.Windows;

namespace DataGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var settings = new DataSettingsCollection();            
            BaseData baseData = new BaseData(15, settings);
            baseData.GenerateData();
        }
    }
}
