namespace Exam.Server.Api.Models.RealEstates
{
    using Exam.Data.Models;
    using Exam.Server.Infrastructure.Mapping;

    public class RealEstateResponseModel : IMapFrom<RealEstate>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public decimal SellingPrice { get; set; }

        public decimal RentingPrice { get; set; }

        public bool CanBeSold { get; set; }

        public bool CanBeRented { get; set; }
    }
}