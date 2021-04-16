using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{

    public class User
    {
       
        public int userId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
       
        public string userName { get; set; }
        public string password { get; set; }
      
        public string email { get; set; }
        public string mobileNo { get; set; }
        public string address { get; set; }

    }
}
