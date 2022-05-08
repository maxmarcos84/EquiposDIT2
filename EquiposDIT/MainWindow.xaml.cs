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
using System.Windows.Navigation;
using System.Windows.Shapes;
using EquiposDIT.ViewModels;

namespace EquiposDIT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //SitioViewModel ViewModel;
        public MainWindow()
        {
            InitializeComponent();
            //ViewModel = new SitioViewModel();
            //this.DataContext = ViewModel;
        }     

        private void btnSitios_Click(object sender, RoutedEventArgs e)
        {

            DataContext = new SitioViewModel();
            
        }

        private void btnSectores_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new SectorViewModel();
        }     

        private void flp_Prestamos_IsFlippedChanged(object sender, RoutedPropertyChangedEventArgs<bool> e)
        {
            if (e.NewValue == true)
            {
                DataContext = new SitioViewModel();
                flp_Equipos.IsEnabled = false;
            }
            else
            {
                DataContext = null;
            }
        }

        private void flp_Equipos_IsFlippedChanged(object sender, RoutedPropertyChangedEventArgs<bool> e)
        {

        }

        private void flp_Sitios_IsFlippedChanged(object sender, RoutedPropertyChangedEventArgs<bool> e)
        {

        }
        //=> System.Diagnostics.Debug.WriteLine($"Card is flipped = {e.NewValue}");
    }
}
