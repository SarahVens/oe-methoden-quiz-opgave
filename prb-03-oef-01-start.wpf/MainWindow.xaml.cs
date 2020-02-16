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

namespace prb_03_oef_01_start.wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //variabelen
        int score;



        //Methodes
        //zichtbaarheid knoppen
        void ZichtbaarheidVraag1( Visibility zichtbaarheidVraag1)
        {
            wrpVraag1.Visibility = zichtbaarheidVraag1;
        }
        void ZichtbaarheidVraag2(Visibility zichtbaarheidVraag2)
        {
            wrpVraag2.Visibility = zichtbaarheidVraag2;
        }
        void ZichtbaarheidVraag3(Visibility zichtbaarheidVraag3)
        {
            wrpVraag3.Visibility = zichtbaarheidVraag3;
        }
        //beschikbaarheid knoppen
        void BeschikbaarheidKnoppenVraag1(bool beschikbaarheidVraag1)
        {
            wrpVraag1.IsEnabled = beschikbaarheidVraag1;
        }
        void BeschikbaarheidKnoppenVraag2(bool beschikbaarheidVraag2)
        {
            wrpVraag2.IsEnabled = beschikbaarheidVraag2;
        }
        void BeschikbaarheidKnoppenVraag3(bool beschikbaarheidVraag3)
        {
            wrpVraag3.IsEnabled = beschikbaarheidVraag3;
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ZichtbaarheidVraag2(Visibility.Hidden);
            ZichtbaarheidVraag3(Visibility.Hidden);
            btnOpnieuw.Visibility = Visibility.Hidden;

        }
        //vraag 1
        private void btnAntw1b_Click(object sender, RoutedEventArgs e)
        {
            ZichtbaarheidVraag2(Visibility.Visible);
            BeschikbaarheidKnoppenVraag1(false);
            lblFeedBack1.Content = "Dit antwoord is juist";
            score += 1;
            lblScore.Content = score.ToString();
        }

        private void btnAntw1a_Click(object sender, RoutedEventArgs e)
        {
            ZichtbaarheidVraag2(Visibility.Visible);
            BeschikbaarheidKnoppenVraag1(false);
            lblFeedBack1.Content = "Dit antwoord is fout";
        }
        private void btnAntw1c_Click(object sender, RoutedEventArgs e)
        {
            ZichtbaarheidVraag2(Visibility.Visible);
            BeschikbaarheidKnoppenVraag1(false);
            lblFeedBack1.Content = "Dit antwoord is fout";
        }
        //vraag2
        private void btnAntw2a_Click(object sender, RoutedEventArgs e)
        {
            ZichtbaarheidVraag3(Visibility.Visible);
            BeschikbaarheidKnoppenVraag2(false);
            lblFeedBack2.Content = "Dit antwoord is fout";
        }
        private void btnAntw2b_Click(object sender, RoutedEventArgs e)
        {
            ZichtbaarheidVraag3(Visibility.Visible);
            BeschikbaarheidKnoppenVraag2(false);
            lblFeedBack2.Content = "Dit antwoord is juist";
            score += 1;
            lblScore.Content = score.ToString();
        }

        private void btnAntw2c_Click(object sender, RoutedEventArgs e)
        {
            ZichtbaarheidVraag3(Visibility.Visible);
            BeschikbaarheidKnoppenVraag2(false);
            lblFeedBack2.Content = "Dit antwoord is fout";
        }
        // vraag3
        private void btnAntw3a_Click(object sender, RoutedEventArgs e)
        {
            btnOpnieuw.Visibility=Visibility.Visible;
            BeschikbaarheidKnoppenVraag3(false);
            lblFeedBack3.Content = "Dit antwoord is fout";
        }

        private void btnAntw3b_Click(object sender, RoutedEventArgs e)
        {
            btnOpnieuw.Visibility = Visibility.Visible;
            BeschikbaarheidKnoppenVraag3(false);
            lblFeedBack3.Content = "Dit antwoord is fout";
        }

        private void btnAntw3c_Click(object sender, RoutedEventArgs e)
        {
            btnOpnieuw.Visibility = Visibility.Visible;
            BeschikbaarheidKnoppenVraag3(false);
            lblFeedBack3.Content = "Dit antwoord is juist";
            score += 1;
            lblScore.Content = score.ToString();
        }
        //opnieuw
        private void btnOpnieuw_Click(object sender, RoutedEventArgs e)
        {
            ZichtbaarheidVraag2(Visibility.Hidden);
            ZichtbaarheidVraag3(Visibility.Hidden);
            BeschikbaarheidKnoppenVraag1(true);
            BeschikbaarheidKnoppenVraag2(true);
            BeschikbaarheidKnoppenVraag3(true);
            btnOpnieuw.Visibility = Visibility.Hidden;
            score = 0;
            lblScore.Content = score.ToString();
        }
    }
}
