using System;
using Microsoft.Extensions.DependencyInjection;

namespace CodeRed.Extensions.DependencyInjection
{
    public static class Extensions
    {
        public static TDependency GetRequiredRegisteredService<TScope, TDependency>(this IServiceProvider serviceProvider)
        {
            return serviceProvider.GetRequiredService<DependencyRegistration<TScope, TDependency>>().Dependency;
        }
    }
}
