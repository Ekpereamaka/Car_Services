using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Hire_Services__CHS_.Models
{
    public class PayStack
    {
        public Guid Id { get; set; }

        public decimal? amount { get; set; }

        public int PaymentId { get; set; }
        [Display(Name = "Order Details")]
        [ForeignKey("PaymentId")]
        public Payment Payment { get; set; }

        public string currency { get; set; }
        public DateTime? transaction_date { get; set; }
        public string status { get; set; }
        public string reference { get; set; }
        public string domain { get; set; }
        public string gateway_response { get; set; }
        public string message { get; set; }
        public string channel { get; set; }
        public string ip_address { get; set; }
        public string fees { get; set; }
        public string last4 { get; set; }
        public string exp_month { get; set; }
        public string exp_year { get; set; }
        public string card_type { get; set; }
        public string bank { get; set; }
        public string country_code { get; set; }
        public string brand { get; set; }
        public bool? reusable { get; set; }
        public string signature { get; set; }
        public string authorization_url { get; set; }
        public string access_code { get; set; }
    }
}
