using SampleBankingApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagKnowledge.Git.CreditDebit
{
    public static class CreditDebitOperations
    {
        public static int ValidateUser(string userName, string password, bool isCurrent)
        {
            using (MagDBEntities dbEntities = new MagDBEntities())
            {
                int id = dbEntities.UserDetails.Where(p => p.UserName == userName && p.Password == password).Select(p => p.Id).FirstOrDefault();
                if (id > 0)
                {
                    int balance = dbEntities.AccountInformations.Where(p => p.UserId == id && p.IsCurrent== isCurrent).Select(p => p.Id).FirstOrDefault();
                    return balance;
                }
                else
                {
                    return 0;
                }

            }
        }

        public static bool CreditDebitAmount(int accountId, bool IsCredit, string balance)
        {
            using (MagDBEntities dbEntities = new MagDBEntities())
            {
                AccountInformation info = dbEntities.AccountInformations.Where(p => p.Id == accountId).FirstOrDefault();
                if (info != null)
                {
                    if (IsCredit)
                        info.Balance = info.Balance + Convert.ToDouble(balance);
                    else
                        info.Balance = info.Balance - Convert.ToDouble(balance);

                    dbEntities.SaveChanges();
                    return true
                        ;
                }
                else
                { return false; }
            }
        }
    }
}
