using DependencyInjection.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Concrete
{
    public class ServiceCollection : IServiceCollection
    {
        public List<IServiceModel> Services { get; private set; }

        public ServiceCollection()
        {
            Services = new List<IServiceModel>();
        }

        public void Register<TService, TImplementation>(InjectionType type)
        {
            var model = new ServiceModel
            {
                ServiceType = typeof(TService),
                InstanceType = typeof(TImplementation),
                InjectionType = type,
                Instance = null
            };

            Services.Add(model);

            return;
        }

        public void RegisterInstance<TService>(TService instance)
        {
            throw new NotImplementedException();
        }

        public void Remove<TService>()
        {
            throw new NotImplementedException();
        }
    }
}
