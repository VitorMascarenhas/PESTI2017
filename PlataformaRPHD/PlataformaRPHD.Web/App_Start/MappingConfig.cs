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

                cfg.CreateMap<ServiceViewModel, Service>().ReverseMap();

                cfg.CreateMap<InteractionViewModel, Interaction>().ReverseMap();

                cfg.CreateMap<TaskViewModel, Task>().ReverseMap();

                cfg.CreateMap<RequestWithSatisfactionSurveyViewModel, Request>().ReverseMap();

                cfg.CreateMap<WizardViewModel, Wizard>().ReverseMap();

                cfg.CreateMap<StepViewModel, Step>().ReverseMap();
            });
        }
    }
}
