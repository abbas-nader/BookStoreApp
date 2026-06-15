using BookStoreApp.BLL.Constant;
using BookStoreApp.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.BLL.Validations
{
    public static class PublisherValidator
    {
        public static OperationResult Validate(PublisherCreateDto dto)
        {
            if (string.IsNullOrEmpty(dto.Name))
                return OperationResult.Failed(ValidationMessages.NameRequired);

            return OperationResult.Success(ValidationMessages.IsValid);
        }

        public static OperationResult Validate(PublisherUpdateDto dto)
        {
            if (dto.Id <= 0)
                return OperationResult.Failed(ValidationMessages.InvalidId);

            if (string.IsNullOrEmpty(dto.Name))
                return OperationResult.Failed(ValidationMessages.NameRequired);

            return OperationResult.Success(ValidationMessages.IsValid);
        }
    }
}
