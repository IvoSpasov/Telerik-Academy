namespace UsersManagement.Data
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Web;
    using System.Xml.Linq;

    using UsersManagement.Data.Models;

    public class UserRepository : IRepository<User>
    {
        private readonly string filePath = HttpContext.Current.Server.MapPath("~/App_Data/users.xml");
        private readonly XDocument usersInformationXml;

        public UserRepository()
        {
            if (this.FileExists())
            {
                this.usersInformationXml = XDocument.Load(this.filePath);
            }
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

        public User GetById(int id)
        {
            if (!this.FileExists())
            {
                return null;
            }

            User foundUser = this.All().FirstOrDefault(u => u.Id == id);
            return foundUser;
        }

        public User GetByUsername(string username)
        {
            if (!this.FileExists())
            {
                return null;
            }

            User foundUser = this.All().FirstOrDefault(u => u.Username.ToLower() == username.ToLower());
            return foundUser;
        }

        public void Add(User user)
        {
            if (!this.FileExists())
            {
                this.CreateNewXml(user);
            }
            else
            {
                this.AddUserToExistingXml(user);
            }
        }

        private void CreateNewXml(User user)
        {
            XElement newUserElement = new XElement("users", this.CreateUserElement(user));
            newUserElement.Save(this.filePath);
        }

        private void AddUserToExistingXml(User user)
        {
            var newUserElement = this.CreateUserElement(user);
            this.usersInformationXml.Element("users").Add(newUserElement);
            this.usersInformationXml.Save(this.filePath);
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

        public void Update(User user)
        {
            var foundUsers = from u in this.usersInformationXml.Descendants("user")
                             where (int)u.Element("id") == user.Id
                             select u;

            var foundUser = foundUsers.FirstOrDefault();

            if (foundUser == null)
            {
                throw new InvalidOperationException("user not found");
            }

            foundUser.Element("password").Value = user.Password;

            this.usersInformationXml.Save(this.filePath);
        }

        private bool FileExists()
        {
            if (!File.Exists(this.filePath))
            {
                return false;
            }

            return true;
        }
    }
}
