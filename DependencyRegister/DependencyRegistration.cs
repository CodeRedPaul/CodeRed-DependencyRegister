namespace CodeRed.Extensions.DependencyInjection
{
    public class DependencyRegistration<TScope, TDependency>
    {
        public TDependency Dependency { get; }

        public DependencyRegistration(TDependency dependency)
        {
            Dependency = dependency;
        }
    }
}
