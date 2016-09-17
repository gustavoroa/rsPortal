using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoaSystems.Server.Services
{
    public class AdobeService : IAdobeService
    {
        public AdobeService()
        {

        }

        public string GetHomePageTag()
        {
            if (string.IsNullOrEmpty(LoggedInCustomer.Email))
            {
                return "";
            }
            else
            {
                return LoggedInCustomer.Email;
            }
        }
        public NewCustomer LoggedInCustomer { get; set; }
    }

    public interface IAdobeService
    {
        string GetHomePageTag();
    }

    public class NewCustomer
    {
        public string Email { get; set; }
    }
}
