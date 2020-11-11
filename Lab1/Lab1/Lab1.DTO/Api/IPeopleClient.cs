using RestEase;
using System.Threading.Tasks;

namespace Lab1.DTO.Api
{
    public interface IPeopleClient
    {
        [Post("people")]
        Task AddPersonAsync([Body] Person person);
    }
}
