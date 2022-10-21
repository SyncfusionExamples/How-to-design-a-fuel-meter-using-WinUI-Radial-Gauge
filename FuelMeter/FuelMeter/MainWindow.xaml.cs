using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Media;
using Syncfusion.UI.Xaml.Gauges;
using Windows.UI;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace FuelMeter
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void NeedlePointer_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (e.Value >= 0 && e.Value <= 10)
            {
                _onFirstRangeColorChanged();
            }
            else if (e.Value >= 10 && e.Value <= 20)
            {
                _onSecondRangeColorChanged();
            }
            else if (e.Value >= 20 && e.Value <= 30)
            {
                _onThirdRangeColorChanged();
            }
            else if (e.Value >= 30 && e.Value <= 40)
            {
                _onFourthRangeColorChanged();
            }
            else if (e.Value >= 40 && e.Value <= 50)
            {
                _onFifthRangeColorChanged();
            }
            else if (e.Value >= 50 && e.Value <= 60)
            {
                _onSixthRangeColorChanged();
            }
            else if (e.Value >= 60 && e.Value <= 70)
            {
                _onSeventhRangeColorChanged();
            }
            else if (e.Value >= 70 && e.Value <= 80)
            {
                _onEighthRangeColorChanged();
            }
            else if (e.Value >= 80 && e.Value <= 90)
            {
                _onNinethRangeColorChanged();
            }
            else if (e.Value >= 90 && e.Value <= 100)
            {
                _onTenthRangeColorChanged();
            }
        }

        void _onFirstRangeColorChanged()
        {
            range1.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
            range2.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range3.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range4.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range5.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range6.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range7.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range8.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range9.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range10.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
        }

        void _onSecondRangeColorChanged()
        {
            range1.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range2.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
            range3.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range4.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range5.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range6.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range7.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range8.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range9.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range10.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
        }

        void _onThirdRangeColorChanged()
        {
            range1.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range2.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range3.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
            range4.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range5.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range6.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range7.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range8.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range9.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range10.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
        }

        void _onFourthRangeColorChanged()
        {
            range1.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range2.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range3.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range4.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
            range5.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range6.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range7.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range8.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range9.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range10.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
        }

        void _onFifthRangeColorChanged()
        {
            range1.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range2.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range3.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range4.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range5.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
            range6.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range7.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range8.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range9.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range10.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
        }

        void _onSixthRangeColorChanged()
        {
            range1.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range2.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range3.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range4.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range5.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range6.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
            range7.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range8.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range9.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range10.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
        }

        void _onSeventhRangeColorChanged()
        {
            range1.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range2.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range3.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range4.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range5.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range6.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range7.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
            range8.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range9.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range10.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
        }

        void _onEighthRangeColorChanged()
        {
            range1.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range2.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range3.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range4.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range5.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range6.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range7.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range8.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
            range9.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range10.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
        }

        void _onNinethRangeColorChanged()
        {
            range1.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range2.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range3.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range4.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range5.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range6.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range7.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range8.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range9.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
            range10.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
        }

        void _onTenthRangeColorChanged()
        {
            range1.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range2.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range3.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range4.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range5.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range6.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range7.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range8.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range9.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            range10.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
        }
    }
}
