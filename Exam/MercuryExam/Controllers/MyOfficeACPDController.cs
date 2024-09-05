using MercuryExam.Models;
using MercuryExam.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MercuryExam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyOfficeACPDController : ControllerBase
    {
    
        private readonly IMyOfficeACPDService _myOfficeACPDService;

        //取得所有資料
        [HttpPost]
        public Task<IEnumerable<Myoffice_ACPD>> GetMyofficeACPDs()
        {
            return _myOfficeACPDService.GetAllAsync;
        }
    }
}
