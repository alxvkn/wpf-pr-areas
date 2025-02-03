using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace pr
{
    /// <summary>
    /// Логика взаимодействия для Sphere.xaml
    /// </summary>
    public partial class Sphere : Page
    {
        public Sphere()
        {
            InitializeComponent();
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            string futuretext = (sender as TextBox).Text + e.Text;
            e.Handled = !Util.IsTextNumeric(futuretext);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var text_box = (TextBox)sender;
            if (text_box.Text.Length < 1) return;
            double r = Convert.ToDouble(text_box.Text);

            double area = 4 * Math.PI * r * r;
            double volume = Math.PI * r * r * r * 4 / 3;

            text_area.Text = area.ToString();
            text_volume.Text = volume.ToString();
        }

        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
