using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFacade.Structures
{
    public class BaseResponseModel
    {
        [Required]
        public string Code { get; set; }
        [Required]
        public string Message { get; set; }
        [Required]
        public object Data { get; set; }
    }
}
