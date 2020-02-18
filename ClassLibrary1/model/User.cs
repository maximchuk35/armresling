using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.model
{
   public class User
    {
        public string Name { get;}
        public Gender Gender { get; }
        
        public DateTime Birthdate { get; }
        public double Weight { get; set; }

        public double Height { get; set; }

        public User(string name,
            Gender gender,
            DateTime birthDate,
            double weight,
            double height)
        {
            #region proverka ymov
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("imja ne moshe botu pystum abo nujakum", nameof(name));
            }

            if (gender == null)
            {
                throw new ArgumentNullException("pol ne moshe botu pystum abo nujakum", nameof(gender));
            }
            if (birthDate < DateTime.Parse("01.01.1900") || birthDate >= DateTime.Now)
            {
                throw new ArgumentNullException("nemosh takoe pusatu", nameof(birthDate));
            }

            if (weight <= 0)
            {
                throw new ArgumentNullException("vaga nemoshe botu mensha abo  nujaka ", nameof(weight));
            }

            if (height <= 0)
            {
                throw new ArgumentNullException("rost nemoshe botu mensha abo  nujaka ", nameof(height));
            }
            #endregion
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
