using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MercuryExam.Models
{
    [Table("Myoffice_ACPD", Schema = "MercuryExam")]
    public class Myoffice_ACPD
    {
        [Key]
        [StringLength(20)]
        public string AcpdSid { get; set; }  // 使用者主鍵，由預存程序NEWSID生成

        [Required]
        [StringLength(60)]
        public string AcpdCname { get; set; }  // 中文名稱

        [StringLength(40)]
        public string AcpdEname { get; set; }  // 英文名稱

        [StringLength(40)]
        public string AcpdSname { get; set; }  // 簡稱

        [StringLength(60)]
        public string AcpdEmail { get; set; }  // 使用者信箱

        public byte AcpdStatus { get; set; }  // 狀況: 0=正常, 99=不正常

        public bool AcpdStop { get; set; }  // 是否停用/不可登入

        [StringLength(600)]
        public string AcpdStopMemo { get; set; }  // 停用原因

        [Required]
        [StringLength(30)]
        public string AcpdLoginID { get; set; }  // 登入帳號

        [Required]
        [StringLength(60)]
        public string AcpdLoginPW { get; set; }  // 登入密碼

        [StringLength(120)]
        public string AcpdMemo { get; set; }  // 備註

        public DateTime AcpdNowdatetime { get; set; } = DateTime.Now;  // 新增日期

        [StringLength(20)]
        public string AppdNowid { get; set; }  // 新增人員代碼

        public DateTime? AcpdUpddatetime { get; set; }  // 修改日期

        [StringLength(20)]
        public string AcpdUpdid { get; set; }  // 修改人員代碼
    }
}
