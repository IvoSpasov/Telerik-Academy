using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UsersManagement.Data
{
    public class UserToXml : IUserToXml
    {
        public void AddNewUser(string username, string password)
        {
            if (!File.Exists("../../users.xml"))
            {
                CreateNewXml(username, password);
            }
            else
            {
                AddUserToExistingXml(username, password);
            }
        }

        private void CreateNewXml(string username, string password)
        {
            XElement usersInformationXml = new XElement("users",
                new XElement("user",
                    new XElement("username", username),
                    new XElement("password", password)));

            usersInformationXml.Save("../../users.xml");
        }

        private void AddUserToExistingXml(string username, string password)
        {
            XDocument usersInformationXml = XDocument.Load("../../users.xml");

            var newUser = new XElement("user",
                new XElement("username", username),
                new XElement("password", password));

            usersInformationXml.Element("users").Add(newUser);

            usersInformationXml.Save("../../users.xml");
        }

    }
}
