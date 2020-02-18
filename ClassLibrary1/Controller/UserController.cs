using ClassLibrary1.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace ClassLibrary1.Controller
{
    public class UserController
    {
        public User User { get; }
        public UserController(string userName, string genderName,DateTime birthDay, double weight, double height)
        {
            // provetka 
            var gender = new Gender(genderName);
            User = new User(userName, gender, birthDay, weight, height);
            
        }
        public UserController()
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {

                if (formatter.Deserialize(fs) is User user)
                {
                    User = user;
                }

                // sho robutu xit joho ne pro4utalu?

            }
        }


        #region soxranenia i zagryzda
        //soxranaeme 
        public void Save()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {

                formatter.Serialize(fs, User);

            }
        }
        // poly4aeme
        
        #endregion
    }
}
