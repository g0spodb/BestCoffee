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
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WPFBestCoffee
{
    /// <summary>
    /// Логика взаимодействия для CoffeePage.xaml
    /// </summary>
    public partial class CoffeePage : Page
    {
        public static Model.Coffee constProd;
        public CoffeePage(Model.Coffee n)
        {
            InitializeComponent();
            constProd = n;
            this.DataContext = constProd;
            tb_name.Text = n.Name;
            tb_instructions.Text = n.Name;

        }
        void OvalForm(Button btn)
        {
            GraphicsPath gp = new GraphicsPath();
            Graphics g = CreateGraphics();

            //Создаем новый прямоуголник с размерами кнопки
            System.Drawing.Rectangle rect = btn.ClientRectangle;

            //уменьшаем размеры прямоуголника
            rect.Inflate(-3, -3);

            //создаем эллипс
            gp.AddEllipse(rect);
            btn.Region = new Region(gp);

            //рисуем рамку для овальной кнопки
            g.DrawEllipse(new System.Drawing.Pen(System.Drawing.Color.Black, 2),
            btn.Left + 1, btn.Top + 1,
            btn.Width - 3, btn.Height - 3);

            //высвобождаем память
            g.Dispose();
        }
        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            n.favorite == true;
        }

    }
}
