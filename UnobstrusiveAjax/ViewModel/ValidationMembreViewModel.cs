using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using UnobstrusiveAjax.Models;

namespace UnobstrusiveAjax.ViewModel
{
    public class ValidationMembreViewModel
    {
        [Required]
        public string Nam { get; set; }
        public Individu Individu { get; set; }
    }
}