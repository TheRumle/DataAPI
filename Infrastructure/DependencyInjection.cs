using System.Reflection;
using Application.ExamStress.Common;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IStudentContext, StudentContext>();
        return services;
    }
}