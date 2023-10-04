using DependencyInjection.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Concrete
{
    public class ApplicationContainer : IApplicationContainer
    {
        public IServiceCollection Services { get; private set; }
        public ApplicationContainer()
        {
            Services = new ServiceCollection();
        }
        public TService Resolve<TService>()
        {
            var c = Services.Services.Where(x => x.ServiceType == typeof(TService)).FirstOrDefault();
            if (c.InjectionType == InjectionType.Singleton)
            {
                if (c.Instance == null)
                {
                    var implementationType = c.InstanceType;

                    if (implementationType.GetConstructors().Length != 0)
                    {

                        var constructor = implementationType.GetConstructors().Length == 1 ?
                            implementationType.GetConstructors()[0] : throw new Exception("Only-one constructors supported.");

                        var constructorParams = constructor.GetParameters();

                        if(constructorParams.Length == 0)
                        {
                            TService generatedWAC = (TService)Activator.CreateInstance(implementationType);

                            c.Instance = generatedWAC;
                            return generatedWAC;
                        }

                        List<object> ctorParams = new List<object>();
                        foreach (var param in constructorParams)
                        {
                            var paramType = param.ParameterType;
                            object paramL = typeof(ApplicationContainer).GetMethod("Resolve").MakeGenericMethod(paramType).Invoke(this, null);
                            ctorParams.Add(paramL);
                        }

                        TService generatedWC = (TService)Activator.CreateInstance(implementationType, ctorParams.ToArray());

                        c.Instance = generatedWC;
                        return generatedWC;
                    }

                    TService generated = (TService)Activator.CreateInstance(implementationType);

                    c.Instance = generated;
                    return generated;
                }

                return (TService)c.Instance;
            }
            else if (c.InjectionType == InjectionType.Transient)
            {
                var implementationType = c.InstanceType;

                if (implementationType.GetConstructors().Length != 0)
                {

                    var constructor = implementationType.GetConstructors().Length == 1 ?
                        implementationType.GetConstructors()[0] : throw new Exception("Only-one constructors supported.");

                    var constructorParams = constructor.GetParameters();

                    if (constructorParams.Length == 0)
                    {
                        TService generatedWAC = (TService)Activator.CreateInstance(implementationType);

                        c.Instance = generatedWAC;
                        return generatedWAC;
                    }

                    List<object> ctorParams = new List<object>();
                    foreach (var param in constructorParams)
                    {
                        var paramType = param.ParameterType;
                        object paramL = typeof(ApplicationContainer).GetMethod("Resolve").MakeGenericMethod(paramType).Invoke(this, null);
                        ctorParams.Add(paramL);
                    }

                    TService generatedWC = (TService)Activator.CreateInstance(implementationType, ctorParams.ToArray());

                    c.Instance = generatedWC;
                    return generatedWC;
                }

                TService generated = (TService)Activator.CreateInstance(implementationType);

                c.Instance = generated;
                return generated;
            }
            else
            {
                throw new NotImplementedException("Not implemented yet.");
            }
        }
    }
}
