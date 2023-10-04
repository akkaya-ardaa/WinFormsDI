using DependencyInjection.Abstract;
using DependencyInjection.WinForms.Abstract;
using ExampleServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DependencyInjection.Concrete
{
    public static class ApplicationBuilder
    {
        /// <summary>
        /// Starts forms applications.
        /// </summary>
        /// <typeparam name="TStartupForm">Form to start application with.</typeparam>
        public static void Run<TStartupForm>(Action<IApplicationContainer> configuration) where TStartupForm : Form, IMainForm
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IApplicationContainer container = new ApplicationContainer();
            container.Services.Register<IMainForm, TStartupForm>(InjectionType.Singleton);

            configuration.Invoke(container);

            Form instance = (Form)container.Resolve<IMainForm>();
            
            Application.Run(instance);
        }

    }
}
