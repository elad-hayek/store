using System.Reflection;

namespace CustomerService.WebApi;

internal static class AssemblyRefrences
{
    public static readonly Assembly[] Assemblies = AppDomain.CurrentDomain.GetAssemblies();

    public static readonly Assembly Presentation = Assemblies.First(x => x.GetName().Name!.Contains("Presentation"));
    public static readonly Assembly Application = Assemblies.First(x => x.GetName().Name!.Contains("Application"));
}
