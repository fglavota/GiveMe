﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        Erythrocytes,
        Thrombocytes

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
        public int Count { get; set; }
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