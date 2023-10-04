using DependencyInjection.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Concrete
{
    public class ServiceModel : IServiceModel
    {
        public Type ServiceType { get; set; }
        public Type InstanceType { get; set; }
        public object Instance { get; set; }
        public InjectionType InjectionType { get; set; }
    }
}
