﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VisibleAgileWeb.Models
{
    public class VALoginModel
    {
        //[Required(ErrorMessageResourceName = "required", ErrorMessageResourceType = typeof(VALoginModel))]
        public string JiraURL { get; set; }
        //[Required(ErrorMessageResourceName = "required", ErrorMessageResourceType = typeof(VALoginModel))]
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}