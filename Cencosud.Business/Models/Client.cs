using System;
using System.Collections.Generic;
using System.Text;

namespace Cencosud.Business.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public int documentType { get; set; }
        public string documentNumber { get; set; }
        public DateTime registerDate { get; set; }
    }
}
