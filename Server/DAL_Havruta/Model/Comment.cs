using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DAL_Havruta.Model;

public partial class Comment
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Idcomment { get; set; }

    public int? IdWritesComment { get; set; }

    public int? IdGettingComment { get; set; }

    public int? Rating { get; set; }

    public string? Comment1 { get; set; }

    public DateTime? Date { get; set; }

    public virtual User? IdWritesCommentNavigation { get; set; }
}
