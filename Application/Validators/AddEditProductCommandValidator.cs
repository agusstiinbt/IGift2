﻿using System.ComponentModel.DataAnnotations;
using Application.CQRS.Files;
using FluentValidation;
using MediatR;
using Shared.Wrappers;

namespace Application.Validators
{
    public class AddEditProductCommandValidator : AbstractValidator<AddEditProductCommand>
    {
        public AddEditProductCommandValidator()
        {
            RuleFor(request => request.Name)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage("Name is required!");
        }
    }

    public partial class AddEditProductCommand : IRequest<Result<int>>
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Barcode { get; set; }
        [Required]
        public string Description { get; set; }
        public string ImageDataURL { get; set; }
        [Required]
        public decimal Rate { get; set; }
        [Required]
        public int BrandId { get; set; }
        public UploadRequest UploadRequest { get; set; }
    }
}
