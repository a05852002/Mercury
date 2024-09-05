using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MercuryExam.Models
{
    [Table("Myoffice_ExcuteionLog", Schema = "MercuryExam")]
    public class Myoffice_ExcuteionLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DeLog_AuthID { get; set; }  // 自訂索引碼，設定為 IDENTITY

        [Required]
        [StringLength(120)]
        public string DeLog_StoredPrograms { get; set; }  // 預存程序名稱

        [Required]
        public Guid DeLog_GroupID { get; set; }  // 執行的群組代碼

        [Required]
        public bool DeLog_isCustomDebug { get; set; }  // 是否認定為 Bug

        [Required]
        [StringLength(120)]
        public string DeLog_ExecutionProgram { get; set; }  // 執行的項目

        public string DeLog_ExecuteionInfo { get; set; }  // 執行的內容或是說明

        [Required]
        public bool DeLog_VerifyNeeded { get; set; }  // 此錯誤是否要進行檢查

        public DateTime exelog_nowdatetime { get; set; }  // 新增日期
    }
}
