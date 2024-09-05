using MercuryExam.Models;

namespace MercuryExam.Service
{
    public interface IMyofficeExcuteionLogService
    {
        Task<IEnumerable<Myoffice_ExcuteionLog>> GetAllAsync();
        Task<Myoffice_ExcuteionLog> GetByIdAsync(string id);
        Task<Myoffice_ExcuteionLog> CreateAsync(Myoffice_ExcuteionLog myoffice_ExcuteionLog);
    }
}
