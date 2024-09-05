using MercuryExam.Models;

namespace MercuryExam.Service
{
    public interface IMyOfficeACPDService
    {
        Task<IEnumerable<Myoffice_ACPD>> GetAllAsync();
        Task<Myoffice_ACPD> GetByIdAsync(string id);
        Task<Myoffice_ACPD> CreateAsync(Myoffice_ACPD request);
        Task UpdateAsync(string id, Myoffice_ACPD request);
        Task DeleteAsync(string id);
    }
}
