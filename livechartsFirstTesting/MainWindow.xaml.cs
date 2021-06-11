using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LiveCharts;
using LiveCharts.Wpf;

namespace livechartsFirstTesting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Aaloo",
                    Values = new ChartValues<double>{1,2,3,4,5,6},
                }
            };
            SeriesCollection.Add(new ColumnSeries
            {
                Title = "bhaloo",
                Values = new ChartValues<double> { 2, 4, 5, 8, 6, 9 },
            });

            BarLabels = new string[] { "value1", "value2", "another", "next", "last", "actual last" };
            Formatter = value => value.ToString("N");
            DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; }
        public string[] BarLabels { get; }
        public Func<double, string> Formatter { get; set; }
    }
}
