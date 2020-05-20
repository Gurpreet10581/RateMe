﻿using RateItData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateItModels.Movie
{
    public class MovieEdit
    {
        //public int ReviewId { get; set; }
        [Required]
        public int MovieId { get; set; }

        [MaxLength(300, ErrorMessage = "Maximum character lenght required is 300 ")]
        [MinLength(1, ErrorMessage = "Minimum character lenght required is 1 ")]
        public string MovieName { get; set; }

        [MaxLength(300, ErrorMessage = "Maximum character lenght required is 300 ")]
        [MinLength(1, ErrorMessage = "Minimum character lenght required is 1 ")]
        public string DirectorName { get; set; }

        [Range(1, 300, ErrorMessage = "Enter a valid Duration between 1 to 300 minutes")]
        [Display(Name = "Duration In Minutes")]
        public decimal Duration { get; set; }

        [Display(Name = "DateRelease")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateRelease { get; set; }
        public MovieGenre GenreOfMovie { get; set; }


    }
}
