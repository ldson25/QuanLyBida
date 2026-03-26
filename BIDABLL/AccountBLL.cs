using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIDADAL;
using BIDADTO;
namespace BIDABLL
{
    public class AccountBLL
    {
        public bool Login(string username, string password)
        {
            return AccountDAO.Instance.Login(username, password);
        }

        public Account GetAccountByUserName(string userName)
        {
            return AccountDAO.Instance.GetAccountByUserName(userName);
        }
    }
}
