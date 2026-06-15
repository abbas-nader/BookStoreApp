using BookStoreApp.BLL.Constant;
using BookStoreApp.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.BLL.Validations
{
    public static class BookValidator
    {
        public static OperationResult Validate(BookCreateDto dto)
        {
            if (string.IsNullOrEmpty(dto.Title))
                return OperationResult.Failed(ValidationMessages.TitleRequired);

            if (string.IsNullOrEmpty(dto.Isbn))
                return OperationResult.Failed(ValidationMessages.IsbnRequired);

            if (dto.Price <= 0)
                return OperationResult.Failed(ValidationMessages.InvalidPrice);

            if (dto.StockQuantity < 0)
                return OperationResult.Failed(ValidationMessages.InvalidStock);

            if (dto.PublicationYear <= 0)
                return OperationResult.Failed(ValidationMessages.InvalidYear);

            if (dto.CategoryId <= 0)
                return OperationResult.Failed(ValidationMessages.CategoryRequired);

            if (dto.PublisherId <= 0)
                return OperationResult.Failed(ValidationMessages.PublisherRequired);

            if (dto.AuthorIds == null || !dto.AuthorIds.Any())
                return OperationResult.Failed(ValidationMessages.AuthorRequired);

            return OperationResult.Success(ValidationMessages.IsValid);
        }

        public static OperationResult Validate(BookUpdateDto dto)
        {
            if (dto.Id <= 0)
                return OperationResult.Failed(ValidationMessages.InvalidId);

            if (string.IsNullOrEmpty(dto.Title))
                return OperationResult.Failed(ValidationMessages.TitleRequired);

            if (string.IsNullOrEmpty(dto.Isbn))
                return OperationResult.Failed(ValidationMessages.IsbnRequired);

            if (dto.Price <= 0)
                return OperationResult.Failed(ValidationMessages.InvalidPrice);

            if (dto.StockQuantity < 0)
                return OperationResult.Failed(ValidationMessages.InvalidStock);

            if (dto.PublicationYear <= 0)
                return OperationResult.Failed(ValidationMessages.InvalidYear);

            if (dto.CategoryId <= 0)
                return OperationResult.Failed(ValidationMessages.CategoryRequired);

            if (dto.PublisherId <= 0)
                return OperationResult.Failed(ValidationMessages.PublisherRequired);

            return OperationResult.Success(ValidationMessages.IsValid);
        }
    }
}
