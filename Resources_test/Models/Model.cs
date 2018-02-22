using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Resources_test.Models
{
    public class Model
    {
        [Display(Name = "Property_1", ResourceType = typeof(Resource))]
        public string Property { get; set; }
    }
}