using DependencyInjection.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Abstract
{
    public interface IServiceCollection
    {
        List<IServiceModel> Services { get; }
        void Register<TService, TImplementation>(InjectionType type);
        void RegisterInstance<TService>(TService instance);
        void Remove<TService>();
    }
}
