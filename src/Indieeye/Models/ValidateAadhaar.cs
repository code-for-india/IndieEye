using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Indieeye.Models
{
    public class ValidateAadhaar
    {
        [Key]
        public int Id { get; set; }//Todo: Added this for EF sake
        public int UId { get; set; }
        public string MobileNumber { get; set; }
        public string Name { get; set; }
        public byte[] Fingerprint { get; set; }
        public byte[] Iris { get; set; }
    }
}