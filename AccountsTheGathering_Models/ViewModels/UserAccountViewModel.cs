using System;

namespace AccountsTheGathering_Models.ViewModels
{
    /// <summary>
    /// In order to display this on the razor page(s), we need to build a view model to help capture the data we will receive.
    /// </summary>
    public class UserAccountViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public decimal AmountDue { get; set; }
        public DateTimeOffset? PaymentDueDate { get; set; } // This needs to be made nullable for empty dates.
        public int AccountStatusId { get; set; } // This will be tied in with the enum.
    }
}