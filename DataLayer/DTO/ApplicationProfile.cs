using CORE.Model.DTO;
using COREAPI.DATA;

namespace CORE.Api
{
    public class ApplicationProfile : AutoMapper.Profile
    {
        public ApplicationProfile()
        {
            CreateMap<Book, BookDTO>().ReverseMap();
        }
    }
}
