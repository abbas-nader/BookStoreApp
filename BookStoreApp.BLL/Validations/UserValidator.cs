using BookStoreApp.BLL.Constant;
using BookStoreApp.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.BLL.Validations
{
    public static class UserValidator
    {
        public static OperationResult Validate(UserCreateDto dto)
        {
            if (string.IsNullOrEmpty(dto.FirstName))
                return OperationResult.Failed(ValidationMessages.FirstNameRequired);

            if (string.IsNullOrEmpty(dto.LastName))
                return OperationResult.Failed(ValidationMessages.LastNameRequired);

            if (string.IsNullOrEmpty(dto.Username))
                return OperationResult.Failed(ValidationMessages.UsernameRequired);

            if (string.IsNullOrEmpty(dto.Password))
                return OperationResult.Failed(ValidationMessages.PasswordRequired);

            if (dto.Password.Length < 6)
                return OperationResult.Failed(ValidationMessages.PasswordMinLength);

            return OperationResult.Success(ValidationMessages.IsValid);
        }

        public static OperationResult Validate(UserUpdateDto dto)
        {
            if (dto.Id <= 0)
                return OperationResult.Failed(ValidationMessages.InvalidId);

            if (string.IsNullOrEmpty(dto.FirstName))
                return OperationResult.Failed(ValidationMessages.FirstNameRequired);

            if (string.IsNullOrEmpty(dto.LastName))
                return OperationResult.Failed(ValidationMessages.LastNameRequired);

            if (string.IsNullOrEmpty(dto.Username))
                return OperationResult.Failed(ValidationMessages.UsernameRequired);

            if (string.IsNullOrEmpty(dto.Password))
                return OperationResult.Failed(ValidationMessages.PasswordRequired);

            if (dto.Password.Length < 6)
                return OperationResult.Failed(ValidationMessages.PasswordMinLength);

            return OperationResult.Success(ValidationMessages.IsValid);
        }
    }
}
