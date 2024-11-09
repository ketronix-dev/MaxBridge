using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaxBridge.Classes;

[Table("GOODS")] // Ім'я таблиці в базі даних
public class Good
{
    [Key] // Вкажіть ключове поле, якщо UID є Primary Key
    [Column("UID")]
    public string Uid { get; set; }

    [Column("NAME")]
    public string Name { get; set; }

    [Column("BARCODE")]
    public string Barcode { get; set; }

    [Column("BARCODES")]
    public string Barcodes { get; set; }

    [Column("DESCRIPTION")]
    public string Description { get; set; }
    
    [Column("DATE_ADD")]
    public DateTime AddedDate { get; set; }
    
    [Column("GROUP_UID")]
    public string GroupUid { get; set; }
    
    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }
    
    [Column("SET_STATUS")]
    public int Status { get; set; }
    
    [Column("DATE_UPDATE")]
    public DateTime UpdateDate { get; set; }
}
