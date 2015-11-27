namespace Exam.Server.Api.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Common.Constants;
    using Microsoft.AspNet.Identity;
    using Models.RealEstates;
    using Services.Data.Interfaces;

    public class RealEstatesController : ApiController
    {
        private IRealEstateService realEstateService;

        public RealEstatesController(IRealEstateService realEstateService)
        {
            this.realEstateService = realEstateService;
        }

        public IHttpActionResult Get(int skip = 0, int take = RealEstateConstants.EstatesPerPage)
        {
            var result = this.realEstateService
                .GetPublicRealEstates(skip, take)
                .ProjectTo<RealEstateResponseModel>()
                .ToList();

            return this.Ok(result);
        }

        public IHttpActionResult Get(int? id)
        {
            if (id == null)
            {
                return this.BadRequest("Id must be provided");
            }

            if (!this.User.Identity.IsAuthenticated)
            {
                var result = this.realEstateService
                    .GetRealEstateDetails(id.Value)
                    .ProjectTo<PublicRealEstateDetailsResponseModel>()
                    .FirstOrDefault();

                if (result == null)
                {
                    return this.NotFound();
                }

                return this.Ok(result);
            }
            else
            {
                var result = this.realEstateService
                    .GetRealEstateDetails(id.Value)
                    .ProjectTo<PrivateRealEstateDetailsResponseModel>()
                    .FirstOrDefault();

                if (result == null)
                {
                    return this.NotFound();
                }

                return this.Ok(result);
            }
        }

        [Authorize]
        public IHttpActionResult Post(CreateRealEstateRequestModel model)
        {
            if (model == null)
            {
                return this.BadRequest("Model cannot be null");
            }

            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            string currentUserId = this.User.Identity.GetUserId();

            var newRealEstate = this.realEstateService
                .CreateNewRealEstateAd(
                model.Title,
                model.Description,
                model.Address,
                model.Contact,
                model.ConstructionYear,
                model.SellingPrice,
                model.RentingPrice,
                model.Type,
                currentUserId);

            var result = Mapper.Map<RealEstateResponseModel>(newRealEstate);

            return this.Created(string.Format("/api/realestates/{0}", result.Id), result);
        }
    }
}