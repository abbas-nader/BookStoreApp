using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.BLL.Constant
{
    public static class ValidationMessages
    {
        public const string FirstNameRequired = "First name is required";
        public const string LastNameRequired = "Last name is required";
        public const string UsernameRequired = "Username is required";
        public const string PasswordRequired = "Password is required";
        public const string PasswordMinLength = "Password must be at least 6 characters";
        public const string PhoneRequired = "Phone number is required";
        public const string PhoneLength = "Phone number must be 11 digits";
        public const string InvalidId = "Invalid ID";
        public const string TitleRequired = "Title is required";
        public const string IsbnRequired = "ISBN is required";
        public const string InvalidPrice = "Price cannot be zero or negative";
        public const string InvalidStock = "Stock quantity cannot be negative";
        public const string InvalidYear = "Invalid publication year";
        public const string CategoryRequired = "Category is required";
        public const string PublisherRequired = "Publisher is required";
        public const string AuthorRequired = "At least one author is required";
        public const string OrderItemRequired = "Order must have at least one item";
        public const string BookRequired = "Book is required";
        public const string InvalidQuantity = "Quantity must be greater than zero";
        public const string InvalidUnitPrice = "Unit price cannot be zero or negative";
        public const string NameRequired = "Name is required";
        public const string IsValid = "Is valid";
    }
}
