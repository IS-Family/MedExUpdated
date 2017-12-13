using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MedExUpdated.Models
{
    [Table("CompletedCert")]
    public class CompletedCert
    {
        [Key]
        public int Id { get; set; }
        public int CertID { get; set; }
        public int DoctorId { get; set; }
        [DisplayName("File Upload")]
        public HttpPostedFile FilePath { get; set; }
        [DisplayName("Expiration Date")]
        public DateTime ExpirationDate { get; set; }
    }
}