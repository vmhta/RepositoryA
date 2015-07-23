using SampleBankingApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagKnowledge.Git.AccountDetails
{
    public static class AccountOperations
    {
        public static bool AddAccountDetails(string userName, string password,bool isCurrent)
        {
            using(MagDBEntities dbentities = new MagDBEntities())
            {
                UserDetail detail = new UserDetail();
                detail.UserName = userName;
                detail.Password=password;
                dbentities.UserDetails.Add(detail);
                dbentities.SaveChanges();

                AccountInformation info = new AccountInformation();
                info.IsCurrent=isCurrent;
                info.Balance=10000;
                info.UserId=detail.Id;
                dbentities.AccountInformations.Add(info);
                dbentities.SaveChanges();
                return true;
            }
        }

    }
}
