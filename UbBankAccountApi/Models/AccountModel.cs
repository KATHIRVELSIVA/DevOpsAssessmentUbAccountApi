using System.ComponentModel.DataAnnotations;

namespace UbBankAccountApi.Models
{
    public class AccountModel
    {
        public long AccountNumber { get; set; }
        public string ? AccountHolderNumber { get; set; }
        public string ? AccountType { get; set; }
        public double AccountBalance { get; set; }
        public long PhoneNumber { get; set; }
    }
}
