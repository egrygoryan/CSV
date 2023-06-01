namespace CSVHandler.Mappings;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<User, UserModel>()
            .ForMember(um => um.Name, opt => opt.MapFrom(u => u.Name))
            .ForMember(um => um.DateOfBirth, opt => opt.MapFrom(u => u.DateOfBirth))
            .ForMember(um => um.Married, opt => opt.MapFrom(u => u.Married))
            .ForMember(um => um.Phone, opt => opt.MapFrom(u => u.Phone))
            .ForMember(um => um.Salary, opt => opt.MapFrom(u => u.Salary));
        CreateMap<UserModel, User>()
            .ForMember(u => u.Name, opt => opt.MapFrom(um => um.Name))
            .ForMember(u => u.DateOfBirth, opt => opt.MapFrom(um => um.DateOfBirth))
            .ForMember(u => u.Married, opt => opt.MapFrom(um => um.Married))
            .ForMember(u => u.Phone, opt => opt.MapFrom(um => um.Phone))
            .ForMember(u => u.Salary, opt => opt.MapFrom(um => um.Salary));
    }
}
