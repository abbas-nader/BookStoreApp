using BookStoreApp.BLL.Constant;
using BookStoreApp.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.BLL.Validations
{
    public static class CustomerValidator
    {
        public static OperationResult Validate(CustomerCreateDto dto)
        {
            if (string.IsNullOrEmpty(dto.FirstName))
                return OperationResult.Failed(ValidationMessages.FirstNameRequired);

            if (string.IsNullOrEmpty(dto.LastName))
                return OperationResult.Failed(ValidationMessages.LastNameRequired);

            if (string.IsNullOrEmpty(dto.Phone))
                return OperationResult.Failed(ValidationMessages.PhoneRequired);

            if (dto.Phone.Length != 11)
                return OperationResult.Failed(ValidationMessages.PhoneLength);

            return OperationResult.Success(ValidationMessages.IsValid);
        }

        public static OperationResult Validate(CustomerUpdateDto dto)
        {
            if (dto.Id <= 0)
                return OperationResult.Failed(ValidationMessages.InvalidId);

            if (string.IsNullOrEmpty(dto.FirstName))
                return OperationResult.Failed(ValidationMessages.FirstNameRequired);

            if (string.IsNullOrEmpty(dto.LastName))
                return OperationResult.Failed(ValidationMessages.LastNameRequired);

            if (string.IsNullOrEmpty(dto.Phone))
                return OperationResult.Failed(ValidationMessages.PhoneRequired);

            if (dto.Phone.Length != 11)
                return OperationResult.Failed(ValidationMessages.PhoneLength);

            return OperationResult.Success(ValidationMessages.IsValid);
        }
    }
}
