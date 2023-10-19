using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPDemo
{
    interface IUser
    {
        bool Login(string username, string password);
        bool Register(string username, string password,string email);
        //void LogError(string error);
        //bool SendEmail(string emailContent);


        //We can see LogError and SendEmail should not be a part of IUser because User object should be able to perform only login and registration or one at a time So we create diffrent Interface For LogError and SendEmail
    }
    interface ILogger
    {
        void LogError(string error);
    }

    interface IEmail
    {
        bool SendEmail(string emailContent);
    }
}
