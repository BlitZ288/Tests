using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using Tests.RepositoryModels;

namespace Tests.Models
{
   public  class User
    {
        public int Id { get; set;}
        /// <summary>
        /// Логин
        /// </summary>
        public string Login { get; set;}
        public string Password { get; set;}
        public int Rang { get; set;}
        public int MaxAnswer { get; set;}
       

        public User() { }
        public User(string login , string password)
        {
            Login = login;
            Password = password;
          
           
        }
        /// <summary>
        /// Добовление пользователя
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool AddUser(User user)
        {
            if (Check_Register(user))
            {
                using (MyDbContext context = new MyDbContext())
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                }
                return true;
            }
            else
            {
                return false;
            }        
         
        }
        /// <summary>
        /// Это проверка но можно доделать 
        /// </summary>
        /// <param name="user"></param>
        public bool Check_Register(User user)
        {
            using (MyDbContext context = new MyDbContext())
            {
                var dbUse = context.Users.Where(p => p.Login == user.Login);
                var firstuser = dbUse.FirstOrDefault()?.Login;
                if (firstuser == null)
                {
                    return true;
                }else
                {
                    MessageBox.Show("Такой пользователь есть");
                    return false;
                }
            }
        }
        public bool Check_Login(User user)
        {
            using (MyDbContext context = new MyDbContext())
            {
                var dbUse = context.Users.Where(p => p.Login == user.Login);
                var firstuser = dbUse.FirstOrDefault()?.Login;
                if (firstuser == null)
                {
                    MessageBox.Show("Такой не найден пользователь есть");
                    return false;
                }
                else
                {
                    
                    return true;
                }
            }
        }

    }
}
