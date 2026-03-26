using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIDADTO;
namespace BIDADAL
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                return instance;
            }
        }

        private AccountDAO() { }

        public bool Login(string username, string password)
        {
            string query = "SELECT * FROM ACCOUNT WHERE USERNAME = @user AND PASSWORD = @pass";
            DataTable result = DataProvider.Instance.ExcuteQuery(query, new object[] { username, password });

            return result.Rows.Count > 0;
        }

        public Account GetAccountByUserName(string username)
        {
            string query = "EXEC USP_GETACCOUNTBYUSERNAME @USERNAME";

            DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { username });

            if (data.Rows.Count > 0)
            {
                return new Account(data.Rows[0]);
            }

            return null;
        }
    }
}
