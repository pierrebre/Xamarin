using System;
using System.Collections.Generic;
using System.Text;

namespace PierrePPE.Modeles
{
    public class Token
    {
        #region Attribut
        private int _id;
        private string access_token;
        private string error_description;
        private DateTime expire_date;
        #endregion

        #region Constructeur
        public Token() { }
        #endregion

        #region Getter / Setter
        public int Id { get => _id; set => _id = value; }
        public string Access_token { get => access_token; set => access_token = value; }
        public string Error_description { get => error_description; set => error_description = value; }
        public DateTime Expire_date { get => expire_date; set => expire_date = value; }
        #endregion


    }
}
