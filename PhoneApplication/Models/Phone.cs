using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneApplication.Models
{
    public class Phone
    {
       
        public Phone()
        {
          
            PhoneName = "";
            Manufacturer = "";
            DateReleased = DateTime.Now;
        }

            public int PhoneId { get; set; }
        public string PhoneName { get; set; }
        public string Manufacturer { get; set; }
        public DateTime DateReleased { get; set; }


}
    
}