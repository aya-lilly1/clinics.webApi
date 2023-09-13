using AutoMapper;
using Clinic_DbModel.Models;
using Clinic_ModelView;

namespace Clinic_Core.Mapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Appointment, AppointmentModelView>().ReverseMap();
            CreateMap<Blog, BlogModelView>().ReverseMap();
            CreateMap<Doctor, DoctorModelView>().ReverseMap();
            CreateMap<ApplicationUser, PatientModelView>().ReverseMap();
            CreateMap<Review, ReviewModelView>().ReverseMap();
            CreateMap<Scheduletiming, ScheduletimingModelView>().ReverseMap();
            CreateMap<Socialmediaurl, SocialMediaUrlModelView>().ReverseMap();
            CreateMap<Specialization, SpectalizationModelView>().ReverseMap();



            CreateMap<PatientLoginModelView, ApplicationUser>().ReverseMap();
            CreateMap<PatientRegistrationModelView, ApplicationUser>().ReverseMap();
            CreateMap<ApplicationUser, LoginPatientResponse>().ReverseMap();


            CreateMap<PatientLoginModelView, ApplicationUser>().ReverseMap();
            CreateMap<DoctorRegistrationModelView, ApplicationUser>().ReverseMap();

            CreateMap<ApplicationUser, LoginDoctorResponse>().ReverseMap();
            CreateMap<ScheduletimingModelView, Scheduletiming>().ReverseMap();




        }
    }
}
