using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GiveMe.Models
{
    public enum BloodGroup
    {
        A,
        Zero,
        B,
        AB
    }

    public enum BloodType
    {
        Positive,
        Negative
    }

    public enum ProductType
    {
        BloodDonation,
        //TODO: PlasmaDonation...

    }
    public sealed class TotalDosages
    {
        [Required]
        public BloodGroup BloodGroup { get; set; }
        [Required]
        public BloodType BloodType { get; set; }
        [Required]
        public ProductType ProductType { get; set; }
        [Required]
        public int TakenCount { get; set; }
        [Required]
        public int ProducedCount { get; set; }
    }

    public sealed class BloodRecord
    {
        [Required]
        public DateTimeOffset Date { get; set; }
        [Required]
        public bool Unusable { get; set; }
        [Required]
        public List<TotalDosages> TotalDosages { get; set; }
    }
}