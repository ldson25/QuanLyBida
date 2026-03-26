using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BIDADTO
{
    public class Account
    {
        public Account() { }

        public Account(string userName, string displayName, int type, string password = null)
        {
            this.UserName = userName;
            this.DisplayName = displayName;
            this.Type = type;
            this.Password = password;
        }

        public Account(DataRow row)
        {
            this.UserName = row["USERNAME"].ToString();
            this.DisplayName = row["DISPLAYNAME"].ToString();
            this.Type = (int)row["TYPE"];
            this.Password = row["PASSWORD"].ToString();
        }

        private int type;
        private string password;
        private string displayName;
        private string userName;

        public int Type { get => type; set => type = value; }
        public string Password { get => password; set => password = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public string UserName { get => userName; set => userName = value; }
    }
}
