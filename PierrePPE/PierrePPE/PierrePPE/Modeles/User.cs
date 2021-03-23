using System;
using System.Collections.Generic;
using System.Text;

namespace PierrePPE.Modeles
{
    public class User
    {
        #region Attribut 
        private int _id;
        private string _username;
        private string _password;
        #endregion

        #region Constructeur
        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }
        #endregion

        #region Getter / Setter
        public int Id { get => _id; set => _id = value; }
        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        #endregion

        #region Methode
        public bool CheckInformation()
        {
            if (!this.Username.Equals("") && !this.Password.Equals(""))
                return true;
            else
                return false;
        }
        #endregion
    }

}
