using FluentValidation;
using Hf.Cqrs.Infrastructure.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hf.Cqrs.Application
{
    public class CreateProjectCommand : ICommand
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Plaque { get; set; }
        public long  Meters{ get; set; }
        public long ShareCount { get; set; }
        public double UnitShare { get; set; }
        public string Description { get; set; }
        public bool DisableForUser { get; set; }
    }
    public class DeleteProjectCommand : ICommand
    {
        public long Id { get; set; }    
    }

    public class CreateProjectCommandValidator : AbstractValidator<CreateProjectCommand>
    {

        public CreateProjectCommandValidator()
        {
            RuleFor(x => x.Code).NotEmpty().WithMessage("");
            RuleFor(x => x.Title).NotEmpty().WithMessage("");
            RuleFor(x => x.Plaque).NotEmpty().WithMessage("");
            RuleFor(x => x.Description).NotEmpty().WithMessage("");
        }
    }
}
