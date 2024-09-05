using MercuryExam.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace MercuryExam.Service.Impl
{
    public class MyOfficeACPDService : IMyOfficeACPDService
    {
        private readonly MercuryExamContext _context;

        public MyOfficeACPDService(MercuryExamContext context)
        {
            _context = context;
        }

        //呼叫預存程序
        private async Task<string> GetNewIdAsync(string tableName)
        {
            var returnValue = new SqlParameter
            {
                ParameterName = "@ReturnSID",
                SqlDbType = SqlDbType.NVarChar,
                Size = 20,
                Direction = ParameterDirection.Output
            };

            var tableNameParam = new SqlParameter("@TableName", SqlDbType.NVarChar)
            {
                Value = tableName
            };

            await _context.Database.ExecuteSqlRawAsync(
                "EXEC dbo.NEWSID @TableName, @ReturnSID OUTPUT",
                tableNameParam,
                returnValue
            );

            return (string)returnValue.Value;
        }

        public async Task<Myoffice_ACPD> CreateAsync(Myoffice_ACPD request)
        {
            Myoffice_ACPD entity = new Myoffice_ACPD();
            entity = request;
            entity.AcpdSid = await GetNewIdAsync("Myoffice_ACPD");
            _context.Myoffice_ACPDs.Add(entity);
        }

        public Task DeleteAsync(string id)
        {
            Myoffice_ACPD entity = _context.Myoffice_ACPDs.Find(Myoffice_ACPD => Myoffice_ACPD.acpd_sid == id);
            _context.Myoffice_ACPDs.ExecuteDeleteAsync(entity);
        }

        public async Task<IEnumerable<Myoffice_ACPD>> GetAllAsync()
        {
            return await _context.Myoffice_ACPDs.ToListAsync();
        }

        public Task<Myoffice_ACPD> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(string id, Myoffice_ACPD myoffice_ACPD)
        {
            throw new NotImplementedException();
        }
    }
}
