using BookStoreApp.BLL.Constant;
using BookStoreApp.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.BLL.Validations
{
    public static class TranslatorValidator
    {
        public static OperationResult Validate(TranslatorCreateDto dto)
        {
            if (string.IsNullOrEmpty(dto.FirstName))
                return OperationResult.Failed(ValidationMessages.FirstNameRequired);

            if (string.IsNullOrEmpty(dto.LastName))
                return OperationResult.Failed(ValidationMessages.LastNameRequired);

            return OperationResult.Success(ValidationMessages.IsValid);
        }

        public static OperationResult Validate(TranslatorUpdateDto dto)
        {
            if (dto.Id <= 0)
                return OperationResult.Failed(ValidationMessages.InvalidId);

            if (string.IsNullOrEmpty(dto.FirstName))
                return OperationResult.Failed(ValidationMessages.FirstNameRequired);

            if (string.IsNullOrEmpty(dto.LastName))
                return OperationResult.Failed(ValidationMessages.LastNameRequired);

            return OperationResult.Success(ValidationMessages.IsValid);
        }
    }
}
