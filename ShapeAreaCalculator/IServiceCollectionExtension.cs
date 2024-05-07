using ShapeAreaCalculator.Backend.AreaCalculators;
using ShapeAreaCalculator.Common;
using System.Runtime.CompilerServices;

namespace ShapeAreaCalculator
{
    public static class IServiceCollectionExtension
    {
        public static void RegisterRequiredServices(this IServiceCollection services)
        {
            services.AddTransient<AreaCalculator>();
            services.AddTransient<ShapeFactory>();
            services.AddControllers();
            services.AddSwaggerGen();
        }
    }
}
