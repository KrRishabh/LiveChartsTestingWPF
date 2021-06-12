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
            
            FirstSeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Person 1",
                    Values = new ChartValues<double>{1,2,3,4,5,6},
                }
            };
            FirstSeriesCollection.Add(new ColumnSeries
            {
                Title = "Person 2",
                Values = new ChartValues<double> { 2, 4, 5, 8, 6, 9 },
            });

            BarLabels = new string[] { "value1", "value2", "another", "next", "last", "actual last" };
            Formatter = value => value.ToString("N");
            DataContext = this;
            LineChartSeriesCollection = new SeriesCollection();
            LineChartSeriesCollection.Add(new LineSeries
            {
                Title = "hmmm",
                Values = new ChartValues<double> { 1, 5, 4, 8 }
            });
            LineChartSeriesCollection.Add( new LineSeries { Title= "asdf",
            Values = new ChartValues<double> { 5,3,7,9},
            }
            );
            
        }

        public SeriesCollection FirstSeriesCollection { get; }
        public SeriesCollection LineChartSeriesCollection { get; }
        public string[] BarLabels { get; }
        public Func<double, string> Formatter { get; set; }
    }
}
