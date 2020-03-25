using dibeq_mvc.Models;
using System.Collections.Generic;

namespace dibeq_mvc.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}