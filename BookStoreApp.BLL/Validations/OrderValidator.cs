using BookStoreApp.BLL.Constant;
using BookStoreApp.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.BLL.Validations
{
    public static class OrderValidator
    {
        public static OperationResult Validate(OrderCreateDto dto)
        {
            if (dto.UserId <= 0)
                return OperationResult.Failed(ValidationMessages.InvalidId);

            if (dto.CustomerId <= 0)
                return OperationResult.Failed(ValidationMessages.InvalidId);

            if (dto.OrderItems == null || !dto.OrderItems.Any())
                return OperationResult.Failed(ValidationMessages.OrderItemRequired);

            foreach (var item in dto.OrderItems)
            {
                if (item.BookId <= 0)
                    return OperationResult.Failed(ValidationMessages.BookRequired);

                if (item.Quantity <= 0)
                    return OperationResult.Failed(ValidationMessages.InvalidQuantity);

                if (item.UnitPrice <= 0)
                    return OperationResult.Failed(ValidationMessages.InvalidUnitPrice);
            }

            return OperationResult.Success(ValidationMessages.IsValid);
        }

        public static OperationResult Validate(OrderUpdateDto dto)
        {
            if (dto.Id <= 0)
                return OperationResult.Failed(ValidationMessages.InvalidId);

            if (dto.CustomerId <= 0)
                return OperationResult.Failed(ValidationMessages.InvalidId);

            if (dto.OrderItems == null || !dto.OrderItems.Any())
                return OperationResult.Failed(ValidationMessages.OrderItemRequired);

            foreach (var item in dto.OrderItems)
            {
                if (item.BookId <= 0)
                    return OperationResult.Failed(ValidationMessages.BookRequired);

                if (item.Quantity <= 0)
                    return OperationResult.Failed(ValidationMessages.InvalidQuantity);

                if (item.UnitPrice <= 0)
                    return OperationResult.Failed(ValidationMessages.InvalidUnitPrice);
            }

            return OperationResult.Success(ValidationMessages.IsValid);
        }
    }
}
