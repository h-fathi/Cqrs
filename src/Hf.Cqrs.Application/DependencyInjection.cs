using System;
using System.Collections.Generic;
using System.Linq;
using FluentValidation;
using Hf.Cqrs.Infrastructure;
using Hf.Cqrs.Infrastructure.Commands;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Hf.Cqrs.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            var handlerAssemblyMakerTypes = GetAllTypesThatImplementInterface<ICommand>().ToList();
            services.AddCqrs(handlerAssemblyMakerTypes.ToArray());

            //dont forget to register validators
            //services.AddValidatorsFromAssembly(typeof(DependencyInjection).Assembly, ServiceLifetime.Scoped);

            return services;
        }

        private static IEnumerable<Type> GetAllTypesThatImplementInterface<T>()
        {
            return System.Reflection.Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(type => typeof(T).IsAssignableFrom(type) && !type.IsInterface);
        }
    }
}