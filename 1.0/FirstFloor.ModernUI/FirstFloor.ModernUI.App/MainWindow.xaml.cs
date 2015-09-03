using FirstFloor.ModernUI.Windows.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FirstFloor.ModernUI.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ModernWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            TitleLinks.Add(new Presentation.Link { DisplayName = "home", Source = new Uri("/Pages/Introduction.xaml", UriKind.Relative) });
            TitleLinks.Add(new Presentation.Link { DisplayName = "Layout", Source = new Uri("/Pages/LayoutWireframe.xaml", UriKind.Relative) });
            TitleLinks.Add(new Presentation.Link { DisplayName = "Ctrl", Source = new Uri("/Pages/ControlsModern.xaml", UriKind.Relative) });
            TitleLinks.Add(new Presentation.Link { DisplayName = "Adv", Source = new Uri("/Pages/Navigation.xaml", UriKind.Relative) });
            TitleLinks.Add(new Presentation.Link { DisplayName = "Color", Source = new Uri("/Pages/Settings.xaml", UriKind.Relative) });
            TitleLinks.Add(new Presentation.Link { DisplayName = "WEB", Source = new Uri("https://github.com/standard-software/mui", UriKind.Absolute) });
        }
    }
}
