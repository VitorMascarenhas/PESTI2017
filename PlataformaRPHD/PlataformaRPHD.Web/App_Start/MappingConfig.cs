using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Web.ViewModels;

namespace PlataformaRPHD.Web.App_Start
{
    public class MappingConfig
    {
        public static void RegisterMaps()
        {
            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Attachment, AttachmentViewModel>().ReverseMap();

                cfg.CreateMap<Category, CategoryViewModel>().ReverseMap();

                cfg.CreateMap<Request, CreateRequestUserViewModel>().ReverseMap();

                cfg.CreateMap<Request, CreateRequestViewModel>().ReverseMap();

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
