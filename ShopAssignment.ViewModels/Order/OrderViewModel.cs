using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAssignment.ViewModels.Order
{
    public class OrderViewModel
    {
        public int Id { set; get; }
        public DateTime OrderDate { set; get; }
        public Guid UserId { set; get; }
        public string CustomerName { set; get; }
        public string CustomerAddress { set; get; }
        public string CustomerEmail { set; get; }
        public string CustomerPhoneNumber { set; get; }
        public int Status { set; get; }
    }
}
