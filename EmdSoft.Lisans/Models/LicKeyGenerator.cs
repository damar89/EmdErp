using System;
using System.ComponentModel.DataAnnotations;

namespace EmdSoft.Lisans.Models
{
    public class LicKeyGenerator
    {
        [Key]
        public Guid Id { get; set; }
        public Guid LicKey { get; set; }
        public string FirmaAdi { get; set; }
        public string VDNo { get; set; }
        public string VergiDairesi { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
    }
}