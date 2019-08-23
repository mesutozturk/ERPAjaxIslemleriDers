using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPAjaxIslemleri.Models
{
    [Table("Kisiler")]
    public class Kisi
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required, StringLength(50)]
        public string Ad { get; set; }
        [Required, StringLength(50)]
        public string Soyad { get; set; }
        [StringLength(11, ErrorMessage = "En fazla 11 haneli olmalı"), MinLength(11, ErrorMessage = "En az 11 Haneli olmalı")]
        public string Tckn { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}