using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.T0039.D002.I002
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="EmptyExtensionMethodBaseDirectoryPathConvention"/> implementation of <see cref="IEmptyExtensionMethodBaseDirectoryPathConvention"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddEmptyExtensionMethodBaseDirectoryPathConvention(this IServiceCollection services)
        {
            services.AddSingleton<IEmptyExtensionMethodBaseDirectoryPathConvention, EmptyExtensionMethodBaseDirectoryPathConvention>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="EmptyExtensionMethodBaseDirectoryPathConvention"/> implementation of <see cref="IEmptyExtensionMethodBaseDirectoryPathConvention"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IEmptyExtensionMethodBaseDirectoryPathConvention> AddEmptyExtensionMethodBaseDirectoryPathConventionAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<IEmptyExtensionMethodBaseDirectoryPathConvention>(() => services.AddEmptyExtensionMethodBaseDirectoryPathConvention());

            return serviceAction;
        }
    }
}
