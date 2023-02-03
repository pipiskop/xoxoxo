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
using System.Threading;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace xoxo
{
    /// <summary>
    /// Логика взаимодействия для comp.xaml
    /// </summary>
    public partial class comp : Window
    {
        public comp()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            if (bt1.Content == null)
            {               
                    bt1.Content = "x";                    
            }
            WinCheking();
            MashineStep();
            WinCheking();
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            if (bt2.Content == null)
            {
                bt2.Content = "x";
            }
            WinCheking();
            MashineStep();
            WinCheking();
        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            if (bt3.Content == null)
            {
                bt3.Content = "x";
            }
            WinCheking();
            MashineStep();
            WinCheking();
        }

        private void bt4_Click(object sender, RoutedEventArgs e)
        {
            if (bt4.Content == null)
            {
                bt4.Content = "x";
            }
            WinCheking();
            MashineStep();
            WinCheking();
        }

        private void bt5_Click(object sender, RoutedEventArgs e)
        {
            if (bt5.Content == null)
            {
                bt5.Content = "x";
            }
            WinCheking();
            MashineStep();
            WinCheking();
        }

        private void bt6_Click(object sender, RoutedEventArgs e)
        {
            if (bt6.Content == null)
            {
                bt6.Content = "x";
            }
            WinCheking();
            MashineStep();
            WinCheking();
        }

        private void bt7_Click(object sender, RoutedEventArgs e)
        {
            if (bt7.Content == null)
            {
                bt7.Content = "x";
            }
            WinCheking();
            MashineStep();
            WinCheking();
        }

        private void bt8_Click(object sender, RoutedEventArgs e)
        {
            if (bt8.Content == null)
            {
                bt8.Content = "x";
            }
            WinCheking();
            MashineStep();
            WinCheking();
        }

        private void bt9_Click(object sender, RoutedEventArgs e)
        {
            if (bt9.Content == null)
            {
                bt9.Content = "x";
            }
            WinCheking();
            MashineStep();
            WinCheking();
        }
        public void WinCheking()
        {
            if (bt1.Content == "x" && bt2.Content == "x" && bt3.Content == "x") { text.Text = "Победили крестики";}
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
       public void MashineStep()
        {
        P:
            int sn = 0;
            Random rnd = new Random();
            sn = rnd.Next(1, 10);
            switch (sn)
            {
                case 1:
                    if (bt1.Content == null)
                    {
                        bt1.Content = "o";
                    }
                    else if(bt1.Content != null && bt2.Content != null && bt3.Content != null && bt4.Content != null 
                        && bt5.Content != null && bt6.Content != null && bt7.Content != null && bt8.Content != null && bt9.Content != null) { break; } else
                        goto P;
                    break;
                case 2:
                    if (bt2.Content == null)
                    {
                        bt2.Content = "o";
                    }
                    else if (bt1.Content != null && bt2.Content != null && bt3.Content != null && bt4.Content != null
                        && bt5.Content != null && bt6.Content != null && bt7.Content != null && bt8.Content != null && bt9.Content != null) { break; }
                    else goto P;
                    break;
                case 3:
                    if (bt3.Content == null)
                    {
                        bt3.Content = "o";
                    }
                    else if (bt1.Content != null && bt2.Content != null && bt3.Content != null && bt4.Content != null
                        && bt5.Content != null && bt6.Content != null && bt7.Content != null && bt8.Content != null && bt9.Content != null) { break; }
                    else goto P;
                    break;
                case 4:
                    if (bt4.Content == null)
                    {
                        bt4.Content = "o";
                    }
                    else if (bt1.Content != null && bt2.Content != null && bt3.Content != null && bt4.Content != null
                        && bt5.Content != null && bt6.Content != null && bt7.Content != null && bt8.Content != null && bt9.Content != null) { break; }
                    else goto P;
                    break;
                case 5:
                    if (bt5.Content == null)
                    {
                        bt5.Content = "o";
                    }
                    else if (bt1.Content != null && bt2.Content != null && bt3.Content != null && bt4.Content != null
                        && bt5.Content != null && bt6.Content != null && bt7.Content != null && bt8.Content != null && bt9.Content != null) { break; }
                    else goto P;
                    break;
                case 6:
                    if (bt6.Content == null)
                    {
                        bt6.Content = "o";
                    }
                    else if (bt1.Content != null && bt2.Content != null && bt3.Content != null && bt4.Content != null
                        && bt5.Content != null && bt6.Content != null && bt7.Content != null && bt8.Content != null && bt9.Content != null) { break; }
                    else goto P;
                    break;
                case 7:
                    if (bt7.Content == null)
                    {
                        bt7.Content = "o";
                    }
                    else if (bt1.Content != null && bt2.Content != null && bt3.Content != null && bt4.Content != null
                        && bt5.Content != null && bt6.Content != null && bt7.Content != null && bt8.Content != null && bt9.Content != null) { break; }
                    else goto P;
                    break;
                case 8:
                    if (bt8.Content == null)
                    {
                        bt8.Content = "o";
                    }
                    else if (bt1.Content != null && bt2.Content != null && bt3.Content != null && bt4.Content != null
                        && bt5.Content != null && bt6.Content != null && bt7.Content != null && bt8.Content != null && bt9.Content != null) { break; }
                    else goto P;
                    break;
                case 9:
                    if (bt9.Content == null)
                    {
                        
                        bt9.Content = "o";
                    }
                    else if (bt1.Content != null && bt2.Content != null && bt3.Content != null && bt4.Content != null
                        && bt5.Content != null && bt6.Content != null && bt7.Content != null && bt8.Content != null && bt9.Content != null) { break; }
                    else goto P;
                    break;

            }
        }
    }
}
