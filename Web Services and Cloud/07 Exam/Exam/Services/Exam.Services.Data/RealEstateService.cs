namespace Exam.Services.Data
{
    using System;
    using System.Linq;
    using Common.Constants;
    using Exam.Data.Common.Repositories;
    using Exam.Data.Models;
    using Interfaces;

    public class RealEstateService : IRealEstateService
    {
        private IRepository<RealEstate> realEstatesRepo;

        public RealEstateService(IRepository<RealEstate> realEstatesRepo)
        {
            this.realEstatesRepo = realEstatesRepo;
        }

        public IQueryable<RealEstate> GetPublicRealEstates(int skip = 0, int take = RealEstateConstants.EstatesPerPage)
        {
            var realEstates = this.realEstatesRepo
                .All()
                .OrderByDescending(e => e.CreatedOn)
                .Skip(skip)
                .Take(take);

            return realEstates;
        }

        public IQueryable<RealEstate> GetRealEstateDetails(int id)
        {
            return this.realEstatesRepo
                .All()
                .Where(e => e.Id == id);
        }

        public RealEstate CreateNewRealEstateAd(
            string title, 
            string description,
            string address,
            string contact,
            int constructionYear,
            decimal sellingPrice,
            decimal rentingPrice,
            int type,
            string userId)
        {
            var newRealEstate = new RealEstate()
            {
                Title = title,
                Description = description,
                Address = address,
                Contact = contact,
                ConstructionYear = constructionYear,
                SellingPrice = sellingPrice,
                RentingPrice = rentingPrice,
                RealEstateType = (RealEstateType)type,
                CanBeSold = true,
                CanBeRented = true,
                CreatedOn = DateTime.Now,
                UserId = userId
            };

            this.realEstatesRepo.Add(newRealEstate);
            this.realEstatesRepo.SaveChanges();

            return newRealEstate;
        }
    }
}
