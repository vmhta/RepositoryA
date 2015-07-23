using SampleBankingApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagKnowledge.Git.BalanceDetails
{
    public static class BalanceOperations
    {
        public static double CheckBalance(string userName, string password, bool isCurrent)
        {
            using (MagDBEntities dbEntities = new MagDBEntities())
            {
                int id = dbEntities.UserDetails.Where(p => p.UserName == userName && p.Password == password).Select(p => p.Id).FirstOrDefault();
                if (id != null && id > 0)
                {
                    double balance = dbEntities.AccountInformations.Where(p => p.UserId == id && p.IsCurrent==isCurrent).Select(p => p.Balance).FirstOrDefault();
                    return balance;
                }
                else
                {
                    return 0;
                }
            }
        }


    }
}
