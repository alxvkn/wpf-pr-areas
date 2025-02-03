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
    /// Логика взаимодействия для TruncatedCone.xaml
    /// </summary>
    public partial class TruncatedCone : Page
    {
        public TruncatedCone()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void input_r_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (
                input_r1.Text.Length < 1
                || input_r2.Text.Length < 1
                || input_h.Text.Length < 1) return;

            double r1 = double.Parse(input_r1.Text);
            double r2 = double.Parse(input_r2.Text);
            double h = double.Parse(input_h.Text);

            double l = Math.Sqrt((r1 - r2) * (r1 - r2) + (h * h));

            double base1_area = Math.PI * r1 * r1;
            text_base1_area.Text = base1_area.ToString();

            double base2_area = Math.PI * r2 * r2;
            text_base2_area.Text = base2_area.ToString();

            double side_area = Math.PI * l * (r1 + r2);
            text_side_area.Text = side_area.ToString();

            double volume = Math.PI / 3 * h * ((r1 * r1) + r1 * r2 + (r2 * r2));
            text_volume.Text = volume.ToString();
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = Util.IsTextNumeric(e.Text);
        }
    }
}
