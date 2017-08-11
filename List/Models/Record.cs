using System;
using System.ComponentModel.DataAnnotations;

namespace List.Models
{
    public class Record
    {
        [Key]
        public int Id { get; set; }        

        [Required]
        [StringLength(50, ErrorMessage="Title connot be longer than 50 symbols")]
        public string Title { get; set; }

        public Record Category { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:yyyy,MM-dd}", ApplyFormatInEditMode=true)]
        public DateTime Date { get; set; }
    }
}