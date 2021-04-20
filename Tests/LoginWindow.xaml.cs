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
using Tests.Models;

namespace Tests
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void dreawme(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DragMove();
            }
            catch (Exception)
            {

            }
        }

        //Todo : Сделать окно регистрации, Вход и регистрацию пользователей реализовать 6,04,21
       
        /// <summary>
        /// Поменять все что тут положить в регистрацию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_User_Click(object sender, RoutedEventArgs e)
        {///Избавить точно от этого 
            string richText = new TextRange(RichTextbox_login.Document.ContentStart, RichTextbox_login.Document.ContentEnd).Text;
            string logintext = richText.Replace(Environment.NewLine, "");
           
            string richText2 = new TextRange(RichTextbox_login_Copy.Document.ContentStart, RichTextbox_login_Copy.Document.ContentEnd).Text;
            string passwordtext = richText2.Replace(Environment.NewLine, "");
            User user = new User(logintext, passwordtext);
            if (user.Check_Login(user))
            {
                MessageBox.Show("Успешный вход");
            }
           
           

        }

        private void Regiset_User_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            RegisterWindow register = new RegisterWindow();
            register.Show();
        }
    }
}
