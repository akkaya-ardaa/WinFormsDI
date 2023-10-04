using DependencyInjection.Concrete;
using ExampleServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationBuilder.Run<MainForm>(container =>
            {
                container.Services.Register<IAnimalService, DogService>(InjectionType.Singleton);
                container.Services.Register<IAnimalFoodService, CatFoodService>(InjectionType.Singleton);
               
                container.Services.Register<SecondaryForm, SecondaryForm>(InjectionType.Singleton);
                container.Services.Register<ThirdForm, ThirdForm>(InjectionType.Singleton);
            });
        }
    }
}
