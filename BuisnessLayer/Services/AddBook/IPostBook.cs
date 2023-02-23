using COREAPI.DATA.ViewModel;

namespace BuisnessLayer.Services.AddBook
{
    public interface IPostBook
    {
        void AddBook(BookViewModel book);
    }
}
