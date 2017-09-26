using PlataformaRPHD.Domain.Entities.Entities;
using STICket.Models;

namespace STICket.Services.App_Start
{
    public class MappingConfig
    {
        public static void RegisterMaps()
        {
            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Category, Category>().ReverseMap();

                cfg.CreateMap<Topic, TopicViewModel>().ReverseMap();

                cfg.CreateMap<Service, ServiceViewModel>().ReverseMap();

                //cfg.CreateMap<BusinessHours, BusinessHoursViewModel>().ReverseMap();
                //cfg.CreateMap<Hashtag, HashtagViewModel>().ReverseMap();
                //cfg.CreateMap<Visit, VisitViewModel>().ReverseMap();
                //cfg.CreateMap<GpsCoordinate, GpsCoordinatesViewModel>().ReverseMap();

                //cfg.CreateMap<CreatePoiViewModel, PointOfInterest>();

                //cfg.CreateMap<PointOfInterest, AddPoiToVisitViewModel>();

                //cfg.CreateMap<Route, RouteViewModel>().ReverseMap();
            });
        }
    }
}
