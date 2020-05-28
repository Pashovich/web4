﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace web4.Models
{
    public class CodeModel
    {
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public string code { get; set; }
        [Compare("code", ErrorMessage = "Код не совпадает")]
        public string confirmCode { get; set; }
    }
}
