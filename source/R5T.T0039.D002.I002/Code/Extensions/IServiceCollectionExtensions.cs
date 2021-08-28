using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Lombardy;


namespace R5T.T0039.D002.I002
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="EmptyExtensionMethodBaseDirectoryPathConvention"/> implementation of <see cref="IEmptyExtensionMethodBaseDirectoryPathConvention"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddEmptyExtensionMethodBaseDirectoryPathConvention(this IServiceCollection services,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            services.AddSingleton<IEmptyExtensionMethodBaseDirectoryPathConvention, EmptyExtensionMethodBaseDirectoryPathConvention>()
                .Run(stringlyTypedPathOperatorAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="EmptyExtensionMethodBaseDirectoryPathConvention"/> implementation of <see cref="IEmptyExtensionMethodBaseDirectoryPathConvention"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IEmptyExtensionMethodBaseDirectoryPathConvention> AddEmptyExtensionMethodBaseDirectoryPathConventionAction(this IServiceCollection services,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            var serviceAction = ServiceAction.New<IEmptyExtensionMethodBaseDirectoryPathConvention>(() => services.AddEmptyExtensionMethodBaseDirectoryPathConvention(
                stringlyTypedPathOperatorAction));

            return serviceAction;
        }
    }
}
