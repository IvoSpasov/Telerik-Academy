using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;
using UsersManagement.Data.Models;

namespace UsersManagement.Data
{
    public class UserRepository : IRepository<User>
    {
        private readonly string filePath = HttpContext.Current.Server.MapPath("~/App_Data/users.xml");
        private readonly XDocument usersInformationXml;

        public UserRepository()
        {
            if (this.FileExists())
            {
                this.usersInformationXml = XDocument.Load(filePath);
            }
        }

        public bool FileExists()
        {
            if (!File.Exists(filePath))
            {
                return false;
            }

            return true;
        }

        public IEnumerable<User> All()
        {
            if (!this.FileExists())
            {
                throw new InvalidOperationException("Xml file does not exist");
            }

            var listOfUsers = from user in this.usersInformationXml.Descendants("user")
                              select new User((int)user.Element("id"), user.Element("username").Value, user.Element("password").Value);

            return listOfUsers;
        }

        public void Add(User user)
        {
            if (!this.FileExists())
            {
                CreateNewXml(user);
            }
            else
            {
                AddUserToExistingXml(user);
            }
        }

        private void CreateNewXml(User user)
        {
            XElement newUserElement = new XElement("users", this.CreateUserElement(user));
            newUserElement.Save(filePath);
        }

        private void AddUserToExistingXml(User user)
        {
            var newUserElement = this.CreateUserElement(user);
            this.usersInformationXml.Element("users").Add(newUserElement);
            this.usersInformationXml.Save(filePath);
        }

        private XElement CreateUserElement(User user)
        {
            IEnumerable<int> allUserIds;
            int nextUserId;

            if (this.usersInformationXml != null)
            {
                allUserIds = from u in this.usersInformationXml.Descendants("user")
                             orderby (int)u.Element("id") descending
                             select (int)u.Element("id");

                nextUserId = allUserIds.FirstOrDefault() + 1;
            }
            else
            {
                nextUserId = 1;
            }

            XElement userAsXmlElement = new XElement("user",
                    new XElement("id", nextUserId),
                    new XElement("username", user.Username),
                    new XElement("password", Sha1Hash.Sha1HashStringForUtf8String(user.Password)));

            return userAsXmlElement;
        }
    }
}
