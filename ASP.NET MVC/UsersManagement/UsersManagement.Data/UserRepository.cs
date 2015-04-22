using System;
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

        public IQueryable<User> All()
        {
            throw new NotImplementedException();
        }

        public void Add(User user)
        {
            if (!File.Exists(filePath))
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
            XElement newUserElement = this.CreateUserElement(user);
            newUserElement.Save(filePath);
        }

        private void AddUserToExistingXml(User user)
        {
            XDocument usersInformationXml = XDocument.Load(filePath);
            var newUserElement = this.CreateUserElement(user);
            usersInformationXml.Element("users").Add(newUserElement);
            usersInformationXml.Save(filePath);
        }

        private XElement CreateUserElement(User user)
        {
            // billing.ID = (int)(from b in billingData.Descendants("item") orderby (int)b.Element("id") descending select (int)b.Element("id")).FirstOrDefault() + 1;

            XElement userAsXmlElement = new XElement("users",
                new XElement("user",
                    new XElement("id", user.Id),
                    new XElement("username", user.Username),
                    new XElement("password", user.Password)));

            return userAsXmlElement;
        }
    }
}
