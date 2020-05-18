﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateItModels.Review
{
    public class ReviewStatistics
    {
        [Required]
        public int ReviewId { get; set; }
        public string[,] MinMaxAvg { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public List<int> Rating { get; set; }
    }
}