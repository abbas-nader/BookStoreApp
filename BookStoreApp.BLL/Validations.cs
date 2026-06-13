using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.BLL
{
    public class Validations
    {
        public static OperationResult ValidateBookDto(DTOs.BookDto bookDto)
        {
            if (bookDto == null)
                return OperationResult.Failed("Dto is null");

            if (string.IsNullOrWhiteSpace(bookDto.Title))
                return OperationResult.Failed("Title is required");

            if (bookDto.Title.Length < 3)
                return OperationResult.Failed("Title is too short");

            if (string.IsNullOrWhiteSpace(bookDto.Isbn))
                return OperationResult.Failed("ISBN is required");

            if (bookDto.Price < 0)
                return OperationResult.Failed("Price cannot be negative");

            if (bookDto.CategoryId <= 0)
                return OperationResult.Failed("Invalid CategoryId");

            if (bookDto.PublisherId <= 0)
                return OperationResult.Failed("Invalid PublisherId");

            if (bookDto.AuthorIds == null || bookDto.AuthorIds.Count == 0)
                return OperationResult.Failed("At least one author is required");

            return OperationResult.Success("Parameters Valid");

        }
    }
}
