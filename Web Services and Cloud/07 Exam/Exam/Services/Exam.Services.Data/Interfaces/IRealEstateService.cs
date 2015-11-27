namespace Exam.Services.Data.Interfaces
{
    using System.Linq;
    using Common.Constants;
    using Exam.Data.Models;

    public interface IRealEstateService
    {
        IQueryable<RealEstate> GetPublicRealEstates(int skip = 0, int take = RealEstateConstants.EstatesPerPage);

        IQueryable<RealEstate> GetRealEstateDetails(int id);

        RealEstate CreateNewRealEstateAd(
               string title,
               string description,
               string address,
               string contact,
               int constructionYear,
               decimal sellingPrice,
               decimal rentingPrice,
               int type,
               string userId);
    }
}
