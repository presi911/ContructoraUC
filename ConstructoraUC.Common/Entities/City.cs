﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConstructoraUC.Common.Entities
{
    public class City
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "The filed {0} must contain less than {1} characteres.")]
        [Required]
        [Display(Name = "City")]
        public string Name { get; set; }

        public ICollection<Project> Projects { get; set; }

        [DisplayName("Projects Number")]
        public int ProjectsNumber => Projects == null ? 0 : Projects.Count;

        [JsonIgnore]
        [NotMapped]
        public int IdCountry { get; set; }

    }
}
