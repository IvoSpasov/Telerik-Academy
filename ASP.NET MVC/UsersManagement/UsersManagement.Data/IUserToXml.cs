using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersManagement.Data
{
    public interface IUserToXml
    {
        void AddNewUser(string username, string password);
    }
}
