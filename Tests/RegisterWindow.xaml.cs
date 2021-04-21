using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Tests.Models;

namespace Tests
{
    /// <summary>
    /// Логика взаимодействия для RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
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


        private void Back_Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void Register_Button_Click(object sender, RoutedEventArgs e)
        {
            bool flag = true;
        
            string richText = new TextRange(RichTextbox_login.Document.ContentStart, RichTextbox_login.Document.ContentEnd).Text;
            string logintext = richText.Replace(Environment.NewLine, " ");
            string richText2 = new TextRange(RichTextbox_Registration_Paswword.Document.ContentStart, RichTextbox_Registration_Paswword.Document.ContentEnd).Text;            
            string passwordtext = richText2.Replace(Environment.NewLine, " ");
            if (logintext.Length<=3 )
            {
                MessageBox.Show("Вы не корректные данные в логине");
                flag = false;
                RichTextbox_login.BorderBrush = Brushes.Red;
            }
            if(passwordtext.Length <= 3)
            {
                MessageBox.Show("Вы не корректные данные в пароле");
                flag = false;
                RichTextbox_Registration_Paswword.BorderBrush = Brushes.Red;
            }
            if (flag)
            {
                User user = new User(logintext, passwordtext);
                if (user.Check_Register(user))
                {
                    user.AddUser(user);
                    MessageBox.Show("Успешная Регистрация");
                }
            }
            
           
        }
    }
}
