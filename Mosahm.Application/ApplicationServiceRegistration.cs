using Mapster;
using MapsterMapper;
using MediatR;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Mosahm.Application.Common;
using Mosahm.Application.Behaviors;

namespace Mosahm.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            var assembly = typeof(ApplicationServiceRegistration).Assembly;

            services.AddMediatR(assembly);

            var config = TypeAdapterConfig.GlobalSettings;
            config.Scan(assembly);
            services.AddSingleton(config);
            services.AddScoped<IMapper, ServiceMapper>();

            services.AddValidatorsFromAssembly(assembly);

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

            services.AddScoped<ResponseHandler>();

            return services;
        }
    }
}
