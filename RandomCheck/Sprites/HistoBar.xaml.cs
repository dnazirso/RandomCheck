using System.Windows.Controls;

namespace RandomCheck.Sprites
{
    /// <summary>
    /// Interaction logic for HistoBar.xaml
    /// </summary>
    public partial class HistoBar : UserControl
    {
        public HistoBar(double height, double x)
        {
            InitializeComponent();

            bar.Height = height;

            SetValue(Canvas.BottomProperty, 0.0);
            SetValue(Canvas.LeftProperty, x);
        }
    }
}
