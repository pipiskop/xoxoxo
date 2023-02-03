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

namespace xoxo
{
    /// <summary>
    /// Логика взаимодействия для Pleers.xaml
    /// </summary>
    public partial class Pleers : Window
    {
        bool krest = true;
        public Pleers()
        {
            InitializeComponent();
            
           

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          if (bt1.Content == null)
            {
                if (krest == true)
                {
                    bt1.Content = "x";
                    krest = false;
                }else
                {
                    bt1.Content = "o";
                    krest = true;
                }
            }
            WinCheking();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (bt5.Content == null)
            {
                if (krest == true)
                {
                    bt5.Content = "x";
                    krest = false;
                }
                else
                {
                    bt5.Content = "o";
                    krest = true;
                }
            }
            WinCheking(); 
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (bt4.Content == null)
            {
                if (krest == true)
                {
                    bt4.Content = "x";
                    krest = false;
                }
                else
                {
                    bt4.Content = "o";
                    krest = true;
                }
            }
            WinCheking();
            }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (bt3.Content == null)
            {
                if (krest == true)
                {
                    bt3.Content = "x";
                    krest = false;
                }
                else
                {
                    bt3.Content = "o";
                    krest = true;
                }
            }
            WinCheking(); 
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (bt2.Content == null)
            {
                if (krest == true)
                {
                    bt2.Content = "x";
                    krest = false;
                }
                else
                {
                    bt2.Content = "o";
                    krest = true;
                }
            }
            WinCheking();  
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (bt6.Content == null)
            {
                if (krest == true)
                {
                    bt6.Content = "x";
                    krest = false;
                }
                else
                {
                    bt6.Content = "o";
                    krest = true;
                }
            }
            WinCheking();   
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (bt7.Content == null)
            {
                if (krest == true)
                {
                    bt7.Content = "x";
                    krest = false;
                }
                else
                {
                    bt7.Content = "o";
                    krest = true;
                }
            }
            WinCheking();
            }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (bt9.Content == null)
            {
                if (krest == true)
                {
                    bt9.Content = "x";
                    krest = false;
                }
                else
                {
                    bt9.Content = "o";
                    krest = true;
                }
            }
            WinCheking();
           }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (bt8.Content == null)
            {
                if (krest == true)
                {
                    bt8.Content = "x";
                    krest = false;
                }
                else
                {
                    bt8.Content = "o";
                    krest = true;
                }
            }
            WinCheking();
        }

        public void WinCheking()
        {
            if (bt1.Content == "x" && bt2.Content == "x" && bt3.Content == "x") { text.Text = "Победили крестики"; }
            if (bt1.Content == "o" && bt2.Content == "o" && bt3.Content == "o") { text.Text = "Победили  нолики"; }
            if (bt4.Content == "x" && bt5.Content == "x" && bt6.Content == "x") { text.Text = "Победили крестики"; }
            if (bt4.Content == "o" && bt5.Content == "o" && bt6.Content == "o") { text.Text = "Победили  нолики"; }
            if (bt7.Content == "x" && bt8.Content == "x" && bt9.Content == "x") { text.Text = "Победили крестики"; }
            if (bt7.Content == "o" && bt8.Content == "o" && bt9.Content == "o") { text.Text = "Победили  нолики"; }
            if (bt1.Content == "x" && bt5.Content == "x" && bt9.Content == "x") { text.Text = "Победили крестики"; }
            if (bt1.Content == "o" && bt5.Content == "o" && bt9.Content == "o") { text.Text = "Победили  нолики"; }
            if (bt3.Content == "x" && bt5.Content == "x" && bt7.Content == "x") { text.Text = "Победили крестики"; }
            if (bt3.Content == "o" && bt5.Content == "o" && bt7.Content == "o") { text.Text = "Победили  нолики"; }
            if (bt1.Content == "x" && bt4.Content == "x" && bt7.Content == "x") { text.Text = "Победили крестики"; }
            if (bt1.Content == "o" && bt4.Content == "o" && bt7.Content == "o") { text.Text = "Победили  нолики"; }
            if (bt2.Content == "x" && bt5.Content == "x" && bt8.Content == "x") { text.Text = "Победили крестики"; }
            if (bt2.Content == "o" && bt5.Content == "o" && bt8.Content == "o") { text.Text = "Победили  нолики"; }
            if (bt3.Content == "x" && bt6.Content == "x" && bt9.Content == "x") { text.Text = "Победили крестики"; }
            if (bt3.Content == "o" && bt6.Content == "o" && bt9.Content == "o") { text.Text = "Победили  нолики"; }
            if (bt1.Content != null && bt2.Content != null && bt3.Content != null && bt4.Content != null && bt5.Content != null && bt6.Content != null && bt7.Content != null && bt8.Content != null && bt9.Content != null) { text.Text = "Ничья"; }
            
        }
    }
}
