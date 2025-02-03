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

namespace pr
{
    /// <summary>
    /// Логика взаимодействия для Cone.xaml
    /// </summary>
    public partial class Cone : Page
    {
        public Cone()
        {
            InitializeComponent();
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e) {
            string futuretext = (sender as TextBox).Text + e.Text;
            e.Handled = !Util.IsTextNumeric(futuretext);
        }

        private void input_r_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (input_r.Text.Length < 1 || input_h.Text.Length < 1) return;
            double r = Convert.ToDouble(input_r.Text);
            double h = Convert.ToDouble(input_h.Text);

            double base_area = Math.PI * r * r;
            text_base_area.Text = base_area.ToString();

            double l = Math.Sqrt(r * r + h * h);
            double side_area = Math.PI * l * r;
            text_side_area.Text = side_area.ToString();

            double total_area = base_area + side_area;
            text_total_area.Text = total_area.ToString();

            double volume = base_area * h / 3;
            text_volume.Text = volume.ToString();
        }

        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
