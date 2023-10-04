using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Abstract
{
    public interface IApplicationContainer
    {
        IServiceCollection Services { get; }
        TService Resolve<TService>();
    }
}
