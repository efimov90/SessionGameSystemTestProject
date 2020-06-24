using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace SGSApi.ClientLibrary.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Status { get; set; }
        public IPAddress LastIP { get; set; }
        public int PartyId { get; set; }
    }
}
