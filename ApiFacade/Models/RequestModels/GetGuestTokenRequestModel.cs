using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ApiFacade.Models.RequestModels
{
    class GetGuestTokenRequestModel
    {
        [Required]
        public string Device_id { get; set; }

        [Required]
        public string Client_code { get; set; }
    }
}
