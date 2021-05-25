using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystemDemo.Entities
{
    public class Customer 
    {
        public int  Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalyId { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
