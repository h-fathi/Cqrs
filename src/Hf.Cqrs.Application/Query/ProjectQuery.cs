using FluentValidation;
using Hf.Cqrs.Infrastructure;
using Hf.Cqrs.Infrastructure.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hf.Cqrs.Application
{
    public class ProjectQuery : IQuery<Result>
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

}
