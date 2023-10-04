using DependencyInjection.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Abstract
{
    public interface IServiceModel
    {
        Type ServiceType { get; }
        Type InstanceType { get; }
        object Instance { get; set; }
        InjectionType InjectionType { get; }
    }
}
