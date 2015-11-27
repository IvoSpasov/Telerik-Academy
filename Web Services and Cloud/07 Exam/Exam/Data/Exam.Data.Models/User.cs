namespace Exam.Data.Models
{
    using System.Collections.Generic;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class User : IdentityUser
    {
        private ICollection<RealEstate> realEstates;
        private ICollection<Comment> comments;
        private ICollection<Rating> ratings;

        public User()
        {
            this.RealEstates = new HashSet<RealEstate>();
            this.Comments = new HashSet<Comment>();
            this.Ratings = new HashSet<Rating>();
        }

        public ICollection<RealEstate> RealEstates
        {
            get { return this.realEstates; }
            set { this.realEstates = value; }
        }

        public ICollection<Comment> Comments
        {
            get { return this.comments; }
            set { this.comments = value; }
        }

        public ICollection<Rating> Ratings
        {
            get { return this.ratings; }
            set { this.ratings = value; }
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);

            // Add custom user claims here
            return userIdentity;
        }
    }
}
