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
    /// Логика взаимодействия для Cylinder.xaml
    /// </summary>
    public partial class Cylinder : Page
    {
        public Cylinder()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void input_r_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (input_r.Text.Length < 1 || input_h.Text.Length < 1) return;
            double r = Convert.ToDouble(input_r.Text);
            double h = Convert.ToDouble(input_h.Text);

            double base_area = r * r;
            text_base_area.Text = base_area.ToString();

            double side_area = 2 * r * h;
            text_side_area.Text = side_area.ToString();

            double total_area = 2 * base_area + side_area;
            text_total_area.Text = total_area.ToString();

            double volume = Math.PI * r * r * h;
            text_volume.Text = volume.ToString();
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = Util.IsTextNumeric(e.Text);
        }
    }
}
