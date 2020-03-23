using dibeq_mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dibeq_mvc.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}