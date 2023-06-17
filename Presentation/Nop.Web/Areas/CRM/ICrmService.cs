using System.Threading.Tasks;
using System;

namespace Nop.Web.Areas.CRM
{
    public interface ICrmService
    {
        Task<Guid?> GetContactIdByEmailAsync(string email);
        Task<Guid> CreateContactAsync(string firstName, string lastName, string email);
    }
}
