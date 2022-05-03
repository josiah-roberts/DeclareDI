using Microsoft.Extensions.DependencyInjection;

namespace DeclareDI
{
  public enum ServiceRegistrationTarget
  {
    Auto = 0,
    Self = 1,
    ImplementedInterfaces = 2,
  }

  [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
  /// <summary>
  /// Signifies that the type should be registered as a dependency.
  /// </summary>
  public class ServiceAttribute : System.Attribute
  {
    public ServiceLifetime Lifetime { get; }
    public ServiceRegistrationTarget Target { get; }
    public ServiceAttribute(ServiceLifetime lifetime = ServiceLifetime.Singleton, ServiceRegistrationTarget target = ServiceRegistrationTarget.Auto)
    {
      Lifetime = lifetime;
      Target = target;
    }
  }
}