using FunctionSpace;
using RandomCheck.Sprites;
using System.Windows;

namespace RandomCheck
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly Calculation calculation;

        public MainWindow()
        {
            InitializeComponent();

            calculation = new Calculation(100000, 500);

            for (int i = 0; i < calculation.Graph.Length; i++)
            {
                double h = calculation.Graph[i];
                board.Children.Add(new HistoBar(h, i + 10));
            }

        }
    }
}
